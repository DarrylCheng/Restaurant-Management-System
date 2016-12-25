using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
namespace RestaurantMS_Definitive
{
    public class RestaurantMenu
    {
        List<Item> restaurantItems = new List<Item>();
        dbConn con = new dbConn();
        public RestaurantMenu()
        {
            updateRestaurantMenu();
        }

        public void updateRestaurantMenu()
        {
            restaurantItems.Clear();
            string sqlquery = "SELECT itemID, itemName, itemPrice, itemCategory FROM menu WHERE itemValidity = TRUE;";
            OleDbCommand cmd = new OleDbCommand(sqlquery, con.oleconnection);
            try
            {
                con.open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Item item = new Item(reader["itemID"].ToString(), reader["itemName"].ToString(), currency.toCurrency(reader["itemPrice"].ToString()), reader["itemCategory"].ToString());
                    restaurantItems.Add(item);
                }
            }
            catch (Exception ex) { }
            finally
            {
                con.close();
            }
        }

        public List<Item> getItemsByCategory(string category)
        {
            List<Item> toReturn = new List<Item>();
            foreach(Item item in restaurantItems)
            {
                if(item.itemCategory == category)
                {
                    toReturn.Add(item);
                }
            }
            return toReturn;
        }

        public Item getItemByItemID(string itemID)
        {
            foreach (Item item in restaurantItems)
            {
                if (item.itemID == itemID)
                {
                    return item;
                }
            }
            throw new System.ArgumentException("Invalid item ID.");
        }

        public static void removeItemByItemID(string itemID)
        {
            dbConn con = new dbConn();
            con.open();
            string sqlquery = "UPDATE menu set itemValidity = FALSE WHERE itemID=@itemID;";
            OleDbCommand cmd = new OleDbCommand(sqlquery, con.oleconnection);
            cmd.Parameters.AddWithValue("@itemID",itemID);
            cmd.ExecuteNonQuery();
            con.close();
        }

        public static string addItem(string itemName, string itemPrice, string itemCategory)
        {
            dbConn con = new dbConn();
            try
            {
               
                con.open();
                string sqlquery = "INSERT INTO menu(itemName,itemPrice,itemCategory)values(@itemName,@itemPrice,@itemCategory)";
                OleDbCommand cmd = new OleDbCommand(sqlquery, con.oleconnection);
                cmd.Parameters.AddWithValue("@itemName", itemName);
                cmd.Parameters.AddWithValue("@itemPrice", itemPrice);
                cmd.Parameters.AddWithValue("@itemCategory", itemCategory);
                cmd.ExecuteNonQuery();
                cmd.CommandText = "SELECT @@IDENTITY";
                string itemID = cmd.ExecuteScalar().ToString();
                return itemID;
            }
            catch(Exception ex)
            {
                throw new System.ArgumentException("Unable to Add!");
            }
            finally
            {
                con.close();

            }
        }
    }
}
