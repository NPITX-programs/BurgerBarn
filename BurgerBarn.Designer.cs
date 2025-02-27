namespace BurgerBarn
{
    partial class BurgerBarn
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rdbPlainBurger = new System.Windows.Forms.RadioButton();
            this.rdbCheeseburger = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbNoBurger = new System.Windows.Forms.RadioButton();
            this.rdbBaconBurger = new System.Windows.Forms.RadioButton();
            this.rdbVeggieBurger = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbNoDrink = new System.Windows.Forms.RadioButton();
            this.rdbWater = new System.Windows.Forms.RadioButton();
            this.rdbFruitPunch = new System.Windows.Forms.RadioButton();
            this.rdbCola = new System.Windows.Forms.RadioButton();
            this.rdbTea = new System.Windows.Forms.RadioButton();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbNoSandwich = new System.Windows.Forms.RadioButton();
            this.rdbBLT = new System.Windows.Forms.RadioButton();
            this.rdbItalianSub = new System.Windows.Forms.RadioButton();
            this.rdbChickenSandwich = new System.Windows.Forms.RadioButton();
            this.rdbTurkeyClub = new System.Windows.Forms.RadioButton();
            this.cmb_coupon = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbPlainBurger
            // 
            this.rdbPlainBurger.AutoSize = true;
            this.rdbPlainBurger.Location = new System.Drawing.Point(49, 52);
            this.rdbPlainBurger.Margin = new System.Windows.Forms.Padding(7);
            this.rdbPlainBurger.Name = "rdbPlainBurger";
            this.rdbPlainBurger.Size = new System.Drawing.Size(164, 33);
            this.rdbPlainBurger.TabIndex = 1;
            this.rdbPlainBurger.Tag = "4.99";
            this.rdbPlainBurger.Text = "Plain Burger";
            this.rdbPlainBurger.UseVisualStyleBackColor = true;
            this.rdbPlainBurger.CheckedChanged += new System.EventHandler(this.selectOrder);
            // 
            // rdbCheeseburger
            // 
            this.rdbCheeseburger.AutoSize = true;
            this.rdbCheeseburger.Location = new System.Drawing.Point(49, 99);
            this.rdbCheeseburger.Margin = new System.Windows.Forms.Padding(7);
            this.rdbCheeseburger.Name = "rdbCheeseburger";
            this.rdbCheeseburger.Size = new System.Drawing.Size(186, 33);
            this.rdbCheeseburger.TabIndex = 2;
            this.rdbCheeseburger.TabStop = true;
            this.rdbCheeseburger.Tag = "5.99";
            this.rdbCheeseburger.Text = "Cheeseburger";
            this.rdbCheeseburger.UseVisualStyleBackColor = true;
            this.rdbCheeseburger.CheckedChanged += new System.EventHandler(this.selectOrder);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbNoBurger);
            this.groupBox1.Controls.Add(this.rdbBaconBurger);
            this.groupBox1.Controls.Add(this.rdbVeggieBurger);
            this.groupBox1.Controls.Add(this.rdbPlainBurger);
            this.groupBox1.Controls.Add(this.rdbCheeseburger);
            this.groupBox1.Location = new System.Drawing.Point(41, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(277, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Burgers";
            this.rdbCheeseburger.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCheeseburger.Location = new System.Drawing.Point(14, 48);
            this.rdbCheeseburger.Name = "rdbCheeseburger";
            this.rdbCheeseburger.Size = new System.Drawing.Size(161, 23);
            this.rdbCheeseburger.TabIndex = 0;
            this.rdbCheeseburger.TabStop = true;
            this.rdbCheeseburger.Tag = "5.99";
            this.rdbCheeseburger.Text = "Cheeseburger ($5.99)";
            this.rdbCheeseburger.UseVisualStyleBackColor = true;
            this.rdbCheeseburger.CheckedChanged += new System.EventHandler(this.rdb_selectItem);
            // 
            // rdbVeggieBurger
            // 
            this.rdbVeggieBurger.AutoSize = true;
            this.rdbVeggieBurger.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbVeggieBurger.Location = new System.Drawing.Point(14, 77);
            this.rdbVeggieBurger.Name = "rdbVeggieBurger";
            this.rdbVeggieBurger.Size = new System.Drawing.Size(162, 23);
            this.rdbVeggieBurger.TabIndex = 0;
            this.rdbVeggieBurger.TabStop = true;
            this.rdbVeggieBurger.Tag = "6.49";
            this.rdbVeggieBurger.Text = "Veggie Burger ($6.49)";
            this.rdbVeggieBurger.UseVisualStyleBackColor = true;
            this.rdbVeggieBurger.CheckedChanged += new System.EventHandler(this.rdb_selectItem);
            // 
            // rdbBaconBurger
            // 
            this.rdbBaconBurger.AutoSize = true;
            this.rdbBaconBurger.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBaconBurger.Location = new System.Drawing.Point(14, 106);
            this.rdbBaconBurger.Name = "rdbBaconBurger";
            this.rdbBaconBurger.Size = new System.Drawing.Size(161, 23);
            this.rdbBaconBurger.TabIndex = 0;
            this.rdbBaconBurger.TabStop = true;
            this.rdbBaconBurger.Tag = "7.99";
            this.rdbBaconBurger.Text = "Bacon Burger ($7.99)";
            this.rdbBaconBurger.UseVisualStyleBackColor = true;
            this.rdbBaconBurger.CheckedChanged += new System.EventHandler(this.rdb_selectItem);
            this.btnExit.Location = new System.Drawing.Point(994, 562);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(125, 40);
            this.btnExit.TabIndex = 10;
            this.btnExit.TabStop = false;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(643, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 31);
            this.btnExit.TabIndex = 10;

            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbNoSandwich);
            this.groupBox4.Controls.Add(this.rdbBLT);
            this.groupBox4.Controls.Add(this.rdbItalianSub);
            this.groupBox4.Controls.Add(this.rdbChickenSandwich);
            this.groupBox4.Controls.Add(this.rdbTurkeyClub);
            this.groupBox4.Location = new System.Drawing.Point(340, 37);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(277, 291);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sandwiches";
            // 
            // rdbNoSandwich
            // 
            this.rdbNoSandwich.AutoSize = true;
            this.rdbNoSandwich.Checked = true;
            this.rdbNoSandwich.Location = new System.Drawing.Point(49, 240);
            this.rdbNoSandwich.Margin = new System.Windows.Forms.Padding(7);
            this.rdbNoSandwich.Name = "rdbNoSandwich";
            this.rdbNoSandwich.Size = new System.Drawing.Size(90, 33);
            this.rdbNoSandwich.TabIndex = 10;
            this.rdbNoSandwich.TabStop = true;
            this.rdbNoSandwich.Tag = "0";
            this.rdbNoSandwich.Text = "None";
            this.rdbNoSandwich.UseVisualStyleBackColor = true;
            this.rdbNoSandwich.CheckedChanged += new System.EventHandler(this.selectOrder);
            // 
            // rdbBLT
            // 
            this.rdbBLT.AutoSize = true;
            this.rdbBLT.Location = new System.Drawing.Point(49, 193);
            this.rdbBLT.Margin = new System.Windows.Forms.Padding(7);
            this.rdbBLT.Name = "rdbBLT";
            this.rdbBLT.Size = new System.Drawing.Size(76, 33);
            this.rdbBLT.TabIndex = 9;
            this.rdbBLT.TabStop = true;
            this.rdbBLT.Tag = "3.49";
            this.rdbBLT.Text = "BLT";
            this.rdbBLT.UseVisualStyleBackColor = true;
            this.rdbBLT.CheckedChanged += new System.EventHandler(this.selectOrder);
            // 
            // rdbItalianSub
            // 
            this.rdbItalianSub.AutoSize = true;
            this.rdbItalianSub.Location = new System.Drawing.Point(49, 146);
            this.rdbItalianSub.Margin = new System.Windows.Forms.Padding(7);
            this.rdbItalianSub.Name = "rdbItalianSub";
            this.rdbItalianSub.Size = new System.Drawing.Size(143, 33);
            this.rdbItalianSub.TabIndex = 8;
            this.rdbItalianSub.TabStop = true;
            this.rdbItalianSub.Tag = "7.49";
            this.rdbItalianSub.Text = "Italian Sub";
            this.rdbItalianSub.UseVisualStyleBackColor = true;
            this.rdbItalianSub.CheckedChanged += new System.EventHandler(this.selectOrder);
            // 
            // rdbChickenSandwich
            // 
            this.rdbChickenSandwich.AutoSize = true;
            this.rdbChickenSandwich.Location = new System.Drawing.Point(49, 52);
            this.rdbChickenSandwich.Margin = new System.Windows.Forms.Padding(7);
            this.rdbChickenSandwich.Name = "rdbChickenSandwich";
            this.rdbChickenSandwich.Size = new System.Drawing.Size(229, 33);
            this.rdbChickenSandwich.TabIndex = 6;
            this.rdbChickenSandwich.TabStop = true;
            this.rdbChickenSandwich.Tag = "3.99";
            this.rdbChickenSandwich.Text = "Chicken Sandwich";
            this.rdbChickenSandwich.UseVisualStyleBackColor = true;
            this.rdbChickenSandwich.CheckedChanged += new System.EventHandler(this.selectOrder);
            // 
            // rdbTurkeyClub
            // 
            this.rdbTurkeyClub.AutoSize = true;
            this.rdbTurkeyClub.Location = new System.Drawing.Point(49, 99);
            this.rdbTurkeyClub.Margin = new System.Windows.Forms.Padding(7);
            this.rdbTurkeyClub.Name = "rdbTurkeyClub";
            this.rdbTurkeyClub.Size = new System.Drawing.Size(161, 33);
            this.rdbTurkeyClub.TabIndex = 7;
            this.rdbTurkeyClub.TabStop = true;
            this.rdbTurkeyClub.Tag = "5.49";
            this.rdbTurkeyClub.Text = "Turkey Club";
            this.rdbTurkeyClub.UseVisualStyleBackColor = true;
            this.rdbTurkeyClub.CheckedChanged += new System.EventHandler(this.selectOrder);
            // 
            // cmb_coupon
            // 
            this.cmb_coupon.FormattingEnabled = true;
            this.cmb_coupon.Items.AddRange(new object[] {
            "10%",
            "25%",
            "40%",
            "50%",
            "100%",
            "110%",
            "200%"});
            this.cmb_coupon.Location = new System.Drawing.Point(573, 562);
            this.cmb_coupon.Name = "cmb_coupon";
            this.cmb_coupon.Size = new System.Drawing.Size(233, 37);
            this.cmb_coupon.TabIndex = 17;
            this.cmb_coupon.SelectedIndexChanged += new System.EventHandler(this.cmb_coupon_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 514);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 29);
            this.label4.TabIndex = 15;
            this.label4.Text = "Coupon";
            // 
            // BurgerBarn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 663);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmb_coupon);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.lblSubtotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "BurgerBarn";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.BurgerBarn_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbPlainBurger;
        private System.Windows.Forms.RadioButton rdbCheeseburger;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbNoBurger;
        private System.Windows.Forms.RadioButton rdbBaconBurger;
        private System.Windows.Forms.RadioButton rdbVeggieBurger;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbNoDrink;
        private System.Windows.Forms.RadioButton rdbWater;
        private System.Windows.Forms.RadioButton rdbFruitPunch;
        private System.Windows.Forms.RadioButton rdbCola;
        private System.Windows.Forms.RadioButton rdbTea;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdbNoSandwich;
        private System.Windows.Forms.RadioButton rdbBLT;
        private System.Windows.Forms.RadioButton rdbItalianSub;
        private System.Windows.Forms.RadioButton rdbChickenSandwich;
        private System.Windows.Forms.RadioButton rdbTurkeyClub;
        private System.Windows.Forms.ComboBox cmb_coupon;
        private System.Windows.Forms.Label label4;
    }
}

