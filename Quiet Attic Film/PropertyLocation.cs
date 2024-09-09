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
    public partial class PropertyLocation : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NAAJI\\SQLEXPRESS01;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True;");
        string propertyID = "";
        string locationID = "";
        public PropertyLocation()
        {
            InitializeComponent();
        }

        private void PropertyLocation_Load(object sender, EventArgs e)
        {
            myFillGridDetail();
            fillLocationCombo();
            fillPropCombo();
        }

        void myFillGridDetail()
        {
            try
            {
                string qry = "SELECT Property.PropertyID, Location.LocationID, Property.PropertyName, Location.Location\r\nFROM ((PropertyLocation\r\nINNER JOIN Property ON Property.PropertyID = PropertyLocation.PropertyID)\r\nINNER JOIN Location ON Location.LocationID = PropertyLocation.LocationID);";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgvPropertylocation.DataSource = dt;

                dgvPropertylocation.Columns[0].HeaderText = "PropertyID";
                dgvPropertylocation.Columns[1].HeaderText = "LocationID";
                dgvPropertylocation.Columns[2].HeaderText = "PropertyName";
                dgvPropertylocation.Columns[3].HeaderText = "Location";

                dgvPropertylocation.Columns[0].Visible = false;
                dgvPropertylocation.Columns[1].Visible = false;
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

        void fillPropCombo()
        {
            string qry = "SELECT * FROM Property;";
            SqlDataAdapter da = new SqlDataAdapter(qry, con);
            DataSet ds = new DataSet();
            da.Fill(ds); ;

            cmbPropertyID.DataSource = ds.Tables[0];
            cmbPropertyID.DisplayMember = "PropertyName";
            cmbPropertyID.ValueMember = "PropertyID";
        }



        private void btnDelete_Click(object sender, EventArgs e)
        {
            deletePropLocation();
        }

        void deletePropLocation()
        {
            try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM PropertyLocation WHERE PropertyID = " + propertyID + " AND " + "LocationID = " + locationID;
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

        private void dgvProductionlocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            propertyID = dgvPropertylocation.Rows[e.RowIndex].Cells[0].Value.ToString();
            locationID = dgvPropertylocation.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertPropLocation();
        }

        void insertPropLocation()
        {
            try
            {


                string qry = "INSERT INTO PropertyLocation" + 
                    " VALUES( '" + cmbPropertyID.SelectedValue + "','" + cmbLocationID.SelectedValue + "')";

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
