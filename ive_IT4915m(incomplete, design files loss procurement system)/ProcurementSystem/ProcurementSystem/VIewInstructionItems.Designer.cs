namespace ProcurementSystem
{
    partial class VIewInstructionItems
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
            this.dgvInstructionItems = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructionItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInstructionItems
            // 
            this.dgvInstructionItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstructionItems.Location = new System.Drawing.Point(38, 64);
            this.dgvInstructionItems.Name = "dgvInstructionItems";
            this.dgvInstructionItems.RowTemplate.Height = 24;
            this.dgvInstructionItems.Size = new System.Drawing.Size(698, 277);
            this.dgvInstructionItems.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(661, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Cancel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VIewInstructionItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 394);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvInstructionItems);
            this.Name = "VIewInstructionItems";
            this.Text = "VIewInstructionItems";
            this.Load += new System.EventHandler(this.VIewInstructionItems_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstructionItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInstructionItems;
        private System.Windows.Forms.Button button1;
    }
}