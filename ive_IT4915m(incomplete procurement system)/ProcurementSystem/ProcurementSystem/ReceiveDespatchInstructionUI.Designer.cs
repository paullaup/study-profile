namespace ProcurementSystem
{
    partial class ReceiveDespatchInstructionUI
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
            this.dgvInstuctionQueue = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInstructionID = new System.Windows.Forms.TextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.btnReceive = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTxtNoteRemark = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnMapInstruction = new System.Windows.Forms.Button();
            this.txtDeliveryNoteNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDeliveryNote = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.btnViewDeliveryNote = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.richTxtOtherShipmentInfo = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.richTxtAddress = new System.Windows.Forms.RichTextBox();
            this.btnViewDespatchInstructionItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstuctionQueue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryNote)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInstuctionQueue
            // 
            this.dgvInstuctionQueue.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInstuctionQueue.Location = new System.Drawing.Point(33, 43);
            this.dgvInstuctionQueue.Name = "dgvInstuctionQueue";
            this.dgvInstuctionQueue.RowTemplate.Height = 24;
            this.dgvInstuctionQueue.Size = new System.Drawing.Size(944, 150);
            this.dgvInstuctionQueue.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Despatch instruction queue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "InstructionID :";
            // 
            // txtInstructionID
            // 
            this.txtInstructionID.Location = new System.Drawing.Point(121, 217);
            this.txtInstructionID.Name = "txtInstructionID";
            this.txtInstructionID.Size = new System.Drawing.Size(207, 22);
            this.txtInstructionID.TabIndex = 3;
            // 
            // dgvInventory
            // 
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.Location = new System.Drawing.Point(390, 229);
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(587, 126);
            this.dgvInventory.TabIndex = 4;
            // 
            // btnReceive
            // 
            this.btnReceive.Location = new System.Drawing.Point(836, 596);
            this.btnReceive.Name = "btnReceive";
            this.btnReceive.Size = new System.Drawing.Size(141, 38);
            this.btnReceive.TabIndex = 7;
            this.btnReceive.Text = "Map instruction to new generate Delivery Note";
            this.btnReceive.UseVisualStyleBackColor = true;
            this.btnReceive.Click += new System.EventHandler(this.btnReceive_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "Warehosue Inventory";
            // 
            // richTxtNoteRemark
            // 
            this.richTxtNoteRemark.Location = new System.Drawing.Point(121, 402);
            this.richTxtNoteRemark.Name = "richTxtNoteRemark";
            this.richTxtNoteRemark.Size = new System.Drawing.Size(207, 43);
            this.richTxtNoteRemark.TabIndex = 9;
            this.richTxtNoteRemark.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delivery Note remark :";
            // 
            // btnMapInstruction
            // 
            this.btnMapInstruction.Location = new System.Drawing.Point(665, 596);
            this.btnMapInstruction.Name = "btnMapInstruction";
            this.btnMapInstruction.Size = new System.Drawing.Size(141, 38);
            this.btnMapInstruction.TabIndex = 11;
            this.btnMapInstruction.Text = "Map instruction to exsiting Delivery Note";
            this.btnMapInstruction.UseVisualStyleBackColor = true;
            this.btnMapInstruction.Click += new System.EventHandler(this.btnMapInstruction_Click);
            // 
            // txtDeliveryNoteNumber
            // 
            this.txtDeliveryNoteNumber.Location = new System.Drawing.Point(121, 340);
            this.txtDeliveryNoteNumber.Name = "txtDeliveryNoteNumber";
            this.txtDeliveryNoteNumber.Size = new System.Drawing.Size(207, 22);
            this.txtDeliveryNoteNumber.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 343);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 12);
            this.label6.TabIndex = 12;
            this.label6.Text = "Delivery Note Number:";
            // 
            // dgvDeliveryNote
            // 
            this.dgvDeliveryNote.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDeliveryNote.Location = new System.Drawing.Point(390, 423);
            this.dgvDeliveryNote.Name = "dgvDeliveryNote";
            this.dgvDeliveryNote.RowTemplate.Height = 24;
            this.dgvDeliveryNote.Size = new System.Drawing.Size(587, 126);
            this.dgvDeliveryNote.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 408);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "Delivery Note";
            // 
            // btnViewDeliveryNote
            // 
            this.btnViewDeliveryNote.Location = new System.Drawing.Point(121, 368);
            this.btnViewDeliveryNote.Name = "btnViewDeliveryNote";
            this.btnViewDeliveryNote.Size = new System.Drawing.Size(121, 28);
            this.btnViewDeliveryNote.TabIndex = 16;
            this.btnViewDeliveryNote.Text = "View Delivery Note number";
            this.btnViewDeliveryNote.UseVisualStyleBackColor = true;
            this.btnViewDeliveryNote.Click += new System.EventHandler(this.btnViewDeliveryNote_Click);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(33, 541);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 28);
            this.label8.TabIndex = 18;
            this.label8.Text = "Other shipment information :";
            // 
            // richTxtOtherShipmentInfo
            // 
            this.richTxtOtherShipmentInfo.Location = new System.Drawing.Point(121, 538);
            this.richTxtOtherShipmentInfo.Name = "richTxtOtherShipmentInfo";
            this.richTxtOtherShipmentInfo.Size = new System.Drawing.Size(207, 43);
            this.richTxtOtherShipmentInfo.TabIndex = 17;
            this.richTxtOtherShipmentInfo.Text = "";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(71, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 28);
            this.label9.TabIndex = 20;
            this.label9.Text = "Ship to :";
            // 
            // richTxtAddress
            // 
            this.richTxtAddress.Location = new System.Drawing.Point(121, 465);
            this.richTxtAddress.Name = "richTxtAddress";
            this.richTxtAddress.Size = new System.Drawing.Size(207, 43);
            this.richTxtAddress.TabIndex = 19;
            this.richTxtAddress.Text = "";
            // 
            // btnViewDespatchInstructionItem
            // 
            this.btnViewDespatchInstructionItem.Location = new System.Drawing.Point(121, 245);
            this.btnViewDespatchInstructionItem.Name = "btnViewDespatchInstructionItem";
            this.btnViewDespatchInstructionItem.Size = new System.Drawing.Size(163, 27);
            this.btnViewDespatchInstructionItem.TabIndex = 21;
            this.btnViewDespatchInstructionItem.Text = "View Despatch Instruction items";
            this.btnViewDespatchInstructionItem.UseVisualStyleBackColor = true;
            this.btnViewDespatchInstructionItem.Click += new System.EventHandler(this.btnViewDespatchInstructionItem_Click);
            // 
            // ReceiveDespatchInstructionUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 646);
            this.Controls.Add(this.btnViewDespatchInstructionItem);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.richTxtAddress);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTxtOtherShipmentInfo);
            this.Controls.Add(this.btnViewDeliveryNote);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvDeliveryNote);
            this.Controls.Add(this.txtDeliveryNoteNumber);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnMapInstruction);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTxtNoteRemark);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnReceive);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.txtInstructionID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInstuctionQueue);
            this.Name = "ReceiveDespatchInstructionUI";
            this.Text = "ReceiveDespatchInstructionUI";
            this.Load += new System.EventHandler(this.ReceiveDespatchInstructionUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvInstuctionQueue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDeliveryNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInstuctionQueue;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInstructionID;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.Button btnReceive;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTxtNoteRemark;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnMapInstruction;
        private System.Windows.Forms.TextBox txtDeliveryNoteNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDeliveryNote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnViewDeliveryNote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTxtOtherShipmentInfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox richTxtAddress;
        private System.Windows.Forms.Button btnViewDespatchInstructionItem;
    }
}