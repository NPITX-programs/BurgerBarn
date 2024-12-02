using System;
using System.Windows.Forms;

namespace BurgerBarn
{
    public partial class frmBurgerBarn : Form
    {


        public frmBurgerBarn()
        {
            InitializeComponent();
        }
        //constants
        float subtotal = 0;
        const float tax_rate = 0.0825f;
        const float tax_fac = tax_rate + 1f;
        float total = 0; 

        private void frmBurgerBarn_Load(object sender, EventArgs e)
        {

        }

        //functions
        #region functions
        private void getCost() //takes the global variables, as set previously (this runs after that part), and edits the labels to match
        {
            float tax = subtotal * tax_rate; //calculate the tax
            total = subtotal + tax; //calculate the total
            lbl_subtotal.Text = "Subtotal: " + subtotal.ToString("c2"); //put the subtotal (cost of all items without tax) into the label, useing 2 decimal places
            lbl_tax.Text = "Tax: " + tax.ToString("c2"); //same as above, only for the tax
            lbl_total.Text = "Total: " + total.ToString("c2"); //same as above, only for the sum of those 2
        }

        private void findPrice(RadioButton button)
        {
            if (button.Checked == true)
            {
                lst_order.Items.Add(button.Text);
                subtotal += float.Parse(button.Tag.ToString());

            }
            else
            {
                lst_order.Items.Remove(button.Text);
                subtotal -= float.Parse(button.Tag.ToString());
            }
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
            findPrice(rdb_plainBurg);
            getCost();
        }

        private void rdb_cheeBurg_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_cheeBurg);
            getCost();
        }

        private void rdb_vegBurg_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_vegBurg);
            getCost();
        }

        private void rdb_baconBurg_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_baconBurg);
            getCost();
        }

        private void rdb_noBurg_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_noBurg);
            getCost();
        }
        #endregion

        #region sides
        //all buttons related to the sides
        private void rdb_sidesFries_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_sidesFries);
            getCost();
        }

        private void rdb_sideTatTot_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_sideTatTot);
            getCost();
        }

        private void rdb_sideOnioRing_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_sideOnioRing);
            getCost();
        }

        private void rdb_sideChip_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_sideChip);
            getCost();
        }

        private void rdb_noSide_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_noSide);
            getCost();
        }
        #endregion

        #region drinks
        // all buttons related to the drinks

        private void rdb_drinkCoala_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_drinkCoala);
            getCost();
        }

        private void rdb_drinkTea_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_drinkTea);
            getCost();
        }

        private void rdb_drinkPunch_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_drinkPunch);
            getCost();
        }

        private void rdb_drinkWater_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_drinkWater);
            getCost();
        }

        private void rdb_noDrink_CheckedChanged(object sender, EventArgs e)
        {
            findPrice(rdb_noDrink);
            getCost();
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

        private void bttn_purchase_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank You for your purchase");
            rdb_noBurg.Checked = true;
            rdb_noDrink.Checked = true;
            rdb_noSide.Checked = true;
        }

        private void bttn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
