namespace ProcurementSystem
{
    partial class MakeBlanketReleaseUI
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
            this.dgvBPA = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnViewRequestItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBPAID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtShipAddress = new System.Windows.Forms.TextBox();
            this.btnSelectAddress = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.lblAmount = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtExpectedDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.lblExpectedDeliveryDate = new System.Windows.Forms.Label();
            this.lblAlert = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOtherShipmentInformation = new System.Windows.Forms.Label();
            this.richTxtOtherShipmentInformation = new System.Windows.Forms.RichTextBox();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.btnViewBPAItem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBPA)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvBPA
            // 
            this.dgvBPA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBPA.Location = new System.Drawing.Point(361, 270);
            this.dgvBPA.Name = "dgvBPA";
            this.dgvBPA.RowTemplate.Height = 24;
            this.dgvBPA.Size = new System.Drawing.Size(635, 332);
            this.dgvBPA.TabIndex = 0;
            this.dgvBPA.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBPA_CellDoubleClick);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(818, 611);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(921, 611);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnViewRequestItem
            // 
            this.btnViewRequestItem.Location = new System.Drawing.Point(83, 65);
            this.btnViewRequestItem.Name = "btnViewRequestItem";
            this.btnViewRequestItem.Size = new System.Drawing.Size(146, 23);
            this.btnViewRequestItem.TabIndex = 4;
            this.btnViewRequestItem.Text = "View Requested items";
            this.btnViewRequestItem.UseVisualStyleBackColor = true;
            this.btnViewRequestItem.Click += new System.EventHandler(this.btnViewRequestItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "BPAID";
            // 
            // txtBPAID
            // 
            this.txtBPAID.Location = new System.Drawing.Point(96, 321);
            this.txtBPAID.Name = "txtBPAID";
            this.txtBPAID.Size = new System.Drawing.Size(221, 22);
            this.txtBPAID.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 384);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ship to";
            // 
            // txtShipAddress
            // 
            this.txtShipAddress.Location = new System.Drawing.Point(95, 381);
            this.txtShipAddress.Name = "txtShipAddress";
            this.txtShipAddress.Size = new System.Drawing.Size(222, 22);
            this.txtShipAddress.TabIndex = 8;
            // 
            // btnSelectAddress
            // 
            this.btnSelectAddress.Location = new System.Drawing.Point(289, 381);
            this.btnSelectAddress.Name = "btnSelectAddress";
            this.btnSelectAddress.Size = new System.Drawing.Size(28, 23);
            this.btnSelectAddress.TabIndex = 9;
            this.btnSelectAddress.Text = "...";
            this.btnSelectAddress.UseVisualStyleBackColor = true;
            this.btnSelectAddress.Click += new System.EventHandler(this.btnSelectAddress_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(96, 443);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(221, 22);
            this.txtAmount.TabIndex = 13;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(11, 446);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(76, 12);
            this.lblAmount.TabIndex = 12;
            this.lblAmount.Text = "Actual Amount";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(96, 509);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(221, 22);
            this.txtQuantity.TabIndex = 15;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(11, 512);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(76, 12);
            this.lblQuantity.TabIndex = 14;
            this.lblQuantity.Text = "Actual quantity";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(83, 99);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(222, 96);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Remark";
            // 
            // dtExpectedDeliveryDate
            // 
            this.dtExpectedDeliveryDate.Enabled = false;
            this.dtExpectedDeliveryDate.Location = new System.Drawing.Point(96, 276);
            this.dtExpectedDeliveryDate.Name = "dtExpectedDeliveryDate";
            this.dtExpectedDeliveryDate.Size = new System.Drawing.Size(222, 22);
            this.dtExpectedDeliveryDate.TabIndex = 18;
            // 
            // lblExpectedDeliveryDate
            // 
            this.lblExpectedDeliveryDate.Location = new System.Drawing.Point(6, 270);
            this.lblExpectedDeliveryDate.Name = "lblExpectedDeliveryDate";
            this.lblExpectedDeliveryDate.Size = new System.Drawing.Size(81, 28);
            this.lblExpectedDeliveryDate.TabIndex = 19;
            this.lblExpectedDeliveryDate.Text = "Expected Delivery Date";
            // 
            // lblAlert
            // 
            this.lblAlert.AutoSize = true;
            this.lblAlert.ForeColor = System.Drawing.Color.Red;
            this.lblAlert.Location = new System.Drawing.Point(94, 549);
            this.lblAlert.Name = "lblAlert";
            this.lblAlert.Size = new System.Drawing.Size(0, 12);
            this.lblAlert.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "RequestID :";
            // 
            // lblOtherShipmentInformation
            // 
            this.lblOtherShipmentInformation.Location = new System.Drawing.Point(8, 546);
            this.lblOtherShipmentInformation.Name = "lblOtherShipmentInformation";
            this.lblOtherShipmentInformation.Size = new System.Drawing.Size(78, 38);
            this.lblOtherShipmentInformation.TabIndex = 23;
            this.lblOtherShipmentInformation.Text = "Other Shipment Information";
            // 
            // richTxtOtherShipmentInformation
            // 
            this.richTxtOtherShipmentInformation.Location = new System.Drawing.Point(95, 546);
            this.richTxtOtherShipmentInformation.Name = "richTxtOtherShipmentInformation";
            this.richTxtOtherShipmentInformation.Size = new System.Drawing.Size(222, 56);
            this.richTxtOtherShipmentInformation.TabIndex = 22;
            this.richTxtOtherShipmentInformation.Text = "";
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(79, 37);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Size = new System.Drawing.Size(207, 22);
            this.txtRequestID.TabIndex = 24;
            // 
            // btnViewBPAItem
            // 
            this.btnViewBPAItem.Location = new System.Drawing.Point(691, 611);
            this.btnViewBPAItem.Name = "btnViewBPAItem";
            this.btnViewBPAItem.Size = new System.Drawing.Size(103, 23);
            this.btnViewBPAItem.TabIndex = 25;
            this.btnViewBPAItem.Text = "View BPA items";
            this.btnViewBPAItem.UseVisualStyleBackColor = true;
            this.btnViewBPAItem.Click += new System.EventHandler(this.btnViewBPAItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.btnViewRequestItem);
            this.groupBox1.Controls.Add(this.txtRequestID);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 216);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MakeBlanketReleaseUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 637);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnViewBPAItem);
            this.Controls.Add(this.lblOtherShipmentInformation);
            this.Controls.Add(this.richTxtOtherShipmentInformation);
            this.Controls.Add(this.lblAlert);
            this.Controls.Add(this.lblExpectedDeliveryDate);
            this.Controls.Add(this.dtExpectedDeliveryDate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.lblAmount);
            this.Controls.Add(this.btnSelectAddress);
            this.Controls.Add(this.txtShipAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBPAID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvBPA);
            this.Name = "MakeBlanketReleaseUI";
            this.Text = "MakeBlanketReleaseUI";
            this.Load += new System.EventHandler(this.MakeBlanketReleaseUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBPA)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBPA;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnViewRequestItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBPAID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtShipAddress;
        private System.Windows.Forms.Button btnSelectAddress;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtExpectedDeliveryDate;
        private System.Windows.Forms.Label lblExpectedDeliveryDate;
        private System.Windows.Forms.Label lblAlert;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOtherShipmentInformation;
        private System.Windows.Forms.RichTextBox richTxtOtherShipmentInformation;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.Button btnViewBPAItem;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}