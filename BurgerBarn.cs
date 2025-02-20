using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BurgerBarnSummer
{

    public partial class BurgerBarn : Form
    {
        float subtotal = 0;
        float tax_rate = 0.0825f;
        float discount = 1;
        public BurgerBarn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void burgers_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton; //burgers selected

            rdbSelect(rdb); //call method
        }

        private void sides_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton; //sides selected

            rdbSelect(rdb); //call method
        }

        private void drinks_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton; //drinks selected

            rdbSelect(rdb); //call method
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            if(lstOrder.Items.Count == 0)
            {
                MessageBox.Show("You must have an item in your order to purchase."); //Show message
            }
            else
            {
                string message = "";

                foreach(var item in lstOrder.Items)
                {
                    message += item.ToString() + "\n";
                }

                message += "---------------------------\n";

                message += string.Format("Subtotal: \t{0:C}\n", lblSubtotal.Text); //displays subtotal
                message += string.Format("Tax:      \t\t{0:C}\n", lblTax.Text); //displays Tax
                message += string.Format("Total:    \t\t{0:C}\n", lblTotal.Text); //displays total
                
                MessageBox.Show(message);

                rdbNoBurger.Checked = true; //selects no burger
                rdbNoDrink.Checked = true; //selects no drink
                rdbNoSide.Checked = true; //selects no side
                rdbNoSandwich.Checked = true; //selects no sandwich

                btnApplyCoupon.Enabled = true; //reset Coupon
                discount = 1; //reset discount
            }
        }
        private void CalcTotal()
        {
            //calculate subtotal
            float tax = (subtotal * discount) * tax_rate;
            float total = (subtotal * discount) + tax;

            //display subtotal 
            lblSubtotal.Text = (subtotal * discount).ToString("c2");
            lblTax.Text = tax.ToString("c2");
            lblTotal.Text = total.ToString("c2");
        }


        private void rdbSelect(RadioButton rdb)
        {
            if (rdb.Checked)  //if selected 
            {
                if (rdb.Text != "None")
                    lstOrder.Items.Add(rdb.Text);      //add plain burger to receipt

                subtotal += float.Parse(rdb.Tag.ToString());   //update subtotal
            }
            else //if plain burger is deselected
            {
                lstOrder.Items.Remove(rdb.Text); //remove plain burger from receipt

                subtotal -= float.Parse(rdb.Tag.ToString()); //update subtotal 
            }
           CalcTotal(); //Call method
        }

        private void sandwiches_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton; //Sandwich selected

            rdbSelect(rdb); //call method
        }

        private void btnApplyCoupon_Click(object sender, EventArgs e)
        {
            btnApplyCoupon.Enabled = false; //Apply Coupon
            discount = .8f; //20% discount
            CalcTotal(); //call method
        }
    }
}
