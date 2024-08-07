using System.Windows.Forms;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.sectionSelect = new Krypton.Toolkit.KryptonComboBox();
            this.teacherSelect = new Krypton.Toolkit.KryptonComboBox();
            this.classSelect = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.Submit = new Krypton.Toolkit.KryptonButton();
            this.period = new Krypton.Toolkit.KryptonTextBox();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.PeriodDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.PeriodColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TeacherNameColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.TimingFromColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimingToColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Submit.Location = new System.Drawing.Point(10, 427);
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
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(0, 0);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(200, 20);
            this.dtp.TabIndex = 0;
            // 
            // PeriodDataGridView
            // 
            this.PeriodDataGridView.AllowDrop = true;
            this.PeriodDataGridView.AllowUserToAddRows = false;
            this.PeriodDataGridView.AllowUserToResizeColumns = false;
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
            this.TimingFromColumn,
            this.TimingToColumn,
            this.DurationColumn});
            this.PeriodDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PeriodDataGridView.Location = new System.Drawing.Point(0, 144);
            this.PeriodDataGridView.Name = "PeriodDataGridView";
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.PeriodDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.PeriodDataGridView.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PeriodDataGridView.Size = new System.Drawing.Size(583, 256);
            this.PeriodDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.PeriodDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.PeriodDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.PeriodDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.PeriodDataGridView.TabIndex = 45;
            this.PeriodDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeriodDataGridView_CellClick);
            this.PeriodDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.PeriodDataGridView_CellValueChanged);
            // 
            // PeriodColumn
            // 
            this.PeriodColumn.HeaderText = "Period";
            this.PeriodColumn.Name = "PeriodColumn";
            this.PeriodColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PeriodColumn.Width = 58;
            // 
            // SubjectColumn
            // 
            this.SubjectColumn.DisplayStyleForCurrentCellOnly = true;
            this.SubjectColumn.HeaderText = "Subject";
            this.SubjectColumn.Name = "SubjectColumn";
            this.SubjectColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SubjectColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.SubjectColumn.Width = 95;
            // 
            // TeacherNameColumn
            // 
            this.TeacherNameColumn.DisplayStyleForCurrentCellOnly = true;
            this.TeacherNameColumn.HeaderText = "Teacher Name";
            this.TeacherNameColumn.Name = "TeacherNameColumn";
            this.TeacherNameColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TeacherNameColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.TeacherNameColumn.Width = 130;
            // 
            // TimingFromColumn
            // 
            this.TimingFromColumn.HeaderText = "Timing From";
            this.TimingFromColumn.Name = "TimingFromColumn";
            this.TimingFromColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TimingToColumn
            // 
            this.TimingToColumn.HeaderText = "Timing To";
            this.TimingToColumn.Name = "TimingToColumn";
            this.TimingToColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.TimingToColumn.Width = 98;
            // 
            // DurationColumn
            // 
            this.DurationColumn.HeaderText = "Duration";
            this.DurationColumn.Name = "DurationColumn";
            this.DurationColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DurationColumn.Width = 61;
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
        private DateTimePicker dtp;
        private Krypton.Toolkit.KryptonDataGridView PeriodDataGridView;
        private DataGridViewTextBoxColumn PeriodColumn;
        private DataGridViewComboBoxColumn SubjectColumn;
        private DataGridViewComboBoxColumn TeacherNameColumn;
        private DataGridViewTextBoxColumn TimingFromColumn;
        private DataGridViewTextBoxColumn TimingToColumn;
        private DataGridViewTextBoxColumn DurationColumn;
    }
}