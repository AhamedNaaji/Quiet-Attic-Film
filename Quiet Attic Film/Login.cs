using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.PeerToPeer;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Quiet_Attic_Film
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NAAJI\\SQLEXPRESS01;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True;");
        string id = "";
        public Login()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();
            try
            {
                if (string.IsNullOrWhiteSpace(txtusername.Text) || string.IsNullOrWhiteSpace(txtpassword.Text))
                {
                    MessageBox.Show("Please enter both username and password.");
                    return;
                }
                if (txtusername.Text.Trim() != "" && txtpassword.Text.Trim() != "")
                {
                    con.Open();
                    string qry = "SELECT * FROM Users WHERE username = '" + username + "' AND password = '" + password + "'";

                    SqlCommand cmd = new SqlCommand(qry, con);
                    SqlDataReader rdr = cmd.ExecuteReader();

                    if (rdr.Read())
                    {
                        MessageBox.Show("Login Successfull!!");
                        Dashboard dashboard = new Dashboard();
                        dashboard.Show();

                    }
                    else
                        MessageBox.Show("Incorrect Username or Password");
                }
                else
                    MessageBox.Show("Incorrect Username or Password");
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }






private void btnreset_Click(object sender, EventArgs e)
        {
            txtusername.Text = "";
            txtpassword.Text = "";
        }
    }
}
