using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Data.OleDb;

namespace RestaurantMS_Definitive
{
    public partial class AdminPanel : MaterialForm
    {
        dbConn con = new dbConn();
        string selectedMenuItem;
        int numOfTables;
        public AdminPanel()
        {
            InitializeComponent();
            readMenuDB();
            dateText.Text = calendar.SelectionEnd.ToString("MM/dd/yyyy");
            monthText.Text = calendar.SelectionEnd.ToString("MMMM/yyyy");
            yearText.Text = calendar.SelectionEnd.ToString("yyyy");
            numOfTables = updateTableCount();
            updateUserTable();
        }

        public int updateTableCount()
        {
            con.open();
            OleDbCommand cmd = new OleDbCommand("SELECT count(tableID) FROM restaurantTables",con.oleconnection);
            int numOfTables = int.Parse(cmd.ExecuteScalar().ToString());
            tableNum.Text = numOfTables.ToString();
            cmd = new OleDbCommand("SELECT count(tableID) FROM restaurantTables WHERE orderID <> NULL", con.oleconnection);
            int numberOfOrders = int.Parse(cmd.ExecuteScalar().ToString());
            if (numberOfOrders > 0)
            {
                saveTable.Enabled = false;
            }
            con.close();
            return numOfTables;
        }

        private void readMenuDB()
        {
            menuView.Items.Clear();
            OleDbDataReader reader = default(OleDbDataReader);

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT itemID, itemName, itemCategory,itemPrice FROM menu WHERE itemValidity = TRUE ORDER BY itemID ASC";
            cmd.Connection = con.oleconnection;

            try
            {
                con.open();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                      ListViewItem item = new ListViewItem(new String[] { reader["itemID"].ToString(), reader["itemName"].ToString(), reader["itemCategory"].ToString(), currency.toCurrency(reader["itemPrice"].ToString()) });
                      menuView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.close();
            }
        }

