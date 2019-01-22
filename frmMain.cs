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

    
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

            public static class globalVariables
        {
            //Create and initialize global variables
            public static Boolean bolDelivery = false;
            public static Boolean bolPickup = false;
            public static frmMenuOrder frmMenu = new frmMenuOrder();
            public static frmDeliveryInfo frmDelivery = new frmDeliveryInfo();
        }

        private void btnPickup_Click(object sender, EventArgs e)
        {
            //set bolPickup to true
            globalVariables.bolPickup = true;

            //If pickup is selected, advance to menu
            this.Hide();

            globalVariables.frmMenu.Show();
        }

        private void btnDelivery_Click(object sender, EventArgs e)
        {
            //set bolPickup to true
            globalVariables.bolDelivery = true;
            DialogResult dlgResult = new DialogResult();

            //Ask user for delivery information input
            //Enter delivery screen


            //Confirmation on delivery charge
            dlgResult =  MessageBox.Show("The delivery charge will be $2.25. Is this ok?","Are you sure", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            if (dlgResult == DialogResult.Yes)
            {
                //Open delivery info screen
                this.Hide();
                globalVariables.frmDelivery.Show();
            }
            
        }
    }
}
