namespace ProcurementSystem
{
    partial class MapRequestUI
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
            this.dgvRequest = new System.Windows.Forms.DataGridView();
            this.dgvMapType = new System.Windows.Forms.DataGridView();
            this.lblQueue = new System.Windows.Forms.Label();
            this.gbMappingType = new System.Windows.Forms.GroupBox();
            this.rbPPO = new System.Windows.Forms.RadioButton();
            this.rbCPA = new System.Windows.Forms.RadioButton();
            this.rbBPA = new System.Windows.Forms.RadioButton();
            this.rbWarehouse = new System.Windows.Forms.RadioButton();
            this.btnAutoMap = new System.Windows.Forms.Button();
            this.btnBPAMap = new System.Windows.Forms.Button();
            this.btnInventoryMap = new System.Windows.Forms.Button();
            this.btnCPAMap = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnVIewRequestItem = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtRequestID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapType)).BeginInit();
            this.gbMappingType.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRequest
            // 
            this.dgvRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRequest.Location = new System.Drawing.Point(50, 22);
            this.dgvRequest.Name = "dgvRequest";
            this.dgvRequest.RowTemplate.Height = 24;
            this.dgvRequest.Size = new System.Drawing.Size(895, 247);
            this.dgvRequest.TabIndex = 0;
            this.dgvRequest.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRequest_CellDoubleClick);
            this.dgvRequest.SelectionChanged += new System.EventHandler(this.dgvRequest_SelectionChanged);
            // 
            // dgvMapType
            // 
            this.dgvMapType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMapType.Location = new System.Drawing.Point(392, 335);
            this.dgvMapType.Name = "dgvMapType";
            this.dgvMapType.RowTemplate.Height = 24;
            this.dgvMapType.Size = new System.Drawing.Size(542, 247);
            this.dgvMapType.TabIndex = 1;
            this.dgvMapType.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMapType_CellDoubleClick);
            // 
            // lblQueue
            // 
            this.lblQueue.AutoSize = true;
            this.lblQueue.Location = new System.Drawing.Point(48, 7);
            this.lblQueue.Name = "lblQueue";
            this.lblQueue.Size = new System.Drawing.Size(35, 12);
            this.lblQueue.TabIndex = 2;
            this.lblQueue.Text = "Queue";
            // 
            // gbMappingType
            // 
            this.gbMappingType.Controls.Add(this.rbPPO);
            this.gbMappingType.Controls.Add(this.rbCPA);
            this.gbMappingType.Controls.Add(this.rbBPA);
            this.gbMappingType.Controls.Add(this.rbWarehouse);
            this.gbMappingType.Location = new System.Drawing.Point(39, 335);
            this.gbMappingType.Name = "gbMappingType";
            this.gbMappingType.Size = new System.Drawing.Size(328, 187);
            this.gbMappingType.TabIndex = 3;
            this.gbMappingType.TabStop = false;
            this.gbMappingType.Text = "Mapping Type";
            // 
            // rbPPO
            // 
            this.rbPPO.AutoSize = true;
            this.rbPPO.Location = new System.Drawing.Point(6, 145);
            this.rbPPO.Name = "rbPPO";
            this.rbPPO.Size = new System.Drawing.Size(97, 16);
            this.rbPPO.TabIndex = 3;
            this.rbPPO.TabStop = true;
            this.rbPPO.Text = "schedule release";
            this.rbPPO.UseVisualStyleBackColor = true;
            this.rbPPO.CheckedChanged += new System.EventHandler(this.rbPPO_CheckedChanged);
            // 
            // rbCPA
            // 
            this.rbCPA.AutoSize = true;
            this.rbCPA.Location = new System.Drawing.Point(6, 107);
            this.rbCPA.Name = "rbCPA";
            this.rbCPA.Size = new System.Drawing.Size(158, 16);
            this.rbCPA.TabIndex = 2;
            this.rbCPA.TabStop = true;
            this.rbCPA.Text = "Contract purchase agreement";
            this.rbCPA.UseVisualStyleBackColor = true;
            this.rbCPA.CheckedChanged += new System.EventHandler(this.rbCPA_CheckedChanged);
            // 
            // rbBPA
            // 
            this.rbBPA.AutoSize = true;
            this.rbBPA.Location = new System.Drawing.Point(6, 69);
            this.rbBPA.Name = "rbBPA";
            this.rbBPA.Size = new System.Drawing.Size(154, 16);
            this.rbBPA.TabIndex = 1;
            this.rbBPA.TabStop = true;
            this.rbBPA.Text = "Blanket purchase agreement";
            this.rbBPA.UseVisualStyleBackColor = true;
            this.rbBPA.CheckedChanged += new System.EventHandler(this.rbBPA_CheckedChanged);
            // 
            // rbWarehouse
            // 
            this.rbWarehouse.AutoSize = true;
            this.rbWarehouse.Location = new System.Drawing.Point(6, 34);
            this.rbWarehouse.Name = "rbWarehouse";
            this.rbWarehouse.Size = new System.Drawing.Size(123, 16);
            this.rbWarehouse.TabIndex = 0;
            this.rbWarehouse.TabStop = true;
            this.rbWarehouse.Text = "Warehouse inventory";
            this.rbWarehouse.UseVisualStyleBackColor = true;
            this.rbWarehouse.CheckedChanged += new System.EventHandler(this.rbWarehouse_CheckedChanged);
            // 
            // btnAutoMap
            // 
            this.btnAutoMap.Location = new System.Drawing.Point(834, 625);
            this.btnAutoMap.Name = "btnAutoMap";
            this.btnAutoMap.Size = new System.Drawing.Size(100, 48);
            this.btnAutoMap.TabIndex = 4;
            this.btnAutoMap.Text = "Map automatically";
            this.btnAutoMap.UseVisualStyleBackColor = true;
            // 
            // btnBPAMap
            // 
            this.btnBPAMap.Location = new System.Drawing.Point(516, 625);
            this.btnBPAMap.Name = "btnBPAMap";
            this.btnBPAMap.Size = new System.Drawing.Size(100, 48);
            this.btnBPAMap.TabIndex = 5;
            this.btnBPAMap.Text = "Map selected request to blanket purchase agreement";
            this.btnBPAMap.UseVisualStyleBackColor = true;
            this.btnBPAMap.Click += new System.EventHandler(this.btnBPAMap_Click);
            // 
            // btnInventoryMap
            // 
            this.btnInventoryMap.Location = new System.Drawing.Point(410, 625);
            this.btnInventoryMap.Name = "btnInventoryMap";
            this.btnInventoryMap.Size = new System.Drawing.Size(100, 48);
            this.btnInventoryMap.TabIndex = 6;
            this.btnInventoryMap.Text = "Map selected request to warehouse inventory";
            this.btnInventoryMap.UseVisualStyleBackColor = true;
            this.btnInventoryMap.Click += new System.EventHandler(this.btnInventoryMap_Click);
            // 
            // btnCPAMap
            // 
            this.btnCPAMap.Location = new System.Drawing.Point(622, 625);
            this.btnCPAMap.Name = "btnCPAMap";
            this.btnCPAMap.Size = new System.Drawing.Size(100, 48);
            this.btnCPAMap.TabIndex = 7;
            this.btnCPAMap.Text = "Map selected request to contract purchase agreement";
            this.btnCPAMap.UseVisualStyleBackColor = true;
            this.btnCPAMap.Click += new System.EventHandler(this.btnCPAMap_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(728, 625);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 48);
            this.button2.TabIndex = 8;
            this.button2.Text = "Map selected request to Planned purchase order";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnVIewRequestItem
            // 
            this.btnVIewRequestItem.Location = new System.Drawing.Point(275, 285);
            this.btnVIewRequestItem.Name = "btnVIewRequestItem";
            this.btnVIewRequestItem.Size = new System.Drawing.Size(148, 22);
            this.btnVIewRequestItem.TabIndex = 9;
            this.btnVIewRequestItem.Text = "View selected request items";
            this.btnVIewRequestItem.UseVisualStyleBackColor = true;
            this.btnVIewRequestItem.Click += new System.EventHandler(this.btnVIewRequestItem_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(786, 588);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 22);
            this.button3.TabIndex = 10;
            this.button3.Text = "View selected request items";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtRequestID
            // 
            this.txtRequestID.Location = new System.Drawing.Point(106, 282);
            this.txtRequestID.Name = "txtRequestID";
            this.txtRequestID.Size = new System.Drawing.Size(163, 22);
            this.txtRequestID.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "requestID";
            // 
            // MapRequestUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 692);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtRequestID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnVIewRequestItem);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnCPAMap);
            this.Controls.Add(this.btnInventoryMap);
            this.Controls.Add(this.btnBPAMap);
            this.Controls.Add(this.btnAutoMap);
            this.Controls.Add(this.gbMappingType);
            this.Controls.Add(this.lblQueue);
            this.Controls.Add(this.dgvMapType);
            this.Controls.Add(this.dgvRequest);
            this.Name = "MapRequestUI";
            this.Text = "MapRequestUI";
            this.Load += new System.EventHandler(this.MapRequestUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMapType)).EndInit();
            this.gbMappingType.ResumeLayout(false);
            this.gbMappingType.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRequest;
        private System.Windows.Forms.DataGridView dgvMapType;
        private System.Windows.Forms.Label lblQueue;
        private System.Windows.Forms.GroupBox gbMappingType;
        private System.Windows.Forms.RadioButton rbWarehouse;
        private System.Windows.Forms.RadioButton rbPPO;
        private System.Windows.Forms.RadioButton rbCPA;
        private System.Windows.Forms.RadioButton rbBPA;
        private System.Windows.Forms.Button btnAutoMap;
        private System.Windows.Forms.Button btnBPAMap;
        private System.Windows.Forms.Button btnInventoryMap;
        private System.Windows.Forms.Button btnCPAMap;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnVIewRequestItem;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txtRequestID;
        private System.Windows.Forms.Label label1;
    }
}