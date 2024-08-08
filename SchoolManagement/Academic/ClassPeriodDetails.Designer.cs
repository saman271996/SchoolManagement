namespace SchoolManagement.Academic
{
    partial class ClassPeriodDetails
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
            this.DetailPeriodDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassTeacherColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalPeriodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ViewPeriodColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DetailPeriodDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DetailPeriodDataGridView
            // 
            this.DetailPeriodDataGridView.AllowDrop = true;
            this.DetailPeriodDataGridView.AllowUserToAddRows = false;
            this.DetailPeriodDataGridView.AllowUserToResizeColumns = false;
            this.DetailPeriodDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DetailPeriodDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DetailPeriodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DetailPeriodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.ClassColumn,
            this.SectionColumn,
            this.ClassTeacherColumn,
            this.TotalPeriodColumn,
            this.EditColumn,
            this.ViewPeriodColumn});
            this.DetailPeriodDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.DetailPeriodDataGridView.Location = new System.Drawing.Point(12, 123);
            this.DetailPeriodDataGridView.Name = "DetailPeriodDataGridView";
            this.DetailPeriodDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.DetailPeriodDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.DetailPeriodDataGridView.Size = new System.Drawing.Size(552, 256);
            this.DetailPeriodDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.DetailPeriodDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.DetailPeriodDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.DetailPeriodDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.DetailPeriodDataGridView.TabIndex = 46;
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(12, 24);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(552, 72);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.White;
            this.kryptonPanel1.TabIndex = 47;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 23);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(221, 29);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 1;
            this.kryptonLabel1.Values.Text = "Class Period Details";
            // 
            // IdColumn
            // 
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            // 
            // ClassColumn
            // 
            this.ClassColumn.HeaderText = "Class";
            this.ClassColumn.Name = "ClassColumn";
            this.ClassColumn.ReadOnly = true;
            // 
            // SectionColumn
            // 
            this.SectionColumn.HeaderText = "Section";
            this.SectionColumn.Name = "SectionColumn";
            this.SectionColumn.ReadOnly = true;
            // 
            // ClassTeacherColumn
            // 
            this.ClassTeacherColumn.HeaderText = "ClassTeacher";
            this.ClassTeacherColumn.Name = "ClassTeacherColumn";
            this.ClassTeacherColumn.ReadOnly = true;
            // 
            // TotalPeriodColumn
            // 
            this.TotalPeriodColumn.HeaderText = "TotalPeriod";
            this.TotalPeriodColumn.Name = "TotalPeriodColumn";
            this.TotalPeriodColumn.ReadOnly = true;
            // 
            // EditColumn
            // 
            this.EditColumn.HeaderText = "Edit";
            this.EditColumn.Name = "EditColumn";
            this.EditColumn.ReadOnly = true;
            // 
            // ViewPeriodColumn
            // 
            this.ViewPeriodColumn.HeaderText = "ViewPeriod";
            this.ViewPeriodColumn.Name = "ViewPeriodColumn";
            this.ViewPeriodColumn.ReadOnly = true;
            // 
            // ClassPeriodDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 396);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.DetailPeriodDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassPeriodDetails";
            this.Text = "ClassPeriodDetails";
            this.Load += new System.EventHandler(this.ClassPeriodDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DetailPeriodDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView DetailPeriodDataGridView;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassTeacherColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalPeriodColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
        private System.Windows.Forms.DataGridViewButtonColumn ViewPeriodColumn;
    }
}