﻿using System;
using System.Windows.Forms;

namespace BurgerBarnSummer
{

    public partial class BurgerBarn : Form
    {
        float subtotal = 0;
        float tax_rate = 0.0825f;
        float discount = 1;
        const string noCouponText = "No Coupon";
        public BurgerBarn()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

#region select
        private void selectOrder(object sender, EventArgs e)
        {
            RadioButton rdb = sender as RadioButton; //burgers selected
            rdbSelect(rdb); //call method
        }
#endregion
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
                rdbNoSandwich.Checked = true; //selects no sandwich

                discount = 1; //reset discount
                cmb_coupon.SelectedIndex = 0;
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

            if (discount < 0) {
                lblSubtotal.Text = "-" + lblSubtotal.Text;
                lblTax.Text = "-" + lblTax.Text;
                lblTotal.Text = "-" + lblTotal.Text;
            }
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

        private void cmb_coupon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmb_coupon.Text == noCouponText)
            {
                discount = 1;
            } else
            {
                string discString = cmb_coupon.Text;
                discString = discString.Substring(0, discString.Length - 1);
                float discVal = float.Parse(discString);
                discVal = discVal / 100;
                discVal = 1 - discVal;
                discount = discVal;
            }
            CalcTotal();
        }

        private void BurgerBarn_Load(object sender, EventArgs e)
        {
            cmb_coupon.Items.Insert(0, noCouponText); //add the text for no coupon
            cmb_coupon.SelectedIndex = 0; //reset coupon
        }
    }
}
