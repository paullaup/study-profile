namespace ProcurementSystem
{
    partial class WarehouseClerkUI
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.receiveDespatchInstructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateDeliveryNoteStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.receiveDespatchInstructionToolStripMenuItem,
            this.updateDeliveryNoteStatusToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(991, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(57, 20);
            this.toolStripMenuItem1.Text = "logout";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // receiveDespatchInstructionToolStripMenuItem
            // 
            this.receiveDespatchInstructionToolStripMenuItem.Name = "receiveDespatchInstructionToolStripMenuItem";
            this.receiveDespatchInstructionToolStripMenuItem.Size = new System.Drawing.Size(180, 20);
            this.receiveDespatchInstructionToolStripMenuItem.Text = "Receive Despatch Instruction";
            this.receiveDespatchInstructionToolStripMenuItem.Click += new System.EventHandler(this.receiveDespatchInstructionToolStripMenuItem_Click);
            // 
            // updateDeliveryNoteStatusToolStripMenuItem
            // 
            this.updateDeliveryNoteStatusToolStripMenuItem.Name = "updateDeliveryNoteStatusToolStripMenuItem";
            this.updateDeliveryNoteStatusToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.updateDeliveryNoteStatusToolStripMenuItem.Text = "Delivery notes";
            this.updateDeliveryNoteStatusToolStripMenuItem.Click += new System.EventHandler(this.updateDeliveryNoteStatusToolStripMenuItem_Click);
            // 
            // WarehouseClerkUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 735);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "WarehouseClerkUI";
            this.Text = "WarehouseClerkUI";
            this.Load += new System.EventHandler(this.WarehouseClerkUI_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem receiveDespatchInstructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateDeliveryNoteStatusToolStripMenuItem;
    }
}