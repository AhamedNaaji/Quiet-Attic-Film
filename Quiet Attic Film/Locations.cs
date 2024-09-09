using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiet_Attic_Film
{
    public partial class Locations : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NAAJI\\SQLEXPRESS01;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True;");
        string id = "";
        public Locations()
        {
            InitializeComponent();
        }

        private void Locations_Load(object sender, EventArgs e)
        {
            myFillGridDetail();
        }


       


        void myFillGridDetail()
        {
            try
            {
                string qry = "SELECT * FROM Location";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgvLocation.DataSource = dt;

                dgvLocation.Columns[0].HeaderText = "Location ID";
                dgvLocation.Columns[1].HeaderText = "Location";

            }
            catch (SqlException exex)
            {
                MessageBox.Show(exex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertLocation();
        }

        private void dgvLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvLocation.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        void cellDoubleClick()
        {


            try
            {
                string qry = "SELECT * FROM Location WHERE LocationID = " + id;
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtLocation.Text = rdr[1].ToString();
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

        void insertLocation()
        {
            try
            {
                string location = txtLocation.Text.Trim();
                string qry = "INSERT INTO Location" +
                        "(Location)" +
                        " VALUES( '" + location + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.ExecuteNonQuery();
                btnSave.PerformClick();
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

        void updateLocation()
        {
            try
            {


                if (MessageBox.Show("Do you want to update", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "UPDATE Location SET " +

                        "Location = '" + txtLocation.Text.Trim() + "WHERE LocationID = " + id;
                    ;


                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "Update Operation");
                    updateBtn.PerformClick();
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

        private void updateBtn_Click(object sender, EventArgs e)
        {
            updateLocation();
        }


        void deleteLocation()
        {
            try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM Location WHERE LocationID = " + id;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Delete Successfully", "Delete Operation");
                    btnDelete.PerformClick();
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
            deleteLocation();
        }
    }
}
