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
    public partial class Property : Form
    {
        SqlConnection con = new SqlConnection("Data Source=NAAJI\\SQLEXPRESS01;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True;");
        string id = "";
        public Property()
        {
            InitializeComponent();
        }

        private void Property_Load(object sender, EventArgs e)
        {
            myFillGridDetail();
        }

        void myFillGridDetail()
        {
            try
            {
                string qry = "SELECT * FROM Property";
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                da.Fill(dt);
                dgvproperty.DataSource = dt;

                dgvproperty.Columns[0].HeaderText = "Property ID";
                dgvproperty.Columns[1].HeaderText = "Property Type";
                dgvproperty.Columns[2].HeaderText = "Property Name";

            }
            catch (SqlException exex)
            {
                MessageBox.Show(exex.Message);
            }
        }

        void insertProperty()
        {
            try
            {
                string propertyType = cmbpropertytype.Text;
                string propertyName = txtpropertyName.Text.Trim();
                int maxpropertyNameLength = 10;
                if (propertyName.Length > maxpropertyNameLength)
                {
                    MessageBox.Show("Error: Property Name exceeds the maximum allowed length for the 'Name' column.The Statement Has Been Terminated");
                    return;
                }
                string qry = "INSERT INTO Property" +
                        "(PropertyType, PropertyName)" +
                        " VALUES( '" + propertyType + "','" + propertyName + "')";
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

        void updateProperty()
        {
            try
            {


                if (MessageBox.Show("Do you want to update", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "UPDATE Property SET " +

                        "PropertyType = '" + cmbpropertytype.Text + "PropertyName = '" + txtpropertyName.Text.Trim() + "WHERE LocationID = " + id;
                    ;


                    con.Open();
                    SqlCommand cmd = new SqlCommand(qry, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Updated Successfully", "Update Operation");
                    btnSave.PerformClick();
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

        void deleteProprety()
        {
            try
            {


                if (MessageBox.Show("Do you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string qry = "DELETE FROM Property WHERE PropertyID = " + id;
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            insertProperty();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            deleteProprety();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateProperty();
        }

        private void dgvproperty_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = dgvproperty.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void txtpropertyName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
