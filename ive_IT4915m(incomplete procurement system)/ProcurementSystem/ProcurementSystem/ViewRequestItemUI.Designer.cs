namespace ProcurementSystem
{
    partial class ViewRequestItemUI
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
            this.dgvRequestItem = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestItem)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvRequestItem
            // 
            this.dgvRequestItem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequestItem.Location = new System.Drawing.Point(40, 31);
            this.dgvRequestItem.Name = "dgvRequestItem";
            this.dgvRequestItem.RowTemplate.Height = 24;
            this.dgvRequestItem.Size = new System.Drawing.Size(723, 300);
            this.dgvRequestItem.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(688, 361);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ViewRequestItemUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 407);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvRequestItem);
            this.Name = "ViewRequestItemUI";
            this.Text = "ViewRequestItemUI";
            this.Load += new System.EventHandler(this.ViewRequestItemUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequestItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequestItem;
        private System.Windows.Forms.Button btnSubmit;
    }
}