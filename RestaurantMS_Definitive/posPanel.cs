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
    public partial class posPanel : MaterialForm
    {
        dbConn con = new dbConn();
        RestaurantMenu rMenu = new RestaurantMenu();
        string loggedInUser;
        public posPanel(string loggedInUser)
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.loggedInUser = loggedInUser;
        }

        private void posPanel_Load(object sender, EventArgs e)
        {
            initialize();
        }
        private void initialize()
        {
            readMenuDB("food");
            readTableIDs();
        }

        private void readTableIDs() {
            tableID.Text = "";
            tableID.Items.Clear();
            OleDbCommand data = new OleDbCommand();
            data.CommandType = CommandType.Text;
            data.CommandText = "SELECT tableID, orderID FROM restaurantTables";
            data.Connection = con.oleconnection;
            OleDbDataReader reader = default(OleDbDataReader);

            try
            {
                con.open();
                reader = data.ExecuteReader();
                while (reader.Read())
                {
                    //If table has order mapped to it, ignore.
                    //Only displays table which are empty
                    if (reader["orderID"].ToString() == String.Empty)
                    {
                        tableID.Items.Add(reader["tableID"].ToString());
                    }
                }
            }
            catch (Exception ex) { }
            finally { con.close();  }
        }

        //category is either food or beverage
        private void readMenuDB(string category)
        {
            menuView.Items.Clear();
            List<Item> menu = rMenu.getItemsByCategory(category);
            foreach(Item item in menu)
            {
                ListViewItem itemView = new ListViewItem(new String[] { item.itemID, item.itemName, item.itemPrice });
                menuView.Items.Add(itemView);
            }
        }

        private void beverageCategory_Click(object sender, EventArgs e)
        {
            readMenuDB("beverage");
        }

        private void foodCategory_Click(object sender, EventArgs e)
        {
            readMenuDB("food");
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            Settings s = new Settings(loggedInUser);
            this.Hide();
            DialogResult dr = s.ShowDialog();
            if (dr == DialogResult.OK) {
                this.Close();
            }
            this.Show();
            rMenu.updateRestaurantMenu();
            readMenuDB("food");
            readTableIDs();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            currentOrderView.Items.Clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (currentOrderView.SelectedItems.Count > 0) {
                ListViewItem item = currentOrderView.Items[currentOrderView.SelectedItems[0].Index];
                int quantity = int.Parse(item.SubItems[2].Text);
                if (quantity > 1)
                {
                    item.SubItems[2].Text = (quantity - 1).ToString();
                    //Derive item price from quantity and total price
                    double newItemPrice = ( double.Parse(item.SubItems[3].Text) / quantity ) * (quantity-1);
                    item.SubItems[3].Text = currency.toCurrency(newItemPrice);
                }
                else
                {
                    item.Remove();
                }
            }
        }

        private void insertOrderButton_Click(object sender, EventArgs e)
        {
            if (itemIDText.TextLength > 0)
            {
                try
                {
                    Item itemToAdd = rMenu.getItemByItemID(itemIDText.Text);
                    bool contains = false;
                    int quantity = 1;
                    foreach (ListViewItem items in currentOrderView.Items)
                    {
                        contains = items.SubItems[0].Text == itemToAdd.itemID;
                        if (contains)
                        {
                            quantity = int.Parse(items.SubItems[2].Text) + 1;
                            items.SubItems[2].Text = quantity.ToString();
                            double itemPrice = double.Parse(itemToAdd.itemPrice) * quantity;
                            items.SubItems[3].Text = currency.toCurrency(itemPrice);
                            return;
                        }
                    }
                    ListViewItem item = new ListViewItem(new String[] { itemToAdd.itemID, itemToAdd.itemName, quantity.ToString(), itemToAdd.itemPrice });
                    currentOrderView.Items.Add(item);
                }
                catch (Exception ex) { }
            }
        }

        private void takeAwayButton_Click(object sender, EventArgs e)
        {
            if (currentOrderView.Items.Count > 0)
            {
                string orderID = CustomerOrder.createTakeAwayOrder();
                con.open();
                foreach (ListViewItem items in currentOrderView.Items)
                {
                    Item item = rMenu.getItemByItemID(items.SubItems[0].Text);
                    int quantity = int.Parse(items.SubItems[2].Text);
                    CustomerOrder.addItemToOrder(con.oleconnection, orderID, item, quantity);
                }
                con.close();
                currentOrderView.Items.Clear();
            }
        }

        private void eatingHereButton_Click(object sender, EventArgs e)
        {
            if (currentOrderView.Items.Count > 0 )
            {
                if (tableID.Text == String.Empty) {
                    MessageBox.Show("Please Select A Table!");
                    return;
                }
                string orderID = CustomerOrder.createDineInOrder(tableID.Text);
                con.open();
                foreach (ListViewItem items in currentOrderView.Items)
                {
                    Item item = rMenu.getItemByItemID(items.SubItems[0].Text);
                    int quantity = int.Parse(items.SubItems[2].Text);
                    CustomerOrder.addItemToOrder(con.oleconnection,orderID,item, quantity);
                }
                con.close();
                currentOrderView.Items.Clear();
                readTableIDs();
            } else
            {
                MessageBox.Show("Order Empty!");
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            orderMaster m = new orderMaster(rMenu);
            m.hidePaymentWindow();
            m.Text = m.Text + " [Modify Order]";
            this.Hide();
            m.ShowDialog();
            this.Show();
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            orderMaster m = new orderMaster(rMenu);
            m.Text = m.Text + " [Payment Window]";
            this.Hide();
            m.ShowDialog();
            this.Show();
            readTableIDs();
        }

        private void menuView_SelectedIndexChanged(object sender, EventArgs e) {
            if(menuView.SelectedItems.Count == 1)
            {
                itemIDText.Text = menuView.SelectedItems[0].SubItems[0].Text;
            }      
        }
    }
}
