namespace ProcurementSystem
{
    partial class UpdateDeliveryNoteStatusUI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewDeliveryNoteLine = new System.Windows.Forms.Button();
            this.btnDeliver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(924, 274);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Delivery Note";
            // 
            // btnViewDeliveryNoteLine
            // 
            this.btnViewDeliveryNoteLine.Location = new System.Drawing.Point(32, 361);
            this.btnViewDeliveryNoteLine.Name = "btnViewDeliveryNoteLine";
            this.btnViewDeliveryNoteLine.Size = new System.Drawing.Size(146, 23);
            this.btnViewDeliveryNoteLine.TabIndex = 2;
            this.btnViewDeliveryNoteLine.Text = "View Delivery Note line";
            this.btnViewDeliveryNoteLine.UseVisualStyleBackColor = true;
            this.btnViewDeliveryNoteLine.Click += new System.EventHandler(this.btnViewDeliveryNoteLine_Click);
            // 
            // btnDeliver
            // 
            this.btnDeliver.Location = new System.Drawing.Point(840, 451);
            this.btnDeliver.Name = "btnDeliver";
            this.btnDeliver.Size = new System.Drawing.Size(114, 23);
            this.btnDeliver.TabIndex = 3;
            this.btnDeliver.Text = "Deliver";
            this.btnDeliver.UseVisualStyleBackColor = true;
            this.btnDeliver.Click += new System.EventHandler(this.btnDeliver_Click);
            // 
            // UpdateDeliveryNoteStatusUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(995, 501);
            this.Controls.Add(this.btnDeliver);
            this.Controls.Add(this.btnViewDeliveryNoteLine);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateDeliveryNoteStatusUI";
            this.Text = "UpdateDeliveryNoteStatusUI";
            this.Load += new System.EventHandler(this.UpdateDeliveryNoteStatusUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnViewDeliveryNoteLine;
        private System.Windows.Forms.Button btnDeliver;
    }
}