namespace ProcurementSystem
{
    partial class PurchaseManagerUI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRequestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.makeSecheduleReleaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemLogout,
            this.viewRequestToolStripMenuItem,
            this.makeSecheduleReleaseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1012, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemLogout
            // 
            this.MenuItemLogout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.MenuItemLogout.Name = "MenuItemLogout";
            this.MenuItemLogout.Size = new System.Drawing.Size(57, 20);
            this.MenuItemLogout.Text = "logout";
            this.MenuItemLogout.Click += new System.EventHandler(this.MenuItemLogout_Click);
            // 
            // viewRequestToolStripMenuItem
            // 
            this.viewRequestToolStripMenuItem.Name = "viewRequestToolStripMenuItem";
            this.viewRequestToolStripMenuItem.Size = new System.Drawing.Size(144, 20);
            this.viewRequestToolStripMenuItem.Text = "Request management";
            this.viewRequestToolStripMenuItem.Click += new System.EventHandler(this.viewRequestToolStripMenuItem_Click);
            // 
            // makeSecheduleReleaseToolStripMenuItem
            // 
            this.makeSecheduleReleaseToolStripMenuItem.Name = "makeSecheduleReleaseToolStripMenuItem";
            this.makeSecheduleReleaseToolStripMenuItem.Size = new System.Drawing.Size(147, 20);
            this.makeSecheduleReleaseToolStripMenuItem.Text = "Make schedule release";
            this.makeSecheduleReleaseToolStripMenuItem.Click += new System.EventHandler(this.makeSecheduleReleaseToolStripMenuItem_Click);
            // 
            // PurchaseManagerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 728);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "PurchaseManagerUI";
            this.Text = "PurchaseManager";
            this.Load += new System.EventHandler(this.PurchaseManagerUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLogout;
        private System.Windows.Forms.ToolStripMenuItem viewRequestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem makeSecheduleReleaseToolStripMenuItem;
    }
}