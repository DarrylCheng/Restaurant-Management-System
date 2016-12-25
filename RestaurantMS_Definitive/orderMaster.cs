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
    
    public partial class orderMaster : MaterialForm
    {
        string orderID;
        dbConn con = new dbConn();
        RestaurantMenu rMenu;
        public orderMaster(RestaurantMenu rMenu)
        {
            InitializeComponent();
            this.rMenu = rMenu;
        }

        public void hidePaymentWindow()
        {
            paymentWindow.Hide();
        }

        private void loadDineInOrders()
        {
            dineInOrders.Items.Clear();
            List<ListViewItem> item = CustomerOrder.getDineInOrders();
            foreach(ListViewItem items in item)
            {
                dineInOrders.Items.Add(items);
            }
        }

        private void loadTakeAwayOrders()
        {
            takeAwayOrders.Items.Clear();
            List<ListViewItem> item = CustomerOrder.getTakeAwayOrders();
            foreach(ListViewItem items in item)
            {
                takeAwayOrders.Items.Add(items);
            }

        }

        private void readMenuDB(string category)
        {
            menuView.Items.Clear();
            List<Item> menu = rMenu.getItemsByCategory(category);
            foreach (Item item in menu)
            {
                ListViewItem itemView = new ListViewItem(new String[] { item.itemID, item.itemName, currency.toCurrency(item.itemPrice) });
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


        private void orderMaster_Load(object sender, EventArgs e)
        {
            readMenuDB("food");
            loadTakeAwayOrders();
            loadDineInOrders();
            currentOrderView.Enabled = false;
            insertOrderButton.Enabled = false;
            paymentStatus.Hide();
        }

        private void menuView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (menuView.SelectedItems.Count == 1)
            {
                itemIDText.Text = menuView.SelectedItems[0].SubItems[0].Text;
            }
        }

        private void insertOrderButton_Click(object sender, EventArgs e)
        {
            if (itemIDText.Text.Length > 0) {
                try
                {
                    Item itemToAdd = rMenu.getItemByItemID(itemIDText.Text);
                    con.open();
                    CustomerOrder.addItemToOrder(con.oleconnection, orderID, itemToAdd, 1);
                    con.close();
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
                            items.SubItems[3].Text = currency.toCurrency(itemPrice.ToString());
                            return;
                        }
                    }
                    ListViewItem item = new ListViewItem(new String[] { itemToAdd.itemID, itemToAdd.itemName, quantity.ToString(), currency.toCurrency(itemToAdd.itemPrice) });
                    currentOrderView.Items.Add(item);
                }
                catch (Exception ex) { }
                finally { calculateTotal();}
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (currentOrderView.SelectedItems.Count > 0)
            {
                statusLabel.Text = "Item Removed.";
                ListViewItem item = currentOrderView.Items[currentOrderView.SelectedItems[0].Index];
                CustomerOrder.deleteItem(orderID, rMenu.getItemByItemID(item.SubItems[0].Text));
                int quantity = int.Parse(item.SubItems[2].Text);
                if (quantity > 1)
                {
                    item.SubItems[2].Text = (quantity - 1).ToString();
                    //Derive item price from quantity and total price
                    double newItemPrice = (double.Parse(item.SubItems[3].Text) / quantity) * (quantity - 1);
                    item.SubItems[3].Text = currency.toCurrency(newItemPrice.ToString());
                }
                else
                {
                    item.Remove();
                }
                calculateTotal();
            }
            else
            {
                statusLabel.Text = "No Item Selected!";
            }
        }

        void updateOrderTable() {
            currentOrderView.Enabled = true;
            insertOrderButton.Enabled = true;
            currentOrderView.Items.Clear();

            List<ListViewItem> details = CustomerOrder.getOrderDetails(orderID);
            foreach (ListViewItem item in details)
            {
                currentOrderView.Items.Add(item);
            }
            calculateTotal();
        }

        private double calculateTotal()
        {
            double totalPrice = 0;
            foreach (ListViewItem item in currentOrderView.Items)
            {
                totalPrice = totalPrice + double.Parse(item.SubItems[3].Text);
            }
            priceBox.Text = currency.toCurrency(totalPrice.ToString());
            return totalPrice;
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            statusLabel.Text = "Printer not connected!";
            MessageBox.Show("Printer not connected!");
        }

        private void dineInOrders_Click(object sender, EventArgs e)
        {  
            if (dineInOrders.SelectedItems.Count == 1)
            {
                orderID = dineInOrders.SelectedItems[0].SubItems[0].Text;
                updateOrderTable();
                orderGroup.Text = "Order Details <ID - " + orderID + ">";
                statusLabel.Text = orderGroup.Text;
                change.Text = "";
                amountPaid.Text = "";
            }
           
        }

        private void takeAwayOrders_Click(object sender, EventArgs e)
        {
            if (takeAwayOrders.SelectedItems.Count == 1)
            {
                orderID = takeAwayOrders.SelectedItems[0].SubItems[0].Text;
                updateOrderTable();
                orderGroup.Text = "Order Details <ID - " + orderID + ">";
                statusLabel.Text = orderGroup.Text;
                change.Text = "";
                amountPaid.Text = "";
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void paymentButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(amountPaid.Text) >= double.Parse(priceBox.Text))
                {
                    CustomerOrder.orderPayment(orderID);
                    change.Text = currency.toCurrency((double.Parse(amountPaid.Text) - double.Parse(priceBox.Text)));
                    paymentStatus.Show();
                    paymentStatus.Text = "Payment Accepted!";
                    statusLabel.Text = "Payment Accepted!";
                    priceBox.Text = "";
                    loadTakeAwayOrders();
                    loadDineInOrders();
                    currentOrderView.Items.Clear();
                    insertOrderButton.Enabled = false;
                }
                else
                {
                    paymentStatus.Show();
                    paymentStatus.Text = "Insufficient Amount!";
                    statusLabel.Text = "Insufficient Amount!";
                }
            }catch(Exception ex) { MessageBox.Show("Select an order and enter the amount paid!"); }
        }

    }
}