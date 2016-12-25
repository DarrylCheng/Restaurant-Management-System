using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace RestaurantMS_Definitive
{
    public class CustomerOrder
    {
        public static string createDineInOrder(string tableID)
        {
            dbConn con = new dbConn();
            con.open();
            OleDbCommand order = new OleDbCommand();
            order.CommandType = CommandType.Text;
            order.CommandText = "INSERT INTO customerOrder(orderDate) values(@date)";
            order.Parameters.AddWithValue("@date", DateTime.Today);
            order.Connection = con.oleconnection;
            order.ExecuteNonQuery();
            order.CommandText = "SELECT @@IDENTITY";
            String orderID = order.ExecuteScalar().ToString();

            OleDbCommand table = new OleDbCommand();
            table.CommandType = CommandType.Text;
            table.CommandText = "UPDATE restaurantTables SET orderID = @orderID WHERE tableID = @tableID";
            table.Parameters.AddWithValue("@orderID", orderID);
            table.Parameters.AddWithValue("@tableID",tableID);
            table.Connection = con.oleconnection;
            table.ExecuteNonQuery();
            con.close();
            return orderID;
        }

        public static string createTakeAwayOrder()
        {
            dbConn con = new dbConn();
            con.open();
            OleDbCommand order = new OleDbCommand();
            order.CommandType = CommandType.Text;
            order.CommandText = "INSERT INTO customerOrder(orderDate) values(@date)";
            order.Parameters.AddWithValue("@date", DateTime.Today);
            order.Connection = con.oleconnection;
            order.ExecuteNonQuery();
            order.CommandText = "SELECT @@IDENTITY";
            String orderID = order.ExecuteScalar().ToString();

            OleDbCommand takeAway = new OleDbCommand();
            takeAway.CommandType = CommandType.Text;
            takeAway.CommandText = "INSERT INTO takeAwayOrders(orderID) values(@orderID)";
            takeAway.Parameters.AddWithValue("@orderID", orderID);
            takeAway.Connection = con.oleconnection;
            takeAway.ExecuteNonQuery();
            con.close();
            return orderID;
        }

        //It's more efficient to have the calling function pass in its own connection than to keep re-establishing a connection for each item in the order.
        //The calling function have to manage the connection.
        public static void addItemToOrder(OleDbConnection con, string orderID, Item item, int quantity)
        { 
            string sqlQuery = "SELECT * FROM orderDetails WHERE orderID = @orderID AND itemID = @itemID;";
            OleDbCommand cmd = new OleDbCommand(sqlQuery, con);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@itemID", item.itemID);
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows) //If item already exist in the order
            {
                //Since I couldn't get nested SQL queries to work.
                //Get old values for update.
                int oldItemQuantity = int.Parse(reader["itemQuantity"].ToString());
                double oldSubPrice = double.Parse(reader["subTotalPrice"].ToString());

                //Update the values
                //Derive item price from quantity and total price
                int newItemQuantity = oldItemQuantity + 1;
                double newSubPrice = (oldSubPrice / oldItemQuantity) * newItemQuantity;

                //Here comes the actual update query
                OleDbCommand update = new OleDbCommand("UPDATE orderDetails SET itemQuantity = @qty, subTotalPrice = @price WHERE orderID = @orderID AND itemID = @itemID", con);
                update.Parameters.AddWithValue("@qty", newItemQuantity);
                update.Parameters.AddWithValue("@price", newSubPrice);
                update.Parameters.AddWithValue("@orderID", orderID);
                update.Parameters.AddWithValue("@itemID", item.itemID);
                update.ExecuteNonQuery();
            }
            else
            {
                OleDbCommand orderDetails = new OleDbCommand();
                orderDetails.CommandType = CommandType.Text;
                orderDetails.CommandText = "INSERT INTO orderDetails (orderID,itemID,itemQuantity,subTotalPrice) VALUES (@orderID,@itemID,@itemQuantity,@sPrice);";
                orderDetails.Connection = con;
                orderDetails.Parameters.AddWithValue("@orderID", orderID);
                orderDetails.Parameters.AddWithValue("@itemID", item.itemID);
                orderDetails.Parameters.AddWithValue("@itemQuantity", quantity);
                orderDetails.Parameters.AddWithValue("@sPrice", Double.Parse(item.itemPrice) * quantity);
                orderDetails.ExecuteNonQuery();
            }
        }

        public static void deleteItem(string orderID, Item item)
        {
            dbConn con = new dbConn();
            con.open();
            string sqlQuery = "SELECT * FROM orderDetails WHERE orderID = @orderID AND itemID = @itemID;";
            OleDbCommand cmd = new OleDbCommand(sqlQuery, con.oleconnection);
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Parameters.AddWithValue("@itemID", item.itemID);
            OleDbDataReader reader = cmd.ExecuteReader();
            reader.Read();
            if (reader.HasRows) //If item exist in the order
            {
                int quantity = int.Parse(reader["itemQuantity"].ToString());
                if (quantity > 1)
                {
                    //Since I couldn't get nested SQL queries to work.
                    //Get old values for update.
                    int oldItemQuantity = int.Parse(reader["itemQuantity"].ToString());
                    double oldSubPrice = double.Parse(reader["subTotalPrice"].ToString());

                    //Update the values
                    //Derive item price from quantity and total price
                    int newItemQuantity = oldItemQuantity - 1;
                    double newSubPrice = (oldSubPrice / oldItemQuantity) * newItemQuantity;

                    //Here comes the actual update query
                    OleDbCommand update = new OleDbCommand("UPDATE orderDetails SET itemQuantity = @qty, subTotalPrice = @price WHERE orderID = @orderID AND itemID = @itemID", con.oleconnection);
                    update.Parameters.AddWithValue("@qty", newItemQuantity);
                    update.Parameters.AddWithValue("@price", newSubPrice);
                    update.Parameters.AddWithValue("@orderID", orderID);
                    update.Parameters.AddWithValue("@itemID", item.itemID);
                    update.ExecuteNonQuery();
                }else
                {
                    OleDbCommand orderDetails = new OleDbCommand();
                    orderDetails.CommandType = CommandType.Text;
                    orderDetails.CommandText = "DELETE FROM orderDetails WHERE orderID = @orderID AND itemID = @itemID;";
                    orderDetails.Connection = con.oleconnection;
                    orderDetails.Parameters.AddWithValue("@orderID", orderID);
                    orderDetails.Parameters.AddWithValue("@itemID", item.itemID);
                    orderDetails.ExecuteNonQuery();
                }
            }

            con.close();
        }

        public static List<ListViewItem> getOrderDetails(string orderID)
        {
            dbConn con = new dbConn();
            con.open();
            OleDbDataReader reader = default(OleDbDataReader);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT menu.itemID, itemName, itemQuantity, subTotalPrice from orderDetails, menu where orderID  = @orderID AND orderDetails.itemID = menu.itemID";
            cmd.Parameters.AddWithValue("@orderID", orderID);
            cmd.Connection = con.oleconnection;
            reader = cmd.ExecuteReader();

            List<ListViewItem> toReturn = new List<ListViewItem>();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(new String[] { reader["itemID"].ToString(), reader["itemName"].ToString(), reader["itemQuantity"].ToString(), currency.toCurrency(reader["subTotalPrice"].ToString()) });
                toReturn.Add(item);
            }
            con.close();
            return toReturn;
        }

        public static void orderPayment(string orderID)
        {
            dbConn con = new dbConn();
            con.open();
            OleDbCommand update = new OleDbCommand("UPDATE customerOrder SET orderPaid = TRUE WHERE orderID = @orderID", con.oleconnection);
            update.Parameters.AddWithValue("@orderID", orderID);
            update.ExecuteNonQuery();

            update = new OleDbCommand("UPDATE restaurantTables SET orderID = NULL WHERE orderID = @orderID", con.oleconnection);
            update.Parameters.AddWithValue("@orderID", orderID);
            update.ExecuteNonQuery();

            con.close();
        }

        public static List<ListViewItem> getDineInOrders()
        {
            List<ListViewItem> toReturn = new List<ListViewItem>();
            dbConn con = new dbConn();
            OleDbDataReader reader = default(OleDbDataReader);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT restaurantTables.orderID, tableID from restaurantTables INNER JOIN customerOrder on restaurantTables.orderID = customerOrder.orderID WHERE customerOrder.orderPaid = false AND restaurantTables.orderID <> NULL;";
            cmd.Connection = con.oleconnection;
            try
            {
                con.open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new String[] { reader["orderID"].ToString(), reader["tableID"].ToString() });
                    toReturn.Add(item);
                }
            }
            catch (Exception ex) { }
            finally
            {
                con.close();
            }
            return toReturn;
        }

        public static List<ListViewItem> getTakeAwayOrders()
        {
            List<ListViewItem> toReturn = new List<ListViewItem>();
            dbConn con = new dbConn();
            OleDbDataReader reader = default(OleDbDataReader);
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT takeAwayOrders.orderID, takeAwayID from takeAwayOrders INNER JOIN customerOrder on takeAwayOrders.orderID = customerOrder.orderID WHERE customerOrder.orderPaid = false;";
            cmd.Connection = con.oleconnection;
            try
            {
                con.open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new String[] { reader["orderID"].ToString(), reader["takeAwayID"].ToString() });
                    toReturn.Add(item);
                }
            }
            catch (Exception ex) { }
            finally
            {
                con.close();
            }
            return toReturn;
        }

    }
}
