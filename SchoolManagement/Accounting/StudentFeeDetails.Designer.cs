namespace SchoolManagement.Accounting
{
    partial class StudentFeeDetails
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.StuFeeDetailsDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SchoolIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearlyFeeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            ((System.ComponentModel.ISupportInitialize)(this.StuFeeDetailsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StuFeeDetailsDataGridView
            // 
            this.StuFeeDetailsDataGridView.AllowDrop = true;
            this.StuFeeDetailsDataGridView.AllowUserToAddRows = false;
            this.StuFeeDetailsDataGridView.AllowUserToResizeColumns = false;
            this.StuFeeDetailsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.StuFeeDetailsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StuFeeDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuFeeDetailsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.SchoolIdColumn,
            this.ClassNameColumn,
            this.YearlyFeeColumn,
            this.InstallmentColumn,
            this.EditColumn});
            this.StuFeeDetailsDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StuFeeDetailsDataGridView.Location = new System.Drawing.Point(12, 110);
            this.StuFeeDetailsDataGridView.Name = "StuFeeDetailsDataGridView";
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StuFeeDetailsDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.StuFeeDetailsDataGridView.Size = new System.Drawing.Size(531, 289);
            this.StuFeeDetailsDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.StuFeeDetailsDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.StuFeeDetailsDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.StuFeeDetailsDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.StuFeeDetailsDataGridView.TabIndex = 51;
            this.StuFeeDetailsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StuFeeDetailsDataGridView_CellClick);
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.Visible = false;
            // 
            // SchoolIdColumn
            // 
            this.SchoolIdColumn.DataPropertyName = "SchoolId";
            this.SchoolIdColumn.HeaderText = "SchoolId";
            this.SchoolIdColumn.Name = "SchoolIdColumn";
            this.SchoolIdColumn.Visible = false;
            // 
            // ClassNameColumn
            // 
            this.ClassNameColumn.DataPropertyName = "ClassName";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ClassNameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClassNameColumn.HeaderText = "ClassName";
            this.ClassNameColumn.Name = "ClassNameColumn";
            this.ClassNameColumn.Width = 130;
            // 
            // YearlyFeeColumn
            // 
            this.YearlyFeeColumn.DataPropertyName = "YearFee";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.YearlyFeeColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.YearlyFeeColumn.HeaderText = "YearlyFee";
            this.YearlyFeeColumn.Name = "YearlyFeeColumn";
            this.YearlyFeeColumn.Width = 130;
            // 
            // InstallmentColumn
            // 
            this.InstallmentColumn.DataPropertyName = "Installment";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.InstallmentColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.InstallmentColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.InstallmentColumn.HeaderText = "Installment";
            this.InstallmentColumn.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.InstallmentColumn.Name = "InstallmentColumn";
            this.InstallmentColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InstallmentColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.InstallmentColumn.Width = 130;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "Edit";
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.Text = "Edit";
            this.EditColumn.UseColumnTextForButtonValue = true;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 23);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(278, 29);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Student Class Fee Details";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(12, 22);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(531, 72);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 52;
            // 
            // StudentFeeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(557, 422);
            this.Controls.Add(this.StuFeeDetailsDataGridView);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentFeeDetails";
            this.Text = "StudentFeeDetails";
            this.Load += new System.EventHandler(this.StudentFeeDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StuFeeDetailsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Krypton.Toolkit.KryptonDataGridView StuFeeDetailsDataGridView;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SchoolIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearlyFeeColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn InstallmentColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
    }
}