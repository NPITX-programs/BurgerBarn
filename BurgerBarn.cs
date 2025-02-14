using System;
using System.Dynamic;
using System.Runtime.InteropServices;
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

        //functions
        #region functions
        private void updatePrice(object input) //this will take in any object, convert it to a radio button, then modify the price acordingly
        {
            RadioButton button = input as RadioButton;
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

        //code for the radio buttons
        #region buttons
        private void rdb_burgers(object sender, EventArgs e) //this will call the function to update the price whenever the selected burger changes
        {
            updatePrice(sender);
        }
        private void rdb_sides(object sender, EventArgs e) //this will call the function to update the price whenever the selected side changes
        {
            updatePrice(sender);
        }
        private void rdb_drinks(object sender, EventArgs e) //this will call the function to update the price whenever the selected drink changes
        {
            updatePrice(sender);
        }
        #endregion

        //miscilaneus code for the UI
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
        
        // notes and such
        #region notes
        //if I add in information about percent completed, remember
        //it already exists
        // it's a progress bar
        //the name is prg_totalItems
        ///it's a progress bar <summary>
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //when useing an object, but needing a button, do "Button btn = sender as Button"
        //modify as needed for other object types
        #endregion
    }
}