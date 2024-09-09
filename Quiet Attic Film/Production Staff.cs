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
    public partial class Production_Staff : Form

    {
        SqlConnection con = new SqlConnection("Data Source=NAAJI\\SQLEXPRESS01;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True;");
        string productionID = "";
        string staffID = "";
        public Production_Staff()
        {
            InitializeComponent();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            insertPropLocation();
        }

        private void Production_Staff_Load(object sender, EventArgs e)
        {
            myFillGridDetail();
            fillProductionCombo();
            fillStaffCombo();
        }

        void myFillGridDetail()
        {
            try
            {
                string qry = "SELECT Production.ProductionID, Staff.StaffID, Production.ProductionType, Staff.StaffName\r\nFROM ((ProductionStaff\r\nINNER JOIN Production ON Production.ProductionID = ProductionStaff.ProductionID)\r\nINNER JOIN Staff ON ProductionStaff.StaffID = Staff.StaffID);";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgvProductionstafftype.DataSource = dt;

                dgvProductionstafftype.Columns[0].HeaderText = "Production ID";
                dgvProductionstafftype.Columns[1].HeaderText = "Staff ID";
                dgvProductionstafftype.Columns[2].HeaderText = "Production Type";
                dgvProductionstafftype.Columns[3].HeaderText = "Staff Name";

                dgvProductionstafftype.Columns[0].Visible = false;
                dgvProductionstafftype.Columns[1].Visible = false;

            }
            catch (SqlException exex)
            {
                MessageBox.Show(exex.Message);
            }
        }

        void fillProductionCombo()
        {
            string qry = "SELECT * FROM Production;";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds); ;

            cmbProductionID.DataSource = ds.Tables[0];
            cmbProductionID.DisplayMember = "ProductionType";
            cmbProductionID.ValueMember = "ProductionID";
        }

        void fillStaffCombo()
        {
            string qry = "SELECT * FROM Staff;";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds); ;

            cmbStaffID.DataSource = ds.Tables[0];
            cmbStaffID.DisplayMember = "StaffName";
            cmbStaffID.ValueMember = "StaffID";
        }

        private void dgvProductionstafftype_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productionID = dgvProductionstafftype.Rows[e.RowIndex].Cells[0].Value.ToString();
            staffID = dgvProductionstafftype.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        void deletePropLocation()
        {
            try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM ProductionStaff WHERE productionID = " + productionID + " AND " + "staffID = " + staffID;
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

        private void btndelete_Click(object sender, EventArgs e)
        {
            deletePropLocation();

        }

        void insertPropLocation()
        {
            try
            {


                string qry = "INSERT INTO ProductionStaff" +
                    " VALUES( '" + cmbStaffID.SelectedValue + "','" + cmbProductionID.SelectedValue + "')";

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
    }
}