        private void menuView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuView.SelectedItems.Count == 1)
            {
                selectedMenuItem = menuView.SelectedItems[0].SubItems[0].Text;
                itemIDText.Text = menuView.SelectedItems[0].SubItems[0].Text;
                itemNameText.Text = menuView.SelectedItems[0].SubItems[1].Text;
                itemPriceText.Text = currency.toCurrency(menuView.SelectedItems[0].SubItems[3].Text);
                itemCategoryText.Text = menuView.SelectedItems[0].SubItems[2].Text;
            }

        }

        private void deleteItem_Click(object sender, EventArgs e)
        {
            if(menuView.SelectedItems.Count > 0)
            {
                ListViewItem delItem = menuView.Items[menuView.SelectedItems[0].Index];
                RestaurantMenu.removeItemByItemID(delItem.SubItems[0].Text);
                delItem.Remove();
                itemIDText.Text = "";
                itemNameText.Text = "";
                itemPriceText.Text = "";
                itemCategoryText.Text = "";
            }   
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (catogoryChoice.Text == String.Empty)
            {
                MessageBox.Show("Please Select Category!");
                return;
            }
            try
            {
                string ItemID = RestaurantMenu.addItem(itemName.Text, price.Text, catogoryChoice.Text);
                ListViewItem item = new ListViewItem(new String[] { ItemID, itemName.Text, catogoryChoice.Text, currency.toCurrency(price.Text) });
                menuView.Items.Add(item);
            }
            catch (Exception ex) {
                MessageBox.Show("Unable to Add");
            }
        }
        

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateText.Text = calendar.SelectionEnd.ToString("MM/dd/yyyy");
            monthText.Text = calendar.SelectionEnd.ToString("MMMM/yyyy");
            yearText.Text = calendar.SelectionEnd.ToString("yyyy");
        }

        private void sortShow_Click(object sender, EventArgs e)
        {
            OleDbCommand cmd = default(OleDbCommand);
            con.open();
            if (date.Checked)
            {
                if(string.IsNullOrWhiteSpace(dateText.Text))
                {
                    MessageBox.Show("Select a date!");
                    return;
                }
                transactionView.Items.Clear();
                cmd = new OleDbCommand("SELECT customerOrder.orderID, customerOrder.orderDate, (SELECT sum(subTotalPrice) FROM orderDetails WHERE orderDetails.orderID = customerOrder.orderID) AS AMOUNT_RECEIVED FROM customerOrder WHERE orderPaid = TRUE AND customerOrder.orderDate = @date ORDER BY customerOrder.orderID;", con.oleconnection);
            }
            else if (month.Checked)
            {
                if (string.IsNullOrWhiteSpace(monthText.Text))
                {
                    MessageBox.Show("Select a Month!");
                    return;
                }
                transactionView.Items.Clear();
                cmd = new OleDbCommand("SELECT customerOrder.orderID, customerOrder.orderDate, (SELECT sum(subTotalPrice) FROM orderDetails WHERE orderDetails.orderID = customerOrder.orderID) AS AMOUNT_RECEIVED FROM customerOrder WHERE orderPaid = TRUE AND month(customerOrder.orderDate) = month(@date) ORDER BY customerOrder.orderID;", con.oleconnection);
            }
            else if (year.Checked)
            {
                if (string.IsNullOrWhiteSpace(yearText.Text))
                {
                    MessageBox.Show("Select a Year!");
                    return;
                }
                transactionView.Items.Clear();
                cmd = new OleDbCommand("SELECT customerOrder.orderID, customerOrder.orderDate, (SELECT sum(subTotalPrice) FROM orderDetails WHERE orderDetails.orderID = customerOrder.orderID) AS AMOUNT_RECEIVED FROM customerOrder WHERE orderPaid = TRUE AND year(customerOrder.orderDate) = year(@date) ORDER BY customerOrder.orderID;", con.oleconnection);
            } else
            {
                return;
            }

            cmd.Parameters.AddWithValue("@date", dateText.Text);
            OleDbDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ListViewItem item = new ListViewItem(new string[] { reader["orderID"].ToString(), Convert.ToDateTime(reader["orderDate"]).ToString("MM/dd/yyyy"), currency.toCurrency(reader["AMOUNT_RECEIVED"].ToString()) });
                transactionView.Items.Add(item);
            }
            con.close();
            updateAmount();
        }

        public void updateAmount()
        {
            double amount = 0;
            foreach(ListViewItem item in transactionView.Items)
            {
                amount = amount + Double.Parse(item.SubItems[2].Text);
            }
            totalAmount.Text = currency.toCurrency(amount.ToString());
        }

        private void saveTable_Click(object sender, EventArgs e)
        {
            int newTableNum = int.Parse(tableNum.Text);
            int count = numOfTables;
            if (newTableNum > numOfTables)
            {
                con.open();
                while (count < newTableNum) {
                    count++;
                    OleDbCommand cmd = new OleDbCommand("INSERT INTO restaurantTables VALUES (@tableID, NULL);", con.oleconnection);
                    cmd.Parameters.AddWithValue("@tableID", count);
                    cmd.ExecuteNonQuery();
                }
                con.close();
                MessageBox.Show("Successful");
            }
            else if(newTableNum < numOfTables)
            {
                con.open();
                while (count > newTableNum)
                {
                    OleDbCommand cmd = new OleDbCommand("DELETE FROM restaurantTables WHERE tableID = @tableID;", con.oleconnection);
                    cmd.Parameters.AddWithValue("@tableID", count);
                    cmd.ExecuteNonQuery();
                    count--;
                }
                con.close();
                MessageBox.Show("Successful");
            }
            numOfTables = updateTableCount();
        }

        private void addNewUser_Click(object sender, EventArgs e)
        {
            con.open();
            try
            {
                if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(pw.Text))
                {
                    MessageBox.Show("Invalid Input!");
                    return;
                }
                OleDbCommand cmd = new OleDbCommand("INSERT INTO Login (loginUsername,loginPassword,privilege) VALUES (@user,@pw,@privilege);", con.oleconnection);
                cmd.Parameters.AddWithValue("@user", name.Text);
                cmd.Parameters.AddWithValue("@pw", pw.Text);
                cmd.Parameters.AddWithValue("@privilege", "USER");
                cmd.ExecuteNonQuery();
            } catch (Exception ex)
            {

            } finally
            {
                con.close();
                updateUserTable();
            }
        }


        public void updateUserTable()
        {
            con.open();
            try
            {
                userView.Items.Clear();
                OleDbCommand cmd = new OleDbCommand("SELECT * FROM Login;", con.oleconnection);
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    ListViewItem item = new ListViewItem(new string[] {reader["loginUserID"].ToString(), reader["loginUsername"].ToString(), reader["privilege"].ToString() });
                    userView.Items.Add(item);
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {
                con.close();
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (userView.SelectedItems.Count > 0)
            { 
                try
                {
                    con.open();
                    ListViewItem item = userView.Items[userView.SelectedItems[0].Index];
                    int userID = int.Parse(item.SubItems[0].Text);
                    if(userID == 1)
                    {
                        MessageBox.Show("Admin cannot be removed!");
                        return;
                    }
                    OleDbCommand cmd = new OleDbCommand("DELETE FROM Login WHERE loginUserID = @userID", con.oleconnection);
                    cmd.Parameters.AddWithValue("@userID", userID);
                    cmd.ExecuteNonQuery();
                    item.Remove();
                }
                catch (Exception ex)
                {

                }
                finally
                {
                    con.close();
                }
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(itemIDText.Text))
            {
                try
                {
                    con.open();
                    OleDbCommand cmd = new OleDbCommand("UPDATE menu SET itemName = @name, itemPrice = @price, itemCategory = @category WHERE itemID = @itemID;",con.oleconnection);
                    cmd.Parameters.AddWithValue("@name", itemNameText.Text);
                    cmd.Parameters.AddWithValue("@price", itemPriceText.Text);
                    cmd.Parameters.AddWithValue("@category", itemCategoryText.Text);
                    cmd.Parameters.AddWithValue("@itemID", itemIDText.Text);
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex) { }
                finally {
                    con.close();
                    readMenuDB();
                }
            } else
            {
                MessageBox.Show("Please select an item!");
            }
        }
    }
}
