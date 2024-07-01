namespace ProcurementSystem
{
    partial class MakeScheduleReleaseUI
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
            this.dgvPPO = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPPOID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpExpectedDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnViewPPOItems = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPPO)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPPO
            // 
            this.dgvPPO.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPPO.Location = new System.Drawing.Point(454, 59);
            this.dgvPPO.Name = "dgvPPO";
            this.dgvPPO.RowTemplate.Height = 24;
            this.dgvPPO.Size = new System.Drawing.Size(478, 254);
            this.dgvPPO.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "PPOID";
            // 
            // txtPPOID
            // 
            this.txtPPOID.Location = new System.Drawing.Point(124, 56);
            this.txtPPOID.Name = "txtPPOID";
            this.txtPPOID.Size = new System.Drawing.Size(137, 22);
            this.txtPPOID.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Expected Delivery Date";
            // 
            // dtpExpectedDeliveryDate
            // 
            this.dtpExpectedDeliveryDate.Location = new System.Drawing.Point(124, 107);
            this.dtpExpectedDeliveryDate.Name = "dtpExpectedDeliveryDate";
            this.dtpExpectedDeliveryDate.Size = new System.Drawing.Size(260, 22);
            this.dtpExpectedDeliveryDate.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(857, 341);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(776, 341);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnViewPPOItems
            // 
            this.btnViewPPOItems.Location = new System.Drawing.Point(267, 56);
            this.btnViewPPOItems.Name = "btnViewPPOItems";
            this.btnViewPPOItems.Size = new System.Drawing.Size(117, 23);
            this.btnViewPPOItems.TabIndex = 7;
            this.btnViewPPOItems.Text = "View PPO items";
            this.btnViewPPOItems.UseVisualStyleBackColor = true;
            this.btnViewPPOItems.Click += new System.EventHandler(this.btnViewPPOItems_Click);
            // 
            // MakeScheduleReleaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 395);
            this.Controls.Add(this.btnViewPPOItems);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dtpExpectedDeliveryDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPPOID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvPPO);
            this.Name = "MakeScheduleReleaseUI";
            this.Text = "MakeScheduleReleaseUI";
            this.Load += new System.EventHandler(this.MakeScheduleReleaseUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPPO)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPPO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPPOID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpExpectedDeliveryDate;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnViewPPOItems;
    }
}