namespace ElectronicShoppingManagementSystemCSharp
{
    partial class HomeCust
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.PurchaseProductToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PurchaseProductToolStripMenuItem,
            this.ViewProductsToolStripMenuItem,
            this.ExitToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(672, 24);
            this.MenuStrip1.TabIndex = 1;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // PurchaseProductToolStripMenuItem
            // 
            this.PurchaseProductToolStripMenuItem.Name = "PurchaseProductToolStripMenuItem";
            this.PurchaseProductToolStripMenuItem.Size = new System.Drawing.Size(142, 20);
            this.PurchaseProductToolStripMenuItem.Text = "Purchase Product";
            this.PurchaseProductToolStripMenuItem.Click += new System.EventHandler(this.PurchaseProductToolStripMenuItem_Click);
            // 
            // ViewProductsToolStripMenuItem
            // 
            this.ViewProductsToolStripMenuItem.Name = "ViewProductsToolStripMenuItem";
            this.ViewProductsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.ViewProductsToolStripMenuItem.Text = "View Products";
            this.ViewProductsToolStripMenuItem.Click += new System.EventHandler(this.ViewProductsToolStripMenuItem_Click);
            // 
            // ExitToolStripMenuItem
            // 
            this.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem";
            this.ExitToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.ExitToolStripMenuItem.Text = "Exit";
            this.ExitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // HomeCust
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 430);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "HomeCust";
            this.Text = "HomeCust";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem PurchaseProductToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ViewProductsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ExitToolStripMenuItem;
    }
}