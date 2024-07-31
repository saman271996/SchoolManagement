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
            this.SchoolStaffDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GenderColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddressColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DesignationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.SchoolStaffDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SchoolStaffDataGridView
            // 
            this.SchoolStaffDataGridView.AllowUserToResizeColumns = false;
            this.SchoolStaffDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.SchoolStaffDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SchoolStaffDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SchoolStaffDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.NameColumn,
            this.GenderColumn,
            this.AddressColumn,
            this.ClassNameColumn,
            this.SubjectNameColumn,
            this.DesignationColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.SchoolStaffDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SchoolStaffDataGridView.Location = new System.Drawing.Point(2, 198);
            this.SchoolStaffDataGridView.Name = "SchoolStaffDataGridView";
            this.SchoolStaffDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.SchoolStaffDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.SchoolStaffDataGridView.Size = new System.Drawing.Size(579, 230);
            this.SchoolStaffDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.SchoolStaffDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.SchoolStaffDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.SchoolStaffDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.SchoolStaffDataGridView.TabIndex = 7;
            this.SchoolStaffDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SchoolStaffDataGridView_CellClick);
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // NameColumn
            // 
            this.NameColumn.DataPropertyName = "FullName";
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            // 
            // GenderColumn
            // 
            this.GenderColumn.DataPropertyName = "Gender";
            this.GenderColumn.HeaderText = "Gender";
            this.GenderColumn.Name = "GenderColumn";
            this.GenderColumn.ReadOnly = true;
            // 
            // AddressColumn
            // 
            this.AddressColumn.DataPropertyName = "Address";
            this.AddressColumn.HeaderText = "Address";
            this.AddressColumn.Name = "AddressColumn";
            this.AddressColumn.ReadOnly = true;
            // 
            // ClassNameColumn
            // 
            this.ClassNameColumn.DataPropertyName = "ClassId";
            this.ClassNameColumn.HeaderText = "Class";
            this.ClassNameColumn.Name = "ClassNameColumn";
            this.ClassNameColumn.ReadOnly = true;
            // 
            // SubjectNameColumn
            // 
            this.SubjectNameColumn.DataPropertyName = "SubjectId";
            this.SubjectNameColumn.HeaderText = "Subject";
            this.SubjectNameColumn.Name = "SubjectNameColumn";
            this.SubjectNameColumn.ReadOnly = true;
            // 
            // DesignationColumn
            // 
            this.DesignationColumn.DataPropertyName = "Designation";
            this.DesignationColumn.HeaderText = "Designation";
            this.DesignationColumn.Name = "DesignationColumn";
            this.DesignationColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "Edit";
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            this.EditColumn.Text = "Edit";
            this.EditColumn.UseColumnTextForButtonValue = true;
            // 
            // DeleteColumn
            // 
            this.DeleteColumn.HeaderText = "Delete";
            this.DeleteColumn.Name = "DeleteColumn";
            this.DeleteColumn.ReadOnly = true;
            this.DeleteColumn.Text = "Delete";
            this.DeleteColumn.UseColumnTextForButtonValue = true;
            // 
            // StaffDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 478);
            this.Controls.Add(this.SchoolStaffDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StaffDetails";
            this.Text = "StaffDetails";
            this.Load += new System.EventHandler(this.StaffDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SchoolStaffDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView SchoolStaffDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GenderColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn AddressColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DesignationColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}