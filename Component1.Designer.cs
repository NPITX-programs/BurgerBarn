namespace BurgerBarn
{
    partial class Component1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtWelcome = new System.Windows.Forms.TextBox();
            // 
            // txtWelcome
            // 
            this.txtWelcome.Location = new System.Drawing.Point(0, 0);
            this.txtWelcome.Name = "txtWelcome";
            this.txtWelcome.Size = new System.Drawing.Size(100, 20);
            this.txtWelcome.TabIndex = 0;
            this.txtWelcome.TextChanged += new System.EventHandler(this.txtWelcome_TextChanged);

        }

        #endregion

        private System.Windows.Forms.TextBox txtWelcome;
    }
}
