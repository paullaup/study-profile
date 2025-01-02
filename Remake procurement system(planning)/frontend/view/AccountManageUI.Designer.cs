namespace frontend.view
{
    partial class AccountManageUI
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
            this.AccountsGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // AccountsGridView
            // 
            this.AccountsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountsGridView.Location = new System.Drawing.Point(312, 57);
            this.AccountsGridView.Name = "AccountsGridView";
            this.AccountsGridView.RowTemplate.Height = 24;
            this.AccountsGridView.Size = new System.Drawing.Size(448, 306);
            this.AccountsGridView.TabIndex = 0;
            // 
            // AccountManageUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AccountsGridView);
            this.Name = "AccountManageUI";
            this.Text = "AccountManageUI";
            this.Load += new System.EventHandler(this.AccountManageUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountsGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView AccountsGridView;
    }
}