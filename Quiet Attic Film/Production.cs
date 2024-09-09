using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Quiet_Attic_Film
{
    public partial class Production : Form
    {
        public Production()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=NAAJI\\SQLEXPRESS01;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True;");
        string productionID = "";
        private string id;

        void myFillGridDetail()
        {
            try
            {


                string qry = "SELECT Production.ProductionID, Production.ProductionType, Production.Days, Client.ClientName FROM" +
                    "\r\nProduction INNER JOIN Client ON Production.ClientID = Client.ClientID;";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgvproduction.DataSource = dt;

                dgvproduction.Columns[0].HeaderText = "ProductionID";
                dgvproduction.Columns[1].HeaderText = "ProductionType";
                dgvproduction.Columns[2].HeaderText = "Days";
                dgvproduction.Columns[3].HeaderText = "ClientName";
                
                dgvproduction.Columns[0].Width = 50;
                dgvproduction.Columns[1].Width = 80;
                dgvproduction.Columns[2].Width = 80;
                dgvproduction.Columns[3].Width = 80;
                

                dgvproduction.Columns[0].Visible = false;

            }
            catch (SqlException exex)
            {
                MessageBox.Show(exex.Message);
            }

        }

        void fillClientCombo()
        {
            string qry = "SELECT * FROM Client;";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds); ;

            cmbclient.DataSource = ds.Tables[0];
            cmbclient.DisplayMember = "ClientName";
            cmbclient.ValueMember = "ClientID";
        }

        private void Production_Load(object sender, EventArgs e)
        {
            myFillGridDetail();
            fillClientCombo();
        }

        private void dgvproduction_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productionID = dgvproduction.Rows[e.RowIndex].Cells[0].Value.ToString();
            id = dgvproduction.Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                string qry = "SELECT * FROM Staff WHERE StaffID = " + id;
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    cmbclient.Text = rdr[0].ToString();
                    cmbproductiontype.Text = rdr[1].ToString();
                    txtNoofDays.Text = rdr[3].ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            };
        }

        void deleteProduction()
        {
            try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM Production WHERE ProductionID  = " + productionID ;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully", "Delete Operation");
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteProduction();
        }

        void insertProduction()
        {
            try
            {


                string qry = "INSERT INTO Production" +
                    "( ProductionType, Days,ClientID)" +
                    " VALUES( '" + cmbproductiontype.Text + "','" + txtNoofDays.Text + "','" + cmbclient.SelectedValue + "')";

                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Saved Successfully");

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertProduction();
        }

        void updateProduction()
        {
            try
            {


                if (MessageBox.Show("Do you want to update", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "UPDATE Production SET " +

                        "ProductionType = '" + cmbproductiontype.Text.Trim() + "'," +
                        "Days = '" + txtNoofDays.Text.Trim() + "'," +
                        "ClientID = '" + cmbclient.SelectedValue + "'" + "WHERE ProductionID = " + productionID;
                    ;


                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "Update Operation");
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateProduction();
        }

        private void cmbproductiontype_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dgvproduction_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNoofDays_TextChanged(object sender, EventArgs e)
        {


            //int value = Convert.ToInt32(txtNoofDays.Text);




            //    MessageBox.Show("Please enter a valid integer value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }    
    }
}
