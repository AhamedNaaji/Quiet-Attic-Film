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
    public partial class ProductionLocation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NAAJI\\SQLEXPRESS01;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True;");
        String productionID;
        String locationID;
        public ProductionLocation()
        {
            InitializeComponent();
        }

        private void ProductionLocation_Load(object sender, EventArgs e)
        {
            myFillGridDetail();
            fillLocationCombo();
            fillProductionCombo();
        }

        void myFillGridDetail()
        {
            try
            {
                string qry = "SELECT Production.ProductionID, Location.LocationID, Production.ProductionType, Location.Location\r\nFROM ((ProductionLocation\r\nINNER JOIN Production ON ProductionLocation.ProductionID = Production.ProductionID)\r\nINNER JOIN Location ON ProductionLocation.LocationID = Location.LocationID);";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgvproductionlocation.DataSource = dt;

                dgvproductionlocation.Columns[0].HeaderText = "ProductionID";
                dgvproductionlocation.Columns[1].HeaderText = "LocationID";
                dgvproductionlocation.Columns[2].HeaderText = "Production Type";
                dgvproductionlocation.Columns[3].HeaderText = "Location";

                dgvproductionlocation.Columns[0].Visible = false;
                dgvproductionlocation.Columns[1].Visible = false;

            }
            catch (SqlException exex)
            {
                MessageBox.Show(exex.Message);
            }
        }

        void fillLocationCombo()
        {
            string qry = "SELECT * FROM Location;";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds); ;

            cmbLocationID.DataSource = ds.Tables[0];
            cmbLocationID.DisplayMember = "Location";
            cmbLocationID.ValueMember = "LocationID";
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

        private void dgvproductionlocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productionID = dgvproductionlocation.Rows[e.RowIndex].Cells[0].Value.ToString();
            locationID = dgvproductionlocation.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        void deletePropLocation()
        {
            try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM ProductionLocation WHERE productionID = " + productionID + " AND " + "locationID = " + locationID;
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
            deletePropLocation();
        }

        void insertProductionLocation()
        {
            try
            {


                string qry = "INSERT INTO ProductionLocation" +
                    " VALUES( '" + cmbLocationID.SelectedValue + "','" + cmbProductionID.SelectedValue + "')";

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
            insertProductionLocation();
        }
    }
}
