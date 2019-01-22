using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_pizza_ordering
{
    public partial class frmDeliveryInfo : Form
    {
        public frmDeliveryInfo()
        {
            InitializeComponent();
            
        }
        

            private void BtnProceed_Click(object sender, EventArgs e)
        {
            //Check for empty fields
            if (txtAddress.Text == string.Empty || txtCity.Text == string.Empty || 
                txtState.Text == string.Empty || txtZip.Text == string.Empty)
            {
                MessageBox.Show("Error: Cannot proceed. All fields must be filled.", "ERROR");
            }

            //Check for invalid entry
            

        }

       
    }
}
