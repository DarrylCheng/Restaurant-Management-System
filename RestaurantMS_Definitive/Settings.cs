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
    public partial class Settings : MaterialForm
    {
        string loggedInUser;
        string privilege;
        public Settings(string user)
        {
            InitializeComponent();
            loggedInUser = user;

        }

        private void Settings_Load(object sender, EventArgs e)
        {
           
            dbConn con = new dbConn();
            OleDbDataReader reader = default(OleDbDataReader);

            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT loginUsername, privilege FROM Login where loginUsername = @username";
            cmd.Parameters.AddWithValue("@username", loggedInUser);
            cmd.Connection = con.oleconnection;

            try
            {
                con.open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows) {
                    privilege = (string)reader["privilege"];
                    userLabel.Text = (string)reader["loginUsername"] + " (" + privilege + ")";
                    
                }

                if (!(privilege == "ADMIN") ){
                    adminButton.Enabled = false;
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

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void adminButton_Click(object sender, EventArgs e)
        {
            AdminPanel a = new AdminPanel();
            
            this.Hide();
            a.ShowDialog();
            this.Close();
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
