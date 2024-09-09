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
    public partial class Dashboard : Form
    {
        //SqlConnection con = new SqlConnection("Data Source=NAAJI\\SQLEXPRESS01;Initial Catalog=Quiet_Attic_Film_Production;Integrated Security=True;Trust Server Certificate=True");
//        string id = "";
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btnstaff_Click(object sender, EventArgs e)
        {
            Staff staffForm = new Staff();
            staffForm.ShowDialog();
            
        }

        private void btnproduction_Click(object sender, EventArgs e)
        {
            Production productionForm = new Production();
            productionForm.ShowDialog();
            
        }

        private void btnclient_Click(object sender, EventArgs e)
        {
            Clients clientForm = new Clients();
            clientForm.ShowDialog();
            
        }

        private void btnproperty_Click(object sender, EventArgs e)
        {
            Property PropertyForm = new Property();
            PropertyForm.ShowDialog();
            
        }

        private void btnlocation_Click(object sender, EventArgs e)
        {
            Locations LocationForm = new Locations();
            LocationForm.ShowDialog();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void BtnProductionLocation_Click(object sender, EventArgs e)
        {
            ProductionLocation ProductionLocationForm = new ProductionLocation();
            ProductionLocationForm.ShowDialog();
            
        }

        private void BtnPropertyLocation_Click(object sender, EventArgs e)
        {
            PropertyLocation PropertyLocationForm = new PropertyLocation();
            PropertyLocationForm.ShowDialog();
           
        }

        private void BtnProductionProperty_Click(object sender, EventArgs e)
        {
            Production_Property ProductionPropertyForm = new Production_Property();
            ProductionPropertyForm.ShowDialog();
            
        }

        private void BtnProductionStaff_Click(object sender, EventArgs e)
        {
            Production_Staff ProductionStaffForm = new Production_Staff();
            ProductionStaffForm.ShowDialog();
            
        }

        private void BtnStaffType_Click(object sender, EventArgs e)
        {
            Staff_Type StaffTypeForm = new Staff_Type();
            StaffTypeForm.ShowDialog();
          
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
