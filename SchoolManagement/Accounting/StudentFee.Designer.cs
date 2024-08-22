namespace SchoolManagement.Accounting
{
    partial class StudentFee
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
            this.StudentFeeDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.StudentFeeSubmit = new Krypton.Toolkit.KryptonButton();
            this.ClassColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.YearlyFeesColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.StudentFeeDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentFeeDataGridView
            // 
            this.StudentFeeDataGridView.AllowDrop = true;
            this.StudentFeeDataGridView.AllowUserToAddRows = false;
            this.StudentFeeDataGridView.AllowUserToResizeColumns = false;
            this.StudentFeeDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.StudentFeeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StudentFeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentFeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassColumn,
            this.YearlyFeesColumn,
            this.InstallmentColumn});
            this.StudentFeeDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StudentFeeDataGridView.Location = new System.Drawing.Point(26, 108);
            this.StudentFeeDataGridView.Name = "StudentFeeDataGridView";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StudentFeeDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.StudentFeeDataGridView.Size = new System.Drawing.Size(477, 289);
            this.StudentFeeDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.StudentFeeDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.StudentFeeDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.StudentFeeDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.StudentFeeDataGridView.TabIndex = 46;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(26, 19);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(477, 72);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 48;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 23);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(296, 29);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Student Class Fee Manager";
            // 
            // StudentFeeSubmit
            // 
            this.StudentFeeSubmit.Location = new System.Drawing.Point(26, 411);
            this.StudentFeeSubmit.Name = "StudentFeeSubmit";
            this.StudentFeeSubmit.Size = new System.Drawing.Size(107, 33);
            this.StudentFeeSubmit.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.StudentFeeSubmit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StudentFeeSubmit.StateCommon.Border.Rounding = 2F;
            this.StudentFeeSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentFeeSubmit.TabIndex = 49;
            this.StudentFeeSubmit.Values.Text = "Submit ";
            this.StudentFeeSubmit.Click += new System.EventHandler(this.StudentFeeSubmit_Click);
            // 
            // ClassColumn
            // 
            this.ClassColumn.DataPropertyName = "ClassName";
            this.ClassColumn.HeaderText = "Class";
            this.ClassColumn.Name = "ClassColumn";
            this.ClassColumn.Width = 145;
            // 
            // YearlyFeesColumn
            // 
            this.YearlyFeesColumn.HeaderText = "Yearly Fees";
            this.YearlyFeesColumn.Name = "YearlyFeesColumn";
            this.YearlyFeesColumn.Width = 145;
            // 
            // InstallmentColumn
            // 
            this.InstallmentColumn.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.InstallmentColumn.HeaderText = "Installment";
            this.InstallmentColumn.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.InstallmentColumn.Name = "InstallmentColumn";
            this.InstallmentColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.InstallmentColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.InstallmentColumn.Width = 145;
            // 
            // StudentFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(532, 457);
            this.Controls.Add(this.StudentFeeSubmit);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.StudentFeeDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentFee";
            this.Text = "StudentFee";
            this.Load += new System.EventHandler(this.StudentFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentFeeDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Krypton.Toolkit.KryptonDataGridView StudentFeeDataGridView;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        public Krypton.Toolkit.KryptonButton StudentFeeSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn YearlyFeesColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn InstallmentColumn;
    }
}