namespace SchoolManagement
{
    partial class StaffDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StaffDetailDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalaryColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExperienceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BankNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountNumberColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StaffDetailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // StaffDetailDataGridView
            // 
            this.StaffDetailDataGridView.AllowUserToResizeColumns = false;
            this.StaffDetailDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.StaffDetailDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StaffDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StaffDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.FullNameColumn,
            this.GenderColumn,
            this.SalaryColumn,
            this.ExperienceColumn,
            this.AddressColumn,
            this.BankNameColumn,
            this.AccountNumberColumn});
            this.StaffDetailDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StaffDetailDataGridView.Location = new System.Drawing.Point(2, 186);
            this.StaffDetailDataGridView.Name = "StaffDetailDataGridView";
            this.StaffDetailDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StaffDetailDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.StaffDetailDataGridView.Size = new System.Drawing.Size(579, 230);
            this.StaffDetailDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.StaffDetailDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.StaffDetailDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.StaffDetailDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.StaffDetailDataGridView.TabIndex = 30;
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // FullNameColumn
            // 
            this.FullNameColumn.HeaderText = "Full Name";
            this.FullNameColumn.Name = "FullNameColumn";
            this.FullNameColumn.ReadOnly = true;
            // 
            // GenderColumn
            // 
            this.GenderColumn.HeaderText = "Gender";
            this.GenderColumn.Name = "GenderColumn";
            this.GenderColumn.ReadOnly = true;
            // 
            // SalaryColumn
            // 
            this.SalaryColumn.HeaderText = "Salary";
            this.SalaryColumn.Name = "SalaryColumn";
            this.SalaryColumn.ReadOnly = true;
            // 
            // ExperienceColumn
            // 
            this.ExperienceColumn.HeaderText = "Experience";
            this.ExperienceColumn.Name = "ExperienceColumn";
            this.ExperienceColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            // 
            // BankNameColumn
            // 
            this.BankNameColumn.HeaderText = "Bank Name";
            this.BankNameColumn.Name = "BankNameColumn";
            this.BankNameColumn.ReadOnly = true;
            // 
            // AccountNumberColumn
            // 
            this.AccountNumberColumn.HeaderText = "Account Number";
            this.AccountNumberColumn.Name = "AccountNumberColumn";
            this.AccountNumberColumn.ReadOnly = true;
            // 
            // StaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 478);
            this.Controls.Add(this.StaffDetailDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffDetails";
            this.Text = "StaffDetails";
            ((System.ComponentModel.ISupportInitialize)(this.StaffDetailDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView StaffDetailDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalaryColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExperienceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BankNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccountNumberColumn;
    }
}