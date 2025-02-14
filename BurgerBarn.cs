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
        //all constants are in here
        #region constants
        float subtotal = 0; //the cost without tax
        const float tax_rate = 0.0825f; //the percentage of tax
        const float tax_fac = tax_rate + 1f; //the percentage with a 1 added to it, so multiplication can be used
        float total = 0; //the cost factoring in tax
        #endregion

        private void frmBurgerBarn_Load(object sender, EventArgs e)
        {

        }

        #region notes
        // Button btn = sender as sButton
        #endregion

        //functions
        #region functions

        private void updatePrice(RadioButton button)
        {
            if (button.Checked == true) //checks if true
            {
                if (button.Text != "None") //if it's not none, and it's checked, it will proceed to add that buttons name to the list
                {
                    lst_order.Items.Add(button.Text);
                }
                subtotal += float.Parse(button.Tag.ToString()); //adds the cost to the subtotal

            }
            else
            {
                lst_order.Items.Remove(button.Text); //removes the item from the list if it's no longer selected
                subtotal -= float.Parse(button.Tag.ToString()); //subtracts that price, which is replaced with the addition of the other one
            }

            float tax = subtotal * tax_rate; //calculate the tax
            total = subtotal + tax; //calculate the total
            lbl_subtotal.Text = "Subtotal: " + subtotal.ToString("c2"); //put the subtotal (cost of all items without tax) into the label, useing 2 decimal places
            lbl_tax.Text = "Tax: " + tax.ToString("c2"); //same as above, only for the tax
            lbl_total.Text = "Total: " + total.ToString("c2"); //same as above, only for the sum of those 2
        }

        #endregion

        #region misc notes
        //if I add in information about percent completed, remember
        //it already exists
        // it's a progress bar
        //the name is prg_totalItems
        ///it's a progress bar <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //some events that aren't used at the moment, but auto generated: 


        #endregion

        #region burgers

        //all buttons related to the burgers. Will note anything that isn't just calling a function
        private void rdb_burgers(object sender, EventArgs e)
        {

        }
        #endregion

        #region sides
        //all buttons related to the sides Will note anything that isn't just calling a function
        private void rdb_sidesFries_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice(rdb_sidesFries);
        }

        private void rdb_sideTatTot_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice(rdb_sideTatTot);
        }

        private void rdb_sideOnioRing_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice(rdb_sideOnioRing);
        }

        private void rdb_sideChip_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice(rdb_sideChip);
        }

        private void rdb_noSide_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice(rdb_noSide);
        }
        #endregion

        #region drinks
        // all buttons related to the drinks Will note anything that isn't just calling a function

        private void rdb_drinkCoala_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice(rdb_drinkCoala);
        }

        private void rdb_drinkTea_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice(rdb_drinkTea);
        }

        private void rdb_drinkPunch_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice(rdb_drinkPunch);
        }

        private void rdb_drinkWater_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice(rdb_drinkWater);
        }

        private void rdb_noDrink_CheckedChanged(object sender, EventArgs e)
        {
            updatePrice(rdb_noDrink);
        }


        //inside here are things that aren't needed yet, or possibly ever if ever, will look into how to remove
        #endregion



        #region Misc UI
        private void bttn_purchase_Click(object sender, EventArgs e) //clear input and acknowledge purchase
        {
            MessageBox.Show("Thank You for your purchase");
            rdb_noBurg.Checked = true;
            rdb_noDrink.Checked = true;
            rdb_noSide.Checked = true;
        }

        private void bttn_close_Click(object sender, EventArgs e) //exit application
        {
            Application.Exit();
        }

        #endregion
        #region background
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
        #region not yet used
        private void lst_order_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #endregion
    }
}