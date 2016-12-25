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
    public partial class loginPanel : MaterialForm
    {
        public loginPanel()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void loginPanel_Load(object sender, EventArgs e)
        {
            errorLabel.Visible = false;
            errorIcon.Visible = false;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            login();
        }

        public void login()
        {
            bool authenticated = false;
            dbConn con = new dbConn();
            String sqlSelect = "SELECT loginUserID, loginUsername, loginPassword FROM Login where loginUsername = @username;";
            OleDbCommand cmd = new OleDbCommand(sqlSelect, con.oleconnection);
            cmd.Parameters.AddWithValue("@username", usernameText.Text);
            OleDbDataReader reader = default(OleDbDataReader);
            try
            {
                con.open();
                reader = cmd.ExecuteReader();
                reader.Read();
                if (reader.HasRows == true)
                {
                    if (passwordText.Text == (string)reader["loginPassword"])
                    {
                        usernameText.Text = (string)reader["loginUsername"];
                        authenticated = true;

                    }
                }
            }
            catch (Exception ex) { }
            finally
            {
                con.close();
            }

            if (authenticated)
            {
                posPanel pos = new posPanel(usernameText.Text);
                this.Hide();
                pos.ShowDialog();
                this.Show();
                errorLabel.Visible = false;
                errorIcon.Visible = false;
                usernameText.Text = "";
                passwordText.Text = "";
            }
            else
            {
                errorLabel.ForeColor = Color.Red;
                errorLabel.Visible = true;
                errorIcon.Visible = true;
            }
        }

    }
}
