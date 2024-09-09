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
    public partial class Staff_Type : Form
    {

        SqlConnection con = new SqlConnection("Data Source=NAAJI\\SQLEXPRESS01;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True;");
        string id = "";


        public Staff_Type()
        {
            InitializeComponent();
        }


        void myFillGridDetail()
        {
            try
            {
                string qry = "SELECT * FROM StaffType";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgvstafftype.DataSource = dt;

                dgvstafftype.Columns[0].HeaderText = "Staff Type";
                dgvstafftype.Columns[1].HeaderText = "Fee";

            }
            catch (SqlException exex)
            {
                MessageBox.Show(exex.Message);
            }
        }

        private void Staff_Type_Load(object sender, EventArgs e)
        {
            myFillGridDetail();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
                try
                {

                    string type = cmbStaffType.Text;
                    string fee = cmbstaffFee.Text;



                    string qry = "INSERT INTO StaffType" +
                        "( Type, Fee)" +
                        " VALUES( '" + type + "','" + fee + "')";

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM StaffType WHERE Type = '" + id + "'";
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

        private void Staff_Type_Load_1(object sender, EventArgs e)
        {
            myFillGridDetail();
        }

        private void dgvstafftype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvstafftype.Rows[e.RowIndex].Cells[0].Value.ToString();
            
        }
    }
}
