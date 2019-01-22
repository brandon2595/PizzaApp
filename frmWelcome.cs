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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

            private void frmWelcome_Load(object sender, EventArgs e)
        {
            //Starts load timer as soon as app starts
            tmrLoad.Start();

            
        }

        private void tmrLoad_Tick(object sender, EventArgs e)
        {
            //Increases interval as time goes by
            tmrLoad.Interval += 1000;

            //When timer reaches 4 seconds, starts app
            if (tmrLoad.Interval == 4000)
            {
                tmrLoad.Stop();

                //Opens delivery or pickup form

                this.Hide();
                frmMain mainForm = new frmMain();
                mainForm.ShowDialog();
   

            }

        }
    }
}
