namespace ProcurementSystem
{
    partial class ViewBPAItemsUI
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
            this.dgvBPAItems = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBPAItems)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBPAItems
            // 
            this.dgvBPAItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBPAItems.Location = new System.Drawing.Point(22, 42);
            this.dgvBPAItems.Name = "dgvBPAItems";
            this.dgvBPAItems.RowTemplate.Height = 24;
            this.dgvBPAItems.Size = new System.Drawing.Size(741, 281);
            this.dgvBPAItems.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(688, 331);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ViewBPAItemsUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 366);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dgvBPAItems);
            this.Name = "ViewBPAItemsUI";
            this.Text = "ViewBPAItemsUI";
            this.Load += new System.EventHandler(this.ViewBPAItemsUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBPAItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBPAItems;
        private System.Windows.Forms.Button btnSubmit;
    }
}