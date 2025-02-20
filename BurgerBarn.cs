using System;
using System.Windows.Forms;

namespace BurgerBarn
{
    public partial class BurgerBarn : Form
    {
        float subtotal = 0;
        const float tax_rate = 0.0825f;
        float discount = 1; //no discount, aka 100% (a.k.a. 1 times) the normal price
        const float discValue = 20f; //the discount, as a percent. The code subtracts it from 100, then divides by 100. So, putting in 20 is the same as 20% off, which becomes .8 (what that means
        

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
            //calculate totalss
            float tax = subtotal * tax_rate;
            subtotal = subtotal * discount; //applies the discount. By doing it after the tax, tax is based on the original subtotal. By doing it before total, the total factors in the discount, meaning it's the discounted subtotal + the non-discounted tax. if you want the discount to include tax, just move this one line up
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
            bttnCoupon.Enabled = true; //re-enable the coupon once it's applied
        }
        #endregion UI

        private void bttnCoupon_Click(object sender, EventArgs e)
        {
            bttnCoupon.Enabled = false; //disable the coupon button once applied
            discount = (100 - discValue) / 100; //sets the discount to be be the reciprical of the discount value as a percent, so that the value to pay can be calculated by multiplication. So, a 20% discount (an input of 20) is the same as 80% of the original price. The 100-"x" turns 20 to 80. Then, divide by 100, and you get 0.8, or 80 percent.
        }
    }
}
