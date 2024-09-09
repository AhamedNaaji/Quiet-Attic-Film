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
    public partial class Staff : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NAAJI\\SQLEXPRESS01;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True;");
        string id = "";
        public Staff()
        {
            InitializeComponent();
        }

        void myFillGridDetail()
        {
            try
            {
                string qry = "SELECT * FROM Staff";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgvstaff.DataSource = dt;

                dgvstaff.Columns[0].HeaderText = "StaffID";
                dgvstaff.Columns[1].HeaderText = "StaffName";
                dgvstaff.Columns[3].HeaderText = "StaffContactNo";
                dgvstaff.Columns[2].HeaderText = "StaffType";
                dgvstaff.Columns[0].Width = 200;

            }
            catch (SqlException exex)
            {
                MessageBox.Show(exex.Message);
            }
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                try
                {
                    string staffname = txtstaffname.Text.Trim();
                    string staffcontactno = txtstaffconNo.Text.Trim();
                    string stafftype = cmbstafftype.Text;



                string qry = "INSERT INTO Staff" + "(StaffName, StaffType, StaffContactNo) " +
                        "VALUES('" + staffname + "','" + stafftype + "','" + staffcontactno + "')";

                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Inserted Successfully");
                    myFillGridDetail();




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

        private void btnNew_Click(object sender, EventArgs e)
        {
            lblStaffID.Text = "";
            txtstaffname.Text = "";
            txtstaffconNo.Text = "";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Do you want to update", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "UPDATE Staff SET " +
                        "StaffName = '" + txtstaffname.Text.Trim() + "'," +
                        "staffcontactno = '" + txtstaffconNo.Text.Trim() + "'" +
                        "StaffType = '" + cmbstafftype.SelectedValue.GetType() + "'" +
                        "WHERE Staff = " + id;
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

        private void Staff_Load(object sender, EventArgs e)
        {
            myFillGridDetail();
        }

        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM Staff WHERE StaffID = " + id;
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

        private void dgvstaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvstaff.Rows[e.RowIndex].Cells[0].Value.ToString();
            try
            {
                string qry = "SELECT * FROM Staff WHERE StaffID = " + id;
                con.Open();
                SqlCommand cmd = new SqlCommand(qry, con);
                SqlDataReader rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    lblStaffID.Text = rdr[0].ToString();
                    txtstaffname.Text = rdr[1].ToString();
                    txtstaffconNo.Text = rdr[3].ToString();
                    cmbstafftype.Text = rdr[2].ToString();
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

    }
    
}
