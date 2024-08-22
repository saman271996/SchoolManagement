namespace SchoolManagement.Accounting
{
    partial class StudentFeeInstallmentDetail
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
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.totalNoOfInstallment = new Krypton.Toolkit.KryptonTextBox();
            this.negotiableAmount = new Krypton.Toolkit.KryptonTextBox();
            this.firstPayPayment = new Krypton.Toolkit.KryptonTextBox();
            this.seeAmount = new Krypton.Toolkit.KryptonTextBox();
            this.StuFeeInstaDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.StudentIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InstallmentDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateOfPayColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StatusColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudFeeInstallSubmit = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.StuFeeInstaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(6, 12);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(76, 16);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 44;
            this.kryptonLabel5.Values.Text = "Fee Amount";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(288, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(108, 16);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 46;
            this.kryptonLabel1.Values.Text = "First Pay Payment";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(6, 68);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(114, 16);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 44;
            this.kryptonLabel2.Values.Text = "Negotiable Amount";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(288, 68);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(134, 16);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 46;
            this.kryptonLabel3.Values.Text = "Total No Of Installment";
            // 
            // totalNoOfInstallment
            // 
            this.totalNoOfInstallment.Location = new System.Drawing.Point(292, 90);
            this.totalNoOfInstallment.MinimumSize = new System.Drawing.Size(0, 30);
            this.totalNoOfInstallment.Name = "totalNoOfInstallment";
            this.totalNoOfInstallment.Size = new System.Drawing.Size(270, 30);
            this.totalNoOfInstallment.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.totalNoOfInstallment.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.totalNoOfInstallment.StateCommon.Border.Rounding = 2F;
            this.totalNoOfInstallment.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalNoOfInstallment.TabIndex = 51;
            this.totalNoOfInstallment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.totalNoOfInstallment_KeyUp);
            // 
            // negotiableAmount
            // 
            this.negotiableAmount.Location = new System.Drawing.Point(10, 90);
            this.negotiableAmount.MinimumSize = new System.Drawing.Size(0, 30);
            this.negotiableAmount.Name = "negotiableAmount";
            this.negotiableAmount.Size = new System.Drawing.Size(270, 30);
            this.negotiableAmount.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.negotiableAmount.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.negotiableAmount.StateCommon.Border.Rounding = 2F;
            this.negotiableAmount.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.negotiableAmount.TabIndex = 51;
            // 
            // firstPayPayment
            // 
            this.firstPayPayment.Location = new System.Drawing.Point(292, 32);
            this.firstPayPayment.MinimumSize = new System.Drawing.Size(0, 30);
            this.firstPayPayment.Name = "firstPayPayment";
            this.firstPayPayment.Size = new System.Drawing.Size(270, 30);
            this.firstPayPayment.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.firstPayPayment.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.firstPayPayment.StateCommon.Border.Rounding = 2F;
            this.firstPayPayment.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstPayPayment.TabIndex = 51;
            // 
            // seeAmount
            // 
            this.seeAmount.Location = new System.Drawing.Point(10, 32);
            this.seeAmount.MinimumSize = new System.Drawing.Size(0, 30);
            this.seeAmount.Name = "seeAmount";
            this.seeAmount.Size = new System.Drawing.Size(270, 30);
            this.seeAmount.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.seeAmount.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.seeAmount.StateCommon.Border.Rounding = 2F;
            this.seeAmount.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seeAmount.TabIndex = 51;
            // 
            // StuFeeInstaDataGridView
            // 
            this.StuFeeInstaDataGridView.AllowDrop = true;
            this.StuFeeInstaDataGridView.AllowUserToAddRows = false;
            this.StuFeeInstaDataGridView.AllowUserToResizeColumns = false;
            this.StuFeeInstaDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.StuFeeInstaDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.StuFeeInstaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StuFeeInstaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentIdColumn,
            this.InstallmentDateColumn,
            this.DateOfPayColumn,
            this.StatusColumn});
            this.StuFeeInstaDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.StuFeeInstaDataGridView.Location = new System.Drawing.Point(10, 140);
            this.StuFeeInstaDataGridView.Name = "StuFeeInstaDataGridView";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.StuFeeInstaDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.StuFeeInstaDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.StuFeeInstaDataGridView.Size = new System.Drawing.Size(552, 251);
            this.StuFeeInstaDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.StuFeeInstaDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.StuFeeInstaDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.StuFeeInstaDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.StuFeeInstaDataGridView.TabIndex = 52;
            // 
            // StudentIdColumn
            // 
            this.StudentIdColumn.HeaderText = "StudentId";
            this.StudentIdColumn.Name = "StudentIdColumn";
            this.StudentIdColumn.Width = 101;
            // 
            // InstallmentDateColumn
            // 
            this.InstallmentDateColumn.HeaderText = "Installment Date";
            this.InstallmentDateColumn.Name = "InstallmentDateColumn";
            this.InstallmentDateColumn.Width = 140;
            // 
            // DateOfPayColumn
            // 
            this.DateOfPayColumn.HeaderText = "Date Of Pay";
            this.DateOfPayColumn.Name = "DateOfPayColumn";
            this.DateOfPayColumn.Width = 140;
            // 
            // StatusColumn
            // 
            this.StatusColumn.HeaderText = "Status";
            this.StatusColumn.Name = "StatusColumn";
            this.StatusColumn.Width = 130;
            // 
            // StudFeeInstallSubmit
            // 
            this.StudFeeInstallSubmit.Location = new System.Drawing.Point(10, 408);
            this.StudFeeInstallSubmit.Name = "StudFeeInstallSubmit";
            this.StudFeeInstallSubmit.Size = new System.Drawing.Size(107, 33);
            this.StudFeeInstallSubmit.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.StudFeeInstallSubmit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StudFeeInstallSubmit.StateCommon.Border.Rounding = 2F;
            this.StudFeeInstallSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudFeeInstallSubmit.TabIndex = 53;
            this.StudFeeInstallSubmit.Values.Text = "Submit ";
            this.StudFeeInstallSubmit.Click += new System.EventHandler(this.StudFeeInstallSubmit_Click);
            // 
            // StudentFeeInstallmentDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(572, 457);
            this.Controls.Add(this.StudFeeInstallSubmit);
            this.Controls.Add(this.StuFeeInstaDataGridView);
            this.Controls.Add(this.seeAmount);
            this.Controls.Add(this.firstPayPayment);
            this.Controls.Add(this.negotiableAmount);
            this.Controls.Add(this.totalNoOfInstallment);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentFeeInstallmentDetail";
            this.Text = "StudentFeeInstallmentDetail";
            this.Load += new System.EventHandler(this.StudentFeeInstallmentDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StuFeeInstaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonTextBox totalNoOfInstallment;
        private Krypton.Toolkit.KryptonTextBox negotiableAmount;
        private Krypton.Toolkit.KryptonTextBox firstPayPayment;
        private Krypton.Toolkit.KryptonTextBox seeAmount;
        public Krypton.Toolkit.KryptonDataGridView StuFeeInstaDataGridView;
        public Krypton.Toolkit.KryptonButton StudFeeInstallSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn InstallmentDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOfPayColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StatusColumn;
    }
}