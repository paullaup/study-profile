namespace ProcurementSystem
{
    partial class MakeDespatchInstructionUI
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
            this.lblRequestID = new System.Windows.Forms.Label();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.btnSearchRequestItem = new System.Windows.Forms.Button();
            this.dgvWarehouseInventory = new System.Windows.Forms.DataGridView();
            this.dgvSelectedInventory = new System.Windows.Forms.DataGridView();
            this.lblItemID = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.richTxtInstructionRemark = new System.Windows.Forms.RichTextBox();
            this.lblInstrucationRemark = new System.Windows.Forms.Label();
            this.lblRemark = new System.Windows.Forms.Label();
            this.richTxtRequestRemark = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouseInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedInventory)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblRequestID
            // 
            this.lblRequestID.AutoSize = true;
            this.lblRequestID.Location = new System.Drawing.Point(44, 24);
            this.lblRequestID.Name = "lblRequestID";
            this.lblRequestID.Size = new System.Drawing.Size(59, 12);
            this.lblRequestID.TabIndex = 0;
            this.lblRequestID.Text = "requestID : ";
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(109, 21);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Size = new System.Drawing.Size(119, 22);
            this.txtRequestID.TabIndex = 1;
            // 
            // btnSearchRequestItem
            // 
            this.btnSearchRequestItem.Location = new System.Drawing.Point(109, 59);
            this.btnSearchRequestItem.Name = "btnSearchRequestItem";
            this.btnSearchRequestItem.Size = new System.Drawing.Size(119, 23);
            this.btnSearchRequestItem.TabIndex = 2;
            this.btnSearchRequestItem.Text = "View Request Items";
            this.btnSearchRequestItem.UseVisualStyleBackColor = true;
            this.btnSearchRequestItem.Click += new System.EventHandler(this.btnSearchRequestItem_Click);
            // 
            // dgvWarehouseInventory
            // 
            this.dgvWarehouseInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWarehouseInventory.Location = new System.Drawing.Point(402, 225);
            this.dgvWarehouseInventory.Name = "dgvWarehouseInventory";
            this.dgvWarehouseInventory.RowTemplate.Height = 24;
            this.dgvWarehouseInventory.Size = new System.Drawing.Size(564, 272);
            this.dgvWarehouseInventory.TabIndex = 3;
            // 
            // dgvSelectedInventory
            // 
            this.dgvSelectedInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSelectedInventory.Location = new System.Drawing.Point(22, 533);
            this.dgvSelectedInventory.Name = "dgvSelectedInventory";
            this.dgvSelectedInventory.RowTemplate.Height = 24;
            this.dgvSelectedInventory.Size = new System.Drawing.Size(946, 103);
            this.dgvSelectedInventory.TabIndex = 4;
            // 
            // lblItemID
            // 
            this.lblItemID.AutoSize = true;
            this.lblItemID.Location = new System.Drawing.Point(60, 48);
            this.lblItemID.Name = "lblItemID";
            this.lblItemID.Size = new System.Drawing.Size(43, 12);
            this.lblItemID.TabIndex = 5;
            this.lblItemID.Text = "itemID :";
            // 
            // txtItemID
            // 
            this.txtItemID.Location = new System.Drawing.Point(109, 41);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(214, 22);
            this.txtItemID.TabIndex = 6;
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(49, 89);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(54, 12);
            this.lblQuantity.TabIndex = 7;
            this.lblQuantity.Text = "Quantity : ";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(109, 86);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(214, 22);
            this.txtQuantity.TabIndex = 8;
            // 
            // richTxtInstructionRemark
            // 
            this.richTxtInstructionRemark.Location = new System.Drawing.Point(109, 135);
            this.richTxtInstructionRemark.Name = "richTxtInstructionRemark";
            this.richTxtInstructionRemark.Size = new System.Drawing.Size(214, 96);
            this.richTxtInstructionRemark.TabIndex = 9;
            this.richTxtInstructionRemark.Text = "";
            // 
            // lblInstrucationRemark
            // 
            this.lblInstrucationRemark.AutoSize = true;
            this.lblInstrucationRemark.Location = new System.Drawing.Point(44, 135);
            this.lblInstrucationRemark.Name = "lblInstrucationRemark";
            this.lblInstrucationRemark.Size = new System.Drawing.Size(51, 12);
            this.lblInstrucationRemark.TabIndex = 10;
            this.lblInstrucationRemark.Text = "Remark : ";
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(44, 91);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(51, 12);
            this.lblRemark.TabIndex = 12;
            this.lblRemark.Text = "Remark : ";
            // 
            // richTxtRequestRemark
            // 
            this.richTxtRequestRemark.Location = new System.Drawing.Point(109, 88);
            this.richTxtRequestRemark.Name = "richTxtRequestRemark";
            this.richTxtRequestRemark.Size = new System.Drawing.Size(214, 88);
            this.richTxtRequestRemark.TabIndex = 11;
            this.richTxtRequestRemark.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRequestID);
            this.groupBox1.Controls.Add(this.lblRemark);
            this.groupBox1.Controls.Add(this.lblRequestID);
            this.groupBox1.Controls.Add(this.richTxtRequestRemark);
            this.groupBox1.Controls.Add(this.btnSearchRequestItem);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(356, 193);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRemove);
            this.groupBox2.Controls.Add(this.btnAdd);
            this.groupBox2.Controls.Add(this.txtItemID);
            this.groupBox2.Controls.Add(this.lblItemID);
            this.groupBox2.Controls.Add(this.lblInstrucationRemark);
            this.groupBox2.Controls.Add(this.lblQuantity);
            this.groupBox2.Controls.Add(this.richTxtInstructionRemark);
            this.groupBox2.Controls.Add(this.txtQuantity);
            this.groupBox2.Location = new System.Drawing.Point(22, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(356, 274);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Despatch Instruction";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(167, 237);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 12;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(248, 237);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(845, 659);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(121, 23);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(718, 659);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "Added item";
            // 
            // MakeDespatchInstructionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 695);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSelectedInventory);
            this.Controls.Add(this.dgvWarehouseInventory);
            this.Name = "MakeDespatchInstructionUI";
            this.Text = "MakeDespatchInstructionUI";
            this.Load += new System.EventHandler(this.MakeDespatchInstructionUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWarehouseInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSelectedInventory)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRequestID;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.Button btnSearchRequestItem;
        private System.Windows.Forms.DataGridView dgvWarehouseInventory;
        private System.Windows.Forms.DataGridView dgvSelectedInventory;
        private System.Windows.Forms.Label lblItemID;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.RichTextBox richTxtInstructionRemark;
        private System.Windows.Forms.Label lblInstrucationRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.RichTextBox richTxtRequestRemark;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
    }
}