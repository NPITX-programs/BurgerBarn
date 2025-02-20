using System;
using System.Windows.Forms;

namespace BurgerBarn
{
    public partial class BurgerBarn : Form
    {
        float subtotal = 0;
        const float tax_rate = 0.0825f;
        float discount = 0;
        const float discValue = 20f;

        public BurgerBarn()
        {
            InitializeComponent();
        }

        private void rdb_selectItem(object sender, EventArgs e)
        {
            rdbSelect(sender); //directly send the sender to the function
        }

        //function for ordering
        private void rdbSelect(object bttn)
        {
            RadioButton rdb = bttn as RadioButton; //takes the inputed object (sender), and converts it to a radio button
            if (rdb.Checked) //rdb selected
            {
                if(rdb.Text != "None") // If none is ever selected it doesn't add to receipt
                    lstOrder.Items.Add(rdb.Text); //Adds items to receipt
                subtotal += float.Parse(rdb.Tag.ToString()); //adds price to receipt
            }
            else
            {
                lstOrder.Items.Remove(rdb.Text); //removes Items from order
                subtotal -= float.Parse(rdb.Tag.ToString()); // removes price from receipt
            }
            //calculate totals
            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            //display totals
            lblSubtoal.Text = subtotal.ToString("c2");
            lblTax.Text = tax.ToString("c2");
            lblTotal.Text = total.ToString("c2");
        }

        #region UI
        private void btnExit_Click(object sender, EventArgs e) //exit program
        {
            Application.Exit();
        }
        private void btnPurchase_Click(object sender, EventArgs e) //purchase
        {
            MessageBox.Show("Thank you for your purchase!");
            rdbNoBurger.Checked = true;
            rdbNoDrink.Checked = true;
            rdbNoSide.Checked = true;
            rdbNoSand.Checked = true;
        }
        #endregion UI

        private void bttnCoupon_Click(object sender, EventArgs e)
        {

        }
    }
}
