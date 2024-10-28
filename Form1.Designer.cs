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
            this.gbxDrinks = new System.Windows.Forms.GroupBox();
            this.prg_totalItems = new System.Windows.Forms.ProgressBar();
            this.gbxSides = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.gbxBurgers.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxBurgers
            // 
            this.gbxBurgers.Controls.Add(this.radioButton4);
            this.gbxBurgers.Controls.Add(this.radioButton3);
            this.gbxBurgers.Controls.Add(this.radioButton2);
            this.gbxBurgers.Controls.Add(this.radioButton1);
            this.gbxBurgers.Location = new System.Drawing.Point(116, 190);
            this.gbxBurgers.Name = "gbxBurgers";
            this.gbxBurgers.Size = new System.Drawing.Size(200, 100);
            this.gbxBurgers.TabIndex = 0;
            this.gbxBurgers.TabStop = false;
            this.gbxBurgers.Text = "Burgers";
            this.gbxBurgers.Enter += new System.EventHandler(this.gbxBurgers_Enter);
            // 
            // gbxDrinks
            // 
            this.gbxDrinks.Location = new System.Drawing.Point(588, 338);
            this.gbxDrinks.Name = "gbxDrinks";
            this.gbxDrinks.Size = new System.Drawing.Size(200, 100);
            this.gbxDrinks.TabIndex = 1;
            this.gbxDrinks.TabStop = false;
            this.gbxDrinks.Text = "Drinks";
            this.gbxDrinks.Enter += new System.EventHandler(this.gbxDrinks_Enter);
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
            this.gbxSides.Location = new System.Drawing.Point(116, 338);
            this.gbxSides.Name = "gbxSides";
            this.gbxSides.Size = new System.Drawing.Size(200, 100);
            this.gbxSides.TabIndex = 2;
            this.gbxSides.TabStop = false;
            this.gbxSides.Text = "Sides";
            this.gbxSides.Enter += new System.EventHandler(this.gbxSides_Enter);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(82, 17);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Plain Burger";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(91, 17);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Cheeseburger";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(86, 17);
            this.radioButton3.TabIndex = 5;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Vegie Burger";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(6, 83);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(90, 17);
            this.radioButton4.TabIndex = 6;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Bacon Burger";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBurgers;
        private System.Windows.Forms.GroupBox gbxDrinks;
        private System.Windows.Forms.ProgressBar prg_totalItems;
        private System.Windows.Forms.GroupBox gbxSides;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}

