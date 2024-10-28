namespace BurgerBarn
{
    partial class frmBurgerBarn
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
            this.gbxBurgers = new System.Windows.Forms.GroupBox();
            this.rdb_baconBurg = new System.Windows.Forms.RadioButton();
            this.rdb_vegBurg = new System.Windows.Forms.RadioButton();
            this.rdb_cheeBurg = new System.Windows.Forms.RadioButton();
            this.rdb_plainBurg = new System.Windows.Forms.RadioButton();
            this.gbxDrinks = new System.Windows.Forms.GroupBox();
            this.rdb_drinkWater = new System.Windows.Forms.RadioButton();
            this.rdb_drinkPunch = new System.Windows.Forms.RadioButton();
            this.rdb_drinkCoala = new System.Windows.Forms.RadioButton();
            this.rdb_drinkTea = new System.Windows.Forms.RadioButton();
            this.prg_totalItems = new System.Windows.Forms.ProgressBar();
            this.gbxSides = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gbxBurgers.SuspendLayout();
            this.gbxDrinks.SuspendLayout();
            this.gbxSides.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBurgers
            // 
            this.gbxBurgers.Controls.Add(this.rdb_baconBurg);
            this.gbxBurgers.Controls.Add(this.rdb_vegBurg);
            this.gbxBurgers.Controls.Add(this.rdb_cheeBurg);
            this.gbxBurgers.Controls.Add(this.rdb_plainBurg);
            this.gbxBurgers.Location = new System.Drawing.Point(116, 190);
            this.gbxBurgers.Name = "gbxBurgers";
            this.gbxBurgers.Size = new System.Drawing.Size(200, 111);
            this.gbxBurgers.TabIndex = 0;
            this.gbxBurgers.TabStop = false;
            this.gbxBurgers.Text = "Burgers";
            this.gbxBurgers.Enter += new System.EventHandler(this.gbxBurgers_Enter);
            // 
            // rdb_baconBurg
            // 
            this.rdb_baconBurg.AutoSize = true;
            this.rdb_baconBurg.Location = new System.Drawing.Point(6, 83);
            this.rdb_baconBurg.Name = "rdb_baconBurg";
            this.rdb_baconBurg.Size = new System.Drawing.Size(90, 17);
            this.rdb_baconBurg.TabIndex = 6;
            this.rdb_baconBurg.TabStop = true;
            this.rdb_baconBurg.Text = "Bacon Burger";
            this.rdb_baconBurg.UseVisualStyleBackColor = true;
            // 
            // rdb_vegBurg
            // 
            this.rdb_vegBurg.AutoSize = true;
            this.rdb_vegBurg.Location = new System.Drawing.Point(6, 65);
            this.rdb_vegBurg.Name = "rdb_vegBurg";
            this.rdb_vegBurg.Size = new System.Drawing.Size(86, 17);
            this.rdb_vegBurg.TabIndex = 5;
            this.rdb_vegBurg.TabStop = true;
            this.rdb_vegBurg.Text = "Vegie Burger";
            this.rdb_vegBurg.UseVisualStyleBackColor = true;
            // 
            // rdb_cheeBurg
            // 
            this.rdb_cheeBurg.AutoSize = true;
            this.rdb_cheeBurg.Location = new System.Drawing.Point(6, 42);
            this.rdb_cheeBurg.Name = "rdb_cheeBurg";
            this.rdb_cheeBurg.Size = new System.Drawing.Size(91, 17);
            this.rdb_cheeBurg.TabIndex = 4;
            this.rdb_cheeBurg.TabStop = true;
            this.rdb_cheeBurg.Text = "Cheeseburger";
            this.rdb_cheeBurg.UseVisualStyleBackColor = true;
            // 
            // rdb_plainBurg
            // 
            this.rdb_plainBurg.AutoSize = true;
            this.rdb_plainBurg.Location = new System.Drawing.Point(6, 19);
            this.rdb_plainBurg.Name = "rdb_plainBurg";
            this.rdb_plainBurg.Size = new System.Drawing.Size(82, 17);
            this.rdb_plainBurg.TabIndex = 3;
            this.rdb_plainBurg.TabStop = true;
            this.rdb_plainBurg.Text = "Plain Burger";
            this.rdb_plainBurg.UseVisualStyleBackColor = true;
            // 
            // gbxDrinks
            // 
            this.gbxDrinks.Controls.Add(this.rdb_drinkWater);
            this.gbxDrinks.Controls.Add(this.rdb_drinkPunch);
            this.gbxDrinks.Controls.Add(this.rdb_drinkCoala);
            this.gbxDrinks.Controls.Add(this.rdb_drinkTea);
            this.gbxDrinks.Location = new System.Drawing.Point(588, 327);
            this.gbxDrinks.Name = "gbxDrinks";
            this.gbxDrinks.Size = new System.Drawing.Size(200, 111);
            this.gbxDrinks.TabIndex = 1;
            this.gbxDrinks.TabStop = false;
            this.gbxDrinks.Text = "Drinks";
            this.gbxDrinks.Enter += new System.EventHandler(this.gbxDrinks_Enter);
            // 
            // rdb_drinkWater
            // 
            this.rdb_drinkWater.AutoSize = true;
            this.rdb_drinkWater.Location = new System.Drawing.Point(6, 83);
            this.rdb_drinkWater.Name = "rdb_drinkWater";
            this.rdb_drinkWater.Size = new System.Drawing.Size(54, 17);
            this.rdb_drinkWater.TabIndex = 3;
            this.rdb_drinkWater.TabStop = true;
            this.rdb_drinkWater.Text = "Water";
            this.rdb_drinkWater.UseVisualStyleBackColor = true;
            // 
            // rdb_drinkPunch
            // 
            this.rdb_drinkPunch.AutoSize = true;
            this.rdb_drinkPunch.Location = new System.Drawing.Point(6, 65);
            this.rdb_drinkPunch.Name = "rdb_drinkPunch";
            this.rdb_drinkPunch.Size = new System.Drawing.Size(79, 17);
            this.rdb_drinkPunch.TabIndex = 2;
            this.rdb_drinkPunch.TabStop = true;
            this.rdb_drinkPunch.Text = "Fruit Punch";
            this.rdb_drinkPunch.UseVisualStyleBackColor = true;
            // 
            // rdb_drinkCoala
            // 
            this.rdb_drinkCoala.AutoSize = true;
            this.rdb_drinkCoala.Location = new System.Drawing.Point(6, 19);
            this.rdb_drinkCoala.Name = "rdb_drinkCoala";
            this.rdb_drinkCoala.Size = new System.Drawing.Size(52, 17);
            this.rdb_drinkCoala.TabIndex = 0;
            this.rdb_drinkCoala.TabStop = true;
            this.rdb_drinkCoala.Text = "Coala";
            this.rdb_drinkCoala.UseVisualStyleBackColor = true;
            // 
            // rdb_drinkTea
            // 
            this.rdb_drinkTea.AutoSize = true;
            this.rdb_drinkTea.Location = new System.Drawing.Point(6, 42);
            this.rdb_drinkTea.Name = "rdb_drinkTea";
            this.rdb_drinkTea.Size = new System.Drawing.Size(44, 17);
            this.rdb_drinkTea.TabIndex = 1;
            this.rdb_drinkTea.TabStop = true;
            this.rdb_drinkTea.Text = "Tea";
            this.rdb_drinkTea.UseVisualStyleBackColor = true;
            // 
            // prg_totalItems
            // 
            this.prg_totalItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.prg_totalItems.Location = new System.Drawing.Point(0, 0);
            this.prg_totalItems.Maximum = 3;
            this.prg_totalItems.Name = "prg_totalItems";
            this.prg_totalItems.Size = new System.Drawing.Size(800, 23);
            this.prg_totalItems.Step = 1;
            this.prg_totalItems.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prg_totalItems.TabIndex = 2;
            this.prg_totalItems.Click += new System.EventHandler(this.prg_totalItems_Click);
            // 
            // gbxSides
            // 
            this.gbxSides.Controls.Add(this.radioButton4);
            this.gbxSides.Controls.Add(this.radioButton3);
            this.gbxSides.Controls.Add(this.radioButton2);
            this.gbxSides.Controls.Add(this.radioButton1);
            this.gbxSides.Location = new System.Drawing.Point(116, 327);
            this.gbxSides.Name = "gbxSides";
            this.gbxSides.Size = new System.Drawing.Size(200, 118);
            this.gbxSides.TabIndex = 2;
            this.gbxSides.TabStop = false;
            this.gbxSides.Text = "Sides";
            this.gbxSides.Enter += new System.EventHandler(this.gbxSides_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(47, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Fries";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 44);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tater Tots";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 68);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(83, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Onion Rings";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 93);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(51, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Chips";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // frmBurgerBarn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbxSides);
            this.Controls.Add(this.prg_totalItems);
            this.Controls.Add(this.gbxDrinks);
            this.Controls.Add(this.gbxBurgers);
            this.Name = "frmBurgerBarn";
            this.Text = "Burger Barn";
            this.Load += new System.EventHandler(this.frmBurgerBarn_Load);
            this.gbxBurgers.ResumeLayout(false);
            this.gbxBurgers.PerformLayout();
            this.gbxDrinks.ResumeLayout(false);
            this.gbxDrinks.PerformLayout();
            this.gbxSides.ResumeLayout(false);
            this.gbxSides.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBurgers;
        private System.Windows.Forms.GroupBox gbxDrinks;
        private System.Windows.Forms.ProgressBar prg_totalItems;
        private System.Windows.Forms.GroupBox gbxSides;
        private System.Windows.Forms.RadioButton rdb_baconBurg;
        private System.Windows.Forms.RadioButton rdb_vegBurg;
        private System.Windows.Forms.RadioButton rdb_cheeBurg;
        private System.Windows.Forms.RadioButton rdb_plainBurg;
        private System.Windows.Forms.RadioButton rdb_drinkWater;
        private System.Windows.Forms.RadioButton rdb_drinkPunch;
        private System.Windows.Forms.RadioButton rdb_drinkCoala;
        private System.Windows.Forms.RadioButton rdb_drinkTea;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

