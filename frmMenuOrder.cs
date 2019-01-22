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
    public partial class frmMenuOrder : Form
    {
        public frmMenuOrder()
        {
            InitializeComponent();
        }

        public static class globals
        {
            //create and initialize variables for quantity and prices
            public static Double dblPeppPrice = 9.99,
                dblCheesePrice = 8.99,
                dblSupremePrice = 11.99,
                dblBreadPrice = 4.99,
                dblPastaPrice = 6.99,
                dblBrowniePrice = 5.99,
                dblCookiePrice = 6.99,
                dblTwoLiterPrice = 2.99,
                dbl20ozPrice = 1.49,

                //Sales tax is 7.5 percent
                decSalesTax = 0.075,

                //total variables
                decSubTotal = 0.0,
                decGrandTotal = 0.0;

            //Quantity variables
            public static int
                intPeppQuantity = 0,
                intCheeseQuantity = 0,
                intSupremeQuantity = 0,
                intBreadQuantity = 0,
                intPastaQuantity = 0,
                intBrownieQuantity = 0,
                intCookieQuantity = 0,
                intTwoLiterQuantity = 0,
                int20ozQuantity = 0;


        }

        //Method to close app on red X click
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void chkPepp_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the quantity box when checked
            txtPepQuantity.Enabled = true;
            txtPepQuantity.Focus();

            //disables textbox if not checked
            if (chkPepp.Checked == false)
            {
                txtPepQuantity.Enabled = false;
            }
        }

        private void chkCheese_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the quantity box when checked
            txtCheeseQuantity.Enabled = true;

            //disables textbox if not checked
            if (chkCheese.Checked == false)
            {
                txtCheeseQuantity.Enabled = false;
            }
        }

        private void chkSupreme_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the quantity box when checked
            txtSupremeQuantity.Enabled = true;

            //disables textbox if not checked
            if (chkSupreme.Checked == false)
            {
                txtSupremeQuantity.Enabled = false;
            }
        }

        private void chkBread_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the quantity box when checked
            txtBreadQuantity.Enabled = true;

            //disables textbox if not checked
            if (chkBread.Checked == false)
            {
                txtBreadQuantity.Enabled = false;
            }
        }

        private void chkPasta_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the quantity box when checked
            txtPastaQuantity.Enabled = true;

            //disables textbox if not checked
            if (chkPasta.Checked == false)
            {
                txtPastaQuantity.Enabled = false;
            }
        }

        private void chkBrownie_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the quantity box when checked
            txtBrownieQuantity.Enabled = true;

            //disables textbox if not checked
            if (chkBrownie.Checked == false)
            {
                txtBrownieQuantity.Enabled = false;
            }
        }

        private void chkCookie_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the quantity box when checked
            txtCookieQuantity.Enabled = true;

            //disables textbox if not checked
            if (chkCookie.Checked == false)
            {
                txtCookieQuantity.Enabled = false;
            }
        }

        private void btnPrices_Click(object sender, EventArgs e)
        {
            //Opens a new form to show pricings for all items
            frmPrices menuPrices = new frmPrices();
            menuPrices.Show();

        }

        private void chkCola20oz_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the quantity box when checked
            txt20OzQuantity.Enabled = true;

            //disables textbox if not checked
            if (chkCola20oz.Checked == false)
            {
                txt20OzQuantity.Enabled = false;
            }
        }

        private void chk2Liter_CheckedChanged(object sender, EventArgs e)
        {
            //Enables the quantity box when checked
            txtTwoLiterQuantity.Enabled = true;

            //disables textbox if not checked
            if (chk2Liter.Checked == false)
            {
                txtTwoLiterQuantity.Enabled = false;
            }
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

            //Error check: no item selected
            if (txtPepQuantity.Enabled == false)
            {
                if (txtCheeseQuantity.Enabled == false)
                {
                    if (txtSupremeQuantity.Enabled == false)
                    {
                        if (txtBreadQuantity.Enabled == false)
                        {
                            if (txtPastaQuantity.Enabled == false)
                            {
                                if (txtBrownieQuantity.Enabled == false)
                                {
                                    if (txtCookieQuantity.Enabled == false)
                                    {
                                        if (txt20OzQuantity.Enabled == false)
                                        {
                                            if (txtTwoLiterQuantity.Enabled == false)
                                            {
                                                MessageBox.Show("ERROR: Please select an item.",
                                                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error,
                                                    MessageBoxDefaultButton.Button1);
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            //parses text from quantity fields into numbers, if textbox is enabled

            /*ENTER IF STATEMENTS*****
            globals.intCheeseQuantity = int.Parse(txtCheeseQuantity.Text);
            globals.intSupremeQuantity = int.Parse(txtSupremeQuantity.Text);
            globals.intBreadQuantity = int.Parse(txtBreadQuantity.Text);
            globals.intPastaQuantity = int.Parse(txtPastaQuantity.Text);
            globals.intBrownieQuantity = int.Parse(txtBrownieQuantity.Text);
            globals.intCookieQuantity = int.Parse(txtCookieQuantity.Text);
            globals.intTwoLiterQuantity = int.Parse(txtTwoLiterQuantity.Text);
            globals.int20ozQuantity = int.Parse(txt20OzQuantity.Text);
            */

            //If textbox is enabled and quantity exists, parse, calculate and output
            if (txtPepQuantity.Enabled = true && txtPepQuantity.TextLength > 0)
            {
                //Parses quantity if it exists
                globals.intPeppQuantity = int.Parse(txtPepQuantity.Text);

                //calculate subtotal and grand total with tax
                globals.decSubTotal = globals.dblPeppPrice * globals.intPeppQuantity;
                globals.decGrandTotal = (globals.decSubTotal * globals.decSalesTax) + globals.decSubTotal;


                //Outputs total including tax and formatted in currency
                MessageBox.Show("Your total is: " + String.Format("{0:C2}", Convert.ToDecimal(globals.decGrandTotal)), "Receipt",
                    MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);

            }




        }

    }
}

