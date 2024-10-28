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
            this.SuspendLayout();
            // 
            // gbxBurgers
            // 
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxBurgers;
        private System.Windows.Forms.GroupBox gbxDrinks;
        private System.Windows.Forms.ProgressBar prg_totalItems;
        private System.Windows.Forms.GroupBox gbxSides;
    }
}

