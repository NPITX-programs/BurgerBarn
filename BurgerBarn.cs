using System;
using System.Windows.Forms;

namespace BurgerBarn
{
    public partial class frmBurgerBarn : Form
    {
        float subtotal = 0;
        const float tax_rate = 0.0825f;
        const float tax_fac = tax_rate + 1f;
        float total = 0;

        public frmBurgerBarn()
        {
            InitializeComponent();
        }
        //shared variables
        //put shared variables here
        //functions
            //put functions here
        private void frmBurgerBarn_Load(object sender, EventArgs e)
        {

        }
        //functions
        #region functions
        private string getCost(Control inputBox, float price)
        {
            string initial = inputBox.Text.ToString();
            
        }
        #endregion

        #region grop boxes
        // group boxes


        //burgers
        private void gbxBurgers_Enter(object sender, EventArgs e)
        {
            
        }

        //sides
        private void gbxSides_Enter(object sender, EventArgs e)
        {

        }

        //drinks
        private void gbxDrinks_Enter(object sender, EventArgs e)
        {

        }
        #endregion


        #region misc
        //if I add in information about percent completed, remember
        //it already exists
        //the name is prg_totalItems
        ///it's a progress bar

        #endregion


        #region burgers

        //all buttons related to the burgers. Remember to modify such that it utilizes my buttons
            //do note that the labels could be done via 2 labels, with the value set up with the property that tells it to turn decimals into price
        private void rdb_plainBurg_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_plainBurg.Checked == true)
            {
                lst_order.Items.Add(rdb_plainBurg.Text);
                subtotal += float.Parse(rdb_plainBurg.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_plainBurg.Text);
                subtotal -= float.Parse(rdb_plainBurg.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;
            //the modified one that is for displaying curency. it's "c2". C means currency, 2 means "2 places" (so, c2 is $0.00, c is the same. c4 is $0.0000
            lbl_subtotal.Text = subtotal.ToString(); //lbl_subtotal.Text = subtotal.ToString("c2");
            lbl_tax.Text = tax.ToString(); //lbl_tax.Text = tax.ToString("c2");
            lbl_total.Text = total.ToString(); //lbl_total.Text = total.ToString("c2");

        }

        private void rdb_cheeBurg_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_cheeBurg.Checked == true)
            {
                lst_order.Items.Add(rdb_cheeBurg.Text);
                subtotal += float.Parse(rdb_cheeBurg.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_cheeBurg.Text);
                subtotal -= float.Parse(rdb_cheeBurg.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;
            
            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString(); 
            lbl_total.Text = total.ToString();


        }

        private void rdb_vegBurg_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_vegBurg.Checked == true)
            {
                lst_order.Items.Add(rdb_vegBurg.Text);
                subtotal += float.Parse(rdb_vegBurg.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_vegBurg.Text);
                subtotal -= float.Parse(rdb_vegBurg.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString();
            lbl_total.Text = total.ToString();
        }

        private void rdb_baconBurg_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_baconBurg.Checked == true)
            {
                lst_order.Items.Add(rdb_baconBurg.Text);
                subtotal += float.Parse(rdb_baconBurg.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_baconBurg.Text);
                subtotal -= float.Parse(rdb_baconBurg.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString();
            lbl_total.Text = total.ToString();
        }

        private void rdb_noBurg_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_noBurg.Checked == true)
            {
                lst_order.Items.Add(rdb_noBurg.Text);
                subtotal += float.Parse(rdb_noBurg.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_noBurg.Text);
                subtotal -= float.Parse(rdb_noBurg.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString();
            lbl_total.Text = total.ToString();
        }
        #endregion

        #region sides
        //all buttons related to the sides
        private void rdb_sidesFries_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_sidesFries.Checked == true)
            {
                lst_order.Items.Add(rdb_sidesFries.Text);
                subtotal += float.Parse(rdb_sidesFries.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_sidesFries.Text);
                subtotal -= float.Parse(rdb_sidesFries.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString();
            lbl_total.Text = total.ToString();
        }

        private void rdb_sideTatTot_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_sideTatTot.Checked == true)
            {
                lst_order.Items.Add(rdb_sideTatTot.Text);
                subtotal += float.Parse(rdb_sideTatTot.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_sideTatTot.Text);
                subtotal -= float.Parse(rdb_sideTatTot.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString();
            lbl_total.Text = total.ToString();
        }

        private void rdb_sideOnioRing_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_sideOnioRing.Checked == true)
            {
                lst_order.Items.Add(rdb_sideOnioRing.Text);
                subtotal += float.Parse(rdb_sideOnioRing.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_sideOnioRing.Text);
                subtotal -= float.Parse(rdb_sideOnioRing.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString();
            lbl_total.Text = total.ToString();
        }

        private void rdb_sideChip_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_sideChip.Checked == true)
            {
                lst_order.Items.Add(rdb_sideChip.Text);
                subtotal += float.Parse(rdb_sideChip.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_sideChip.Text);
                subtotal -= float.Parse(rdb_sideChip.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString();
            lbl_total.Text = total.ToString();
        }

        private void rdb_noSide_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_noSide.Checked == true)
            {
                lst_order.Items.Add(rdb_noSide.Text);
                subtotal += float.Parse(rdb_noSide.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_noSide.Text);
                subtotal -= float.Parse(rdb_noSide.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString();
            lbl_total.Text = total.ToString();
        }
        #endregion

        #region drinks
        // all buttons related to the drinks

        private void rdb_drinkCoala_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_drinkCoala.Checked == true)
            {
                lst_order.Items.Add(rdb_drinkCoala.Text);
                subtotal += float.Parse(rdb_drinkCoala.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_drinkCoala.Text);
                subtotal -= float.Parse(rdb_drinkCoala.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString();
            lbl_total.Text = total.ToString();
        }

        private void rdb_drinkTea_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_drinkTea.Checked == true)
            {
                lst_order.Items.Add(rdb_drinkTea.Text);
                subtotal += float.Parse(rdb_drinkTea.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_drinkTea.Text);
                subtotal -= float.Parse(rdb_drinkTea.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString();
            lbl_total.Text = total.ToString();
        }

        private void rdb_drinkPunch_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_drinkPunch.Checked == true)
            {
                lst_order.Items.Add(rdb_drinkPunch.Text);
                subtotal += float.Parse(rdb_drinkPunch.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_drinkPunch.Text);
                subtotal -= float.Parse(rdb_drinkPunch.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString();
            lbl_total.Text = total.ToString();
        }

        private void rdb_drinkWater_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_drinkWater.Checked == true)
            {
                lst_order.Items.Add(rdb_drinkWater.Text);
                subtotal += float.Parse(rdb_drinkWater.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_drinkWater.Text);
                subtotal -= float.Parse(rdb_drinkWater.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString();
            lbl_total.Text = total.ToString();
        }

        private void rdb_noDrink_CheckedChanged(object sender, EventArgs e)
        {
            if (rdb_noDrink.Checked == true)
            {
                lst_order.Items.Add(rdb_noDrink.Text);
                subtotal += float.Parse(rdb_noDrink.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(rdb_noDrink.Text);
                subtotal -= float.Parse(rdb_noDrink.Tag.ToString());
            }

            float tax = subtotal * tax_rate;
            float total = subtotal + tax;

            lbl_subtotal.Text = subtotal.ToString();
            lbl_tax.Text = tax.ToString();
            lbl_total.Text = total.ToString();
        }


        //inside here are things that aren't needed yet, or possibly ever if ever, will look into how to remove
        #endregion

        private void lst_order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        #region costs
        private void lbl_subtotal_Click(object sender, EventArgs e)
        {

        }

        private void lbl_tax_Click(object sender, EventArgs e)
        {

        }

        private void lbl_total_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
