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
            this.rdbVeggieBurger = new System.Windows.Forms.RadioButton();
            this.rdbBaconBurger = new System.Windows.Forms.RadioButton();
            this.rdbNoBurger = new System.Windows.Forms.RadioButton();
            this.lstOrder = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblSubtoal = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdbWater = new System.Windows.Forms.RadioButton();
            this.rdbNoDrink = new System.Windows.Forms.RadioButton();
            this.rdbCola = new System.Windows.Forms.RadioButton();
            this.rdbFruitPunch = new System.Windows.Forms.RadioButton();
            this.rdbTea = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdbChips = new System.Windows.Forms.RadioButton();
            this.rdbNoSide = new System.Windows.Forms.RadioButton();
            this.rdbFries = new System.Windows.Forms.RadioButton();
            this.rdbOnionRings = new System.Windows.Forms.RadioButton();
            this.rdbTaterTots = new System.Windows.Forms.RadioButton();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdbPlainBurger
            // 
            this.rdbPlainBurger.AutoSize = true;
            this.rdbPlainBurger.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbPlainBurger.Location = new System.Drawing.Point(14, 19);
            this.rdbPlainBurger.Name = "rdbPlainBurger";
            this.rdbPlainBurger.Size = new System.Drawing.Size(151, 23);
            this.rdbPlainBurger.TabIndex = 0;
            this.rdbPlainBurger.TabStop = true;
            this.rdbPlainBurger.Tag = "4.99";
            this.rdbPlainBurger.Text = "Plain Burger ($4.99)";
            this.rdbPlainBurger.UseVisualStyleBackColor = true;
            this.rdbPlainBurger.CheckedChanged += new System.EventHandler(this.rdb_selectBurg);
            // 
            // rdbCheeseburger
            // 
            this.rdbCheeseburger.AutoSize = true;
            this.rdbCheeseburger.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCheeseburger.Location = new System.Drawing.Point(14, 48);
            this.rdbCheeseburger.Name = "rdbCheeseburger";
            this.rdbCheeseburger.Size = new System.Drawing.Size(161, 23);
            this.rdbCheeseburger.TabIndex = 0;
            this.rdbCheeseburger.TabStop = true;
            this.rdbCheeseburger.Tag = "5.99";
            this.rdbCheeseburger.Text = "Cheeseburger ($5.99)";
            this.rdbCheeseburger.UseVisualStyleBackColor = true;
            this.rdbCheeseburger.CheckedChanged += new System.EventHandler(this.rdb_selectBurg);
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
            this.rdbVeggieBurger.CheckedChanged += new System.EventHandler(this.rdb_selectBurg);
            // 
            // rdbBaconBurger
            // 
            this.rdbBaconBurger.AutoSize = true;
            this.rdbBaconBurger.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbBaconBurger.Location = new System.Drawing.Point(15, 106);
            this.rdbBaconBurger.Name = "rdbBaconBurger";
            this.rdbBaconBurger.Size = new System.Drawing.Size(161, 23);
            this.rdbBaconBurger.TabIndex = 0;
            this.rdbBaconBurger.TabStop = true;
            this.rdbBaconBurger.Tag = "7.99";
            this.rdbBaconBurger.Text = "Bacon Burger ($7.99)";
            this.rdbBaconBurger.UseVisualStyleBackColor = true;
            this.rdbBaconBurger.CheckedChanged += new System.EventHandler(this.rdb_selectBurg);
            // 
            // rdbNoBurger
            // 
            this.rdbNoBurger.AutoSize = true;
            this.rdbNoBurger.Checked = true;
            this.rdbNoBurger.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNoBurger.Location = new System.Drawing.Point(15, 137);
            this.rdbNoBurger.Name = "rdbNoBurger";
            this.rdbNoBurger.Size = new System.Drawing.Size(61, 23);
            this.rdbNoBurger.TabIndex = 0;
            this.rdbNoBurger.TabStop = true;
            this.rdbNoBurger.Tag = "0";
            this.rdbNoBurger.Text = "None";
            this.rdbNoBurger.UseVisualStyleBackColor = true;
            this.rdbNoBurger.CheckedChanged += new System.EventHandler(this.rdb_selectBurg);
            // 
            // lstOrder
            // 
            this.lstOrder.FormattingEnabled = true;
            this.lstOrder.Location = new System.Drawing.Point(577, 65);
            this.lstOrder.Name = "lstOrder";
            this.lstOrder.Size = new System.Drawing.Size(211, 355);
            this.lstOrder.Sorted = true;
            this.lstOrder.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbBaconBurger);
            this.groupBox1.Controls.Add(this.rdbNoBurger);
            this.groupBox1.Controls.Add(this.rdbPlainBurger);
            this.groupBox1.Controls.Add(this.rdbVeggieBurger);
            this.groupBox1.Controls.Add(this.rdbCheeseburger);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(203, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Burgers";
            // 
            // lblSubtoal
            // 
            this.lblSubtoal.AutoSize = true;
            this.lblSubtoal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtoal.Location = new System.Drawing.Point(494, 316);
            this.lblSubtoal.Name = "lblSubtoal";
            this.lblSubtoal.Size = new System.Drawing.Size(45, 19);
            this.lblSubtoal.TabIndex = 3;
            this.lblSubtoal.Text = "$0.00";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(494, 345);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(45, 19);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "$0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(494, 379);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(45, 19);
            this.lblTotal.TabIndex = 5;
            this.lblTotal.Text = "$0.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(418, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Subtotal:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(446, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Tax:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(438, 379);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdbWater);
            this.groupBox2.Controls.Add(this.rdbNoDrink);
            this.groupBox2.Controls.Add(this.rdbCola);
            this.groupBox2.Controls.Add(this.rdbFruitPunch);
            this.groupBox2.Controls.Add(this.rdbTea);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(336, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(203, 212);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Drinks";
            // 
            // rdbWater
            // 
            this.rdbWater.AutoSize = true;
            this.rdbWater.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbWater.Location = new System.Drawing.Point(14, 106);
            this.rdbWater.Name = "rdbWater";
            this.rdbWater.Size = new System.Drawing.Size(114, 23);
            this.rdbWater.TabIndex = 0;
            this.rdbWater.TabStop = true;
            this.rdbWater.Tag = ".99";
            this.rdbWater.Text = "Water ($0.99)";
            this.rdbWater.UseVisualStyleBackColor = true;
            this.rdbWater.CheckedChanged += new System.EventHandler(this.rdb_selectDrink);
            // 
            // rdbNoDrink
            // 
            this.rdbNoDrink.AutoSize = true;
            this.rdbNoDrink.Checked = true;
            this.rdbNoDrink.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNoDrink.Location = new System.Drawing.Point(14, 137);
            this.rdbNoDrink.Name = "rdbNoDrink";
            this.rdbNoDrink.Size = new System.Drawing.Size(61, 23);
            this.rdbNoDrink.TabIndex = 0;
            this.rdbNoDrink.TabStop = true;
            this.rdbNoDrink.Tag = "0";
            this.rdbNoDrink.Text = "None";
            this.rdbNoDrink.UseVisualStyleBackColor = true;
            this.rdbNoDrink.CheckedChanged += new System.EventHandler(this.rdb_selectDrink);
            // 
            // rdbCola
            // 
            this.rdbCola.AutoSize = true;
            this.rdbCola.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCola.Location = new System.Drawing.Point(14, 19);
            this.rdbCola.Name = "rdbCola";
            this.rdbCola.Size = new System.Drawing.Size(106, 23);
            this.rdbCola.TabIndex = 0;
            this.rdbCola.TabStop = true;
            this.rdbCola.Tag = "1.29";
            this.rdbCola.Text = "Cola ($1.29)";
            this.rdbCola.UseVisualStyleBackColor = true;
            this.rdbCola.CheckedChanged += new System.EventHandler(this.rdb_selectDrink);
            // 
            // rdbFruitPunch
            // 
            this.rdbFruitPunch.AutoSize = true;
            this.rdbFruitPunch.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFruitPunch.Location = new System.Drawing.Point(14, 77);
            this.rdbFruitPunch.Name = "rdbFruitPunch";
            this.rdbFruitPunch.Size = new System.Drawing.Size(146, 23);
            this.rdbFruitPunch.TabIndex = 0;
            this.rdbFruitPunch.TabStop = true;
            this.rdbFruitPunch.Tag = "1.09";
            this.rdbFruitPunch.Text = "Fruit Punch ($1.09)";
            this.rdbFruitPunch.UseVisualStyleBackColor = true;
            this.rdbFruitPunch.CheckedChanged += new System.EventHandler(this.rdb_selectDrink);
            // 
            // rdbTea
            // 
            this.rdbTea.AutoSize = true;
            this.rdbTea.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTea.Location = new System.Drawing.Point(14, 48);
            this.rdbTea.Name = "rdbTea";
            this.rdbTea.Size = new System.Drawing.Size(99, 23);
            this.rdbTea.TabIndex = 0;
            this.rdbTea.TabStop = true;
            this.rdbTea.Tag = "1.19";
            this.rdbTea.Text = "Tea ($1.19)";
            this.rdbTea.UseVisualStyleBackColor = true;
            this.rdbTea.CheckedChanged += new System.EventHandler(this.rdb_selectDrink);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdbChips);
            this.groupBox3.Controls.Add(this.rdbNoSide);
            this.groupBox3.Controls.Add(this.rdbFries);
            this.groupBox3.Controls.Add(this.rdbOnionRings);
            this.groupBox3.Controls.Add(this.rdbTaterTots);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(21, 270);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(203, 189);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sides";
            // 
            // rdbChips
            // 
            this.rdbChips.AutoSize = true;
            this.rdbChips.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbChips.Location = new System.Drawing.Point(14, 106);
            this.rdbChips.Name = "rdbChips";
            this.rdbChips.Size = new System.Drawing.Size(112, 23);
            this.rdbChips.TabIndex = 0;
            this.rdbChips.TabStop = true;
            this.rdbChips.Tag = ".99";
            this.rdbChips.Text = "Chips ($0.99)";
            this.rdbChips.UseVisualStyleBackColor = true;
            this.rdbChips.CheckedChanged += new System.EventHandler(this.rdb_selectSide);
            // 
            // rdbNoSide
            // 
            this.rdbNoSide.AutoSize = true;
            this.rdbNoSide.Checked = true;
            this.rdbNoSide.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNoSide.Location = new System.Drawing.Point(15, 135);
            this.rdbNoSide.Name = "rdbNoSide";
            this.rdbNoSide.Size = new System.Drawing.Size(61, 23);
            this.rdbNoSide.TabIndex = 0;
            this.rdbNoSide.TabStop = true;
            this.rdbNoSide.Tag = "0";
            this.rdbNoSide.Text = "None";
            this.rdbNoSide.UseVisualStyleBackColor = true;
            this.rdbNoSide.CheckedChanged += new System.EventHandler(this.rdb_selectSide);
            // 
            // rdbFries
            // 
            this.rdbFries.AutoSize = true;
            this.rdbFries.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbFries.Location = new System.Drawing.Point(15, 19);
            this.rdbFries.Name = "rdbFries";
            this.rdbFries.Size = new System.Drawing.Size(107, 23);
            this.rdbFries.TabIndex = 0;
            this.rdbFries.TabStop = true;
            this.rdbFries.Tag = ".50";
            this.rdbFries.Text = "Fries ($0.50)";
            this.rdbFries.UseVisualStyleBackColor = true;
            this.rdbFries.CheckedChanged += new System.EventHandler(this.rdb_selectSide);
            // 
            // rdbOnionRings
            // 
            this.rdbOnionRings.AutoSize = true;
            this.rdbOnionRings.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOnionRings.Location = new System.Drawing.Point(14, 77);
            this.rdbOnionRings.Name = "rdbOnionRings";
            this.rdbOnionRings.Size = new System.Drawing.Size(151, 23);
            this.rdbOnionRings.TabIndex = 0;
            this.rdbOnionRings.TabStop = true;
            this.rdbOnionRings.Tag = ".99";
            this.rdbOnionRings.Text = "Onion Rings ($0.99)";
            this.rdbOnionRings.UseVisualStyleBackColor = true;
            this.rdbOnionRings.CheckedChanged += new System.EventHandler(this.rdb_selectSide);
            // 
            // rdbTaterTots
            // 
            this.rdbTaterTots.AutoSize = true;
            this.rdbTaterTots.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTaterTots.Location = new System.Drawing.Point(15, 48);
            this.rdbTaterTots.Name = "rdbTaterTots";
            this.rdbTaterTots.Size = new System.Drawing.Size(138, 23);
            this.rdbTaterTots.TabIndex = 0;
            this.rdbTaterTots.TabStop = true;
            this.rdbTaterTots.Tag = ".75";
            this.rdbTaterTots.Text = "Tater Tots ($0.75)";
            this.rdbTaterTots.UseVisualStyleBackColor = true;
            this.rdbTaterTots.CheckedChanged += new System.EventHandler(this.rdb_selectSide);
            // 
            // btnPurchase
            // 
            this.btnPurchase.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchase.Location = new System.Drawing.Point(453, 438);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(86, 31);
            this.btnPurchase.TabIndex = 9;
            this.btnPurchase.Text = "Purchase";
            this.btnPurchase.UseVisualStyleBackColor = true;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(643, 438);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(86, 31);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPurchase);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSubtoal);
            this.Controls.Add(this.lstOrder);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Burger Barn";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbPlainBurger;
        private System.Windows.Forms.RadioButton rdbCheeseburger;
        private System.Windows.Forms.RadioButton rdbVeggieBurger;
        private System.Windows.Forms.RadioButton rdbBaconBurger;
        private System.Windows.Forms.RadioButton rdbNoBurger;
        private System.Windows.Forms.ListBox lstOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSubtoal;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rdbWater;
        private System.Windows.Forms.RadioButton rdbNoDrink;
        private System.Windows.Forms.RadioButton rdbCola;
        private System.Windows.Forms.RadioButton rdbFruitPunch;
        private System.Windows.Forms.RadioButton rdbTea;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdbChips;
        private System.Windows.Forms.RadioButton rdbNoSide;
        private System.Windows.Forms.RadioButton rdbFries;
        private System.Windows.Forms.RadioButton rdbOnionRings;
        private System.Windows.Forms.RadioButton rdbTaterTots;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnExit;
    }
}

