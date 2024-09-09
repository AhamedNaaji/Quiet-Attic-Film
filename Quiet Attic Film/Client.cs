using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiet_Attic_Film
{


    public partial class Clients : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NAAJI\\SQLEXPRESS01;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True;");
        string id = "";
        

        public Clients()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                string client_name = txtClientName.Text.Trim();
                string client_address = txtClientAddress.Text.Trim();
                string contactno = txtClientContactNo.Text.Trim();



                string qry = "INSERT INTO Client" +
                    "( ClientName, ClientAddress,ClientContactNo)" +
                    " VALUES( '" + client_name + "','" + client_address + "','" + contactno + "')";

                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                
                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully");

                btnNew.PerformClick();

                myFillGridDetail();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void myFillGridDetail()
        {
            try
            {
                string qry = "SELECT * FROM Client";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgvclient.DataSource = dt;

                dgvclient.Columns[0].HeaderText = "clientid";
                dgvclient.Columns[1].HeaderText = "client_name";
                dgvclient.Columns[2].HeaderText = "client_address";
                dgvclient.Columns[3].HeaderText = "contactno";

            }
            catch (SqlException exex)
            {
                MessageBox.Show(exex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateClient();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            insertClient();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteClient();
        }

        private void Clients_Load(object sender, EventArgs e)
        {
            myFillGridDetail();
        }

       

        private void txtClientName_TextChanged(object sender, EventArgs e)
        {
            txtClientName.BackColor = Color.MistyRose;
        }

        private void dgvclient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvclient.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void txtClientAddress_TextChanged(object sender, EventArgs e)
        {
            txtClientAddress.BackColor = Color.MistyRose;
        }

        private void txtClientContactNo_TextChanged(object sender, EventArgs e)
        {
            txtClientContactNo.BackColor = Color.MistyRose;


        }

        private void dgvclient_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvclient.Rows[e.RowIndex].Cells[0].Value.ToString();
            cellDoubleClick();

        }



            private void txtclientid_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblcid_Click(object sender, EventArgs e)
        {

        }

        

        void insertClient()
        {
            try
            {
            string client_name = txtClientName.Text.Trim();
            string client_address = txtClientAddress.Text.Trim();
            string contactno = txtClientContactNo.Text.Trim();
            string pattern = @"^\+\d{10,}$";

                // Create a regex object
            Regex regex = new Regex(pattern);



            if (regex.IsMatch(contactno))
            {
               string qry = "INSERT INTO Client" +
               "( ClientName, ClientAddress,ClientContactNo)" +
               " VALUES( '" + client_name + "','" + client_address + "','" + contactno + "')"; ;
            con.Open();
            SqlCommand cmd = new SqlCommand(qry, con);
            cmd.ExecuteNonQuery();
            btnNew.PerformClick();
            myFillGridDetail();
                }
                else
                {
                    MessageBox.Show("The Contact Number should start with + and be minimum of 10 numbers");
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Inserted Sucessfully!!");
            }
            finally
            {
                con.Close();
            }

        }

        void deleteClient()
        {
            try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM Client WHERE ClientID = " + id;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully", "Delete Operation");
                    btnNew.PerformClick();
                    myFillGridDetail();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void updateClient()
        {
            try
            {


                if (MessageBox.Show("Do you want to update", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "UPDATE Client SET " +

                        "ClientName = '" + txtClientName.Text.Trim() + "'," +
                        "ClientAddress = '" + txtClientAddress.Text.Trim() + "'," +
                        "ClientContactNo = '" + txtClientContactNo.Text.Trim() + "'" + "WHERE ClientID = " + id;
                    ;


                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "Update Operation");
                    btnNew.PerformClick();
                    myFillGridDetail();


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        void cellDoubleClick()
        {
            

            try
            {
                string qry = "SELECT * FROM Client WHERE ClientID = " + id;
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtClientName.Text = rdr[1].ToString();
                    txtClientAddress.Text = rdr[2].ToString();
                    txtClientContactNo.Text = rdr[3].ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnInsert_Click_1(object sender, EventArgs e)
        {
            //try
            //{

            //    string client_name = txtClientName.Text.Trim();
            //    string client_address = txtClientAddress.Text.Trim();
            //    string contactno = txtClientContactNo.Text.Trim();



            //    string qry = "INSERT INTO Client" +
            //        "( ClientName, ClientAddress,ClientContactNo)" +
            //        " VALUES( '" + client_name + "','" + client_address + "','" + contactno + "')";

            //    con.Open();
            //    SqlCommand cmd = new SqlCommand(qry, con);

            //    cmd.ExecuteNonQuery();

            //    MessageBox.Show("Saved Successfully");

                btnNew.PerformClick();

                myFillGridDetail();
                insertClient();


            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //finally
            //{
            //    con.Close();
            //}
        }

       
    }
}
