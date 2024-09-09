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
    public partial class Production_Property : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NAAJI\\SQLEXPRESS01;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True;");
        string productionID = "";
        string propID = "";
        public Production_Property()
        {
            InitializeComponent();
        }

        private void Production_Property_Load(object sender, EventArgs e)
        {
            myFillGridDetail();
            fillProductionCombo();
            fillPropCombo();
        }

        void myFillGridDetail()
        {
            try
            {
                string qry = "SELECT Production.ProductionID, Property.PropertyID, Production.ProductionType, Property.PropertyName\r\nFROM ((ProductionProperty\r\nINNER JOIN Production ON Production.ProductionID = ProductionProperty.ProductionID)\r\nINNER JOIN Property ON Property.PropertyID = ProductionProperty.PropertyID);";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgvproductionproperty.DataSource = dt;

                dgvproductionproperty.Columns[0].HeaderText = "ProductionID";
                dgvproductionproperty.Columns[1].HeaderText = "PropertyID";
                dgvproductionproperty.Columns[2].HeaderText = "ProductionType";
                dgvproductionproperty.Columns[3].HeaderText = "PropertyName";

                dgvproductionproperty.Columns[0].Visible = false;
                dgvproductionproperty.Columns[1].Visible = false;

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

        private void dgvproductionproperty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productionID = dgvproductionproperty.Rows[e.RowIndex].Cells[0].Value.ToString();
            propID = dgvproductionproperty.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        void deleteProductionLocation()
        {
            try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM ProductionProperty WHERE ProductionID = " + productionID + " AND " + "PropertyID = " + propID;
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
            deleteProductionLocation();
        }

        void insertProductionLocation()
        {
            try
            {


                string qry = "INSERT INTO ProductionProperty" +
                    " VALUES( '" + cmbPropertyID.SelectedValue + "','" + cmbProductionID.SelectedValue + "')";

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
