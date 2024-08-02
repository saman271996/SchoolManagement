namespace SchoolManagement.Academic
{
    partial class ClassPeriod
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.sectionSelect = new Krypton.Toolkit.KryptonComboBox();
            this.teacherSelect = new Krypton.Toolkit.KryptonComboBox();
            this.classSelect = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.Submit = new Krypton.Toolkit.KryptonButton();
            this.period = new Krypton.Toolkit.KryptonTextBox();
            this.PeriodDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.PeriodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TeacherNameColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TimingColumn = new Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn();
            this.DurationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sectionSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(293, 8);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(51, 16);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 37;
            this.kryptonLabel2.Values.Text = "Section";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(6, 64);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(87, 16);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 38;
            this.kryptonLabel4.Values.Text = "Class Teacher";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(6, 8);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(40, 16);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 40;
            this.kryptonLabel1.Values.Text = "Class";
            // 
            // sectionSelect
            // 
            this.sectionSelect.AllowDrop = true;
            this.sectionSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.sectionSelect.DropDownHeight = 130;
            this.sectionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectionSelect.DropDownWidth = 273;
            this.sectionSelect.IntegralHeight = false;
            this.sectionSelect.Location = new System.Drawing.Point(297, 30);
            this.sectionSelect.MinimumSize = new System.Drawing.Size(0, 30);
            this.sectionSelect.Name = "sectionSelect";
            this.sectionSelect.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.sectionSelect.Size = new System.Drawing.Size(275, 30);
            this.sectionSelect.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.sectionSelect.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.sectionSelect.StateCommon.ComboBox.Border.Rounding = 2F;
            this.sectionSelect.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sectionSelect.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.sectionSelect.TabIndex = 33;
            this.sectionSelect.Tag = "";
            // 
            // teacherSelect
            // 
            this.teacherSelect.AllowDrop = true;
            this.teacherSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.teacherSelect.DropDownHeight = 130;
            this.teacherSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherSelect.DropDownWidth = 273;
            this.teacherSelect.IntegralHeight = false;
            this.teacherSelect.Location = new System.Drawing.Point(10, 86);
            this.teacherSelect.MinimumSize = new System.Drawing.Size(0, 30);
            this.teacherSelect.Name = "teacherSelect";
            this.teacherSelect.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.teacherSelect.Size = new System.Drawing.Size(275, 30);
            this.teacherSelect.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.teacherSelect.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.teacherSelect.StateCommon.ComboBox.Border.Rounding = 2F;
            this.teacherSelect.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teacherSelect.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.teacherSelect.TabIndex = 34;
            // 
            // classSelect
            // 
            this.classSelect.AllowDrop = true;
            this.classSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.classSelect.DropDownHeight = 130;
            this.classSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classSelect.DropDownWidth = 273;
            this.classSelect.IntegralHeight = false;
            this.classSelect.Location = new System.Drawing.Point(10, 30);
            this.classSelect.MinimumSize = new System.Drawing.Size(0, 30);
            this.classSelect.Name = "classSelect";
            this.classSelect.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.classSelect.Size = new System.Drawing.Size(275, 30);
            this.classSelect.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.classSelect.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.classSelect.StateCommon.ComboBox.Border.Rounding = 2F;
            this.classSelect.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classSelect.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.classSelect.TabIndex = 36;
            this.classSelect.SelectedIndexChanged += new System.EventHandler(this.classSelect_SelectedIndexChanged);
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(293, 66);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(76, 16);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 41;
            this.kryptonLabel5.Values.Text = "Total Period";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(10, 433);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(107, 33);
            this.Submit.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.Submit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StateCommon.Border.Rounding = 2F;
            this.Submit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.TabIndex = 42;
            this.Submit.Values.Text = "Submit ";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // period
            // 
            this.period.Location = new System.Drawing.Point(297, 86);
            this.period.MinimumSize = new System.Drawing.Size(0, 30);
            this.period.Name = "period";
            this.period.Size = new System.Drawing.Size(275, 30);
            this.period.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.period.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.period.StateCommon.Border.Rounding = 2F;
            this.period.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.period.TabIndex = 43;
            this.period.KeyUp += new System.Windows.Forms.KeyEventHandler(this.period_KeyUp);
            // 
            // PeriodDataGridView
            // 
            this.PeriodDataGridView.AllowUserToAddRows = false;
            this.PeriodDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.PeriodDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.PeriodDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PeriodDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PeriodColumn,
            this.SubjectColumn,
            this.TeacherNameColumn,
            this.TimingColumn,
            this.DurationColumn});
            this.PeriodDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PeriodDataGridView.Location = new System.Drawing.Point(10, 143);
            this.PeriodDataGridView.Name = "PeriodDataGridView";
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.PeriodDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.PeriodDataGridView.Size = new System.Drawing.Size(562, 262);
            this.PeriodDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.PeriodDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.PeriodDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.PeriodDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.PeriodDataGridView.TabIndex = 44;
            // 
            // PeriodColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.PeriodColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.PeriodColumn.HeaderText = "Period";
            this.PeriodColumn.Name = "PeriodColumn";
            // 
            // SubjectColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.SubjectColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.SubjectColumn.DisplayStyleForCurrentCellOnly = true;
            this.SubjectColumn.HeaderText = "Subject";
            this.SubjectColumn.Name = "SubjectColumn";
            this.SubjectColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SubjectColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SubjectColumn.Width = 140;
            // 
            // TeacherNameColumn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.TeacherNameColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.TeacherNameColumn.DisplayStyleForCurrentCellOnly = true;
            this.TeacherNameColumn.HeaderText = "Teacher Name";
            this.TeacherNameColumn.Name = "TeacherNameColumn";
            this.TeacherNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TeacherNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TeacherNameColumn.Width = 140;
            // 
            // TimingColumn
            // 
            this.TimingColumn.CalendarCloseOnTodayClick = true;
            this.TimingColumn.Checked = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.Format = "t";
            this.TimingColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.TimingColumn.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimingColumn.HeaderText = "Timing";
            this.TimingColumn.Name = "TimingColumn";
            this.TimingColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.TimingColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TimingColumn.Width = 110;
            // 
            // DurationColumn
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.DurationColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.DurationColumn.HeaderText = "Duration";
            this.DurationColumn.Name = "DurationColumn";
            // 
            // ClassPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 478);
            this.Controls.Add(this.PeriodDataGridView);
            this.Controls.Add(this.period);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.sectionSelect);
            this.Controls.Add(this.teacherSelect);
            this.Controls.Add(this.classSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassPeriod";
            this.Text = "ClassPeriod";
            this.Load += new System.EventHandler(this.ClassPeriod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sectionSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PeriodDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox sectionSelect;
        private Krypton.Toolkit.KryptonComboBox teacherSelect;
        private Krypton.Toolkit.KryptonComboBox classSelect;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonButton Submit;
        private Krypton.Toolkit.KryptonTextBox period;
        private Krypton.Toolkit.KryptonDataGridView PeriodDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PeriodColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn SubjectColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn TeacherNameColumn;
        private Krypton.Toolkit.KryptonDataGridViewDateTimePickerColumn TimingColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn DurationColumn;
    }
}