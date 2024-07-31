namespace SchoolManagement.Academic
{
    partial class ClassRoutine
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.classSelect = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.sectionSelect = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.subjectSelect = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.teacherSelect = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.Submit = new Krypton.Toolkit.KryptonButton();
            this.ClassRoutineDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.IdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TeacherNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.classSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassRoutineDataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.classSelect.TabIndex = 31;
            this.classSelect.SelectedIndexChanged += new System.EventHandler(this.classSelect_SelectedIndexChanged);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(6, 8);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(40, 16);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 32;
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
            this.sectionSelect.TabIndex = 31;
            this.sectionSelect.Tag = "";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(293, 8);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(51, 16);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 32;
            this.kryptonLabel2.Values.Text = "Section";
            // 
            // subjectSelect
            // 
            this.subjectSelect.AllowDrop = true;
            this.subjectSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.subjectSelect.DropDownHeight = 130;
            this.subjectSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectSelect.DropDownWidth = 273;
            this.subjectSelect.IntegralHeight = false;
            this.subjectSelect.Location = new System.Drawing.Point(10, 86);
            this.subjectSelect.MinimumSize = new System.Drawing.Size(0, 30);
            this.subjectSelect.Name = "subjectSelect";
            this.subjectSelect.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.subjectSelect.Size = new System.Drawing.Size(275, 30);
            this.subjectSelect.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.subjectSelect.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.subjectSelect.StateCommon.ComboBox.Border.Rounding = 2F;
            this.subjectSelect.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectSelect.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.subjectSelect.TabIndex = 31;
            this.subjectSelect.SelectedIndexChanged += new System.EventHandler(this.subjectSelect_SelectedIndexChanged);
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(6, 64);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(51, 16);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 32;
            this.kryptonLabel3.Values.Text = "Subject";
            // 
            // teacherSelect
            // 
            this.teacherSelect.AllowDrop = true;
            this.teacherSelect.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.teacherSelect.DropDownHeight = 130;
            this.teacherSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherSelect.DropDownWidth = 273;
            this.teacherSelect.IntegralHeight = false;
            this.teacherSelect.Location = new System.Drawing.Point(297, 86);
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
            this.teacherSelect.TabIndex = 31;
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(293, 64);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(54, 16);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 32;
            this.kryptonLabel4.Values.Text = "Teacher";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(10, 142);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(107, 33);
            this.Submit.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.Submit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StateCommon.Border.Rounding = 2F;
            this.Submit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.TabIndex = 33;
            this.Submit.Values.Text = "Submit";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // ClassRoutineDataGridView
            // 
            this.ClassRoutineDataGridView.AllowUserToResizeColumns = false;
            this.ClassRoutineDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ClassRoutineDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClassRoutineDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassRoutineDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdColumn,
            this.ClassNameColumn,
            this.SectionNameColumn,
            this.SubjectNameColumn,
            this.TeacherNameColumn,
            this.EditColumn,
            this.DeleteColumn});
            this.ClassRoutineDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ClassRoutineDataGridView.Location = new System.Drawing.Point(2, 181);
            this.ClassRoutineDataGridView.Name = "ClassRoutineDataGridView";
            this.ClassRoutineDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.ClassRoutineDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.ClassRoutineDataGridView.Size = new System.Drawing.Size(579, 246);
            this.ClassRoutineDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.ClassRoutineDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.ClassRoutineDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.ClassRoutineDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.ClassRoutineDataGridView.TabIndex = 34;
            // 
            // IdColumn
            // 
            this.IdColumn.DataPropertyName = "Id";
            this.IdColumn.HeaderText = "Id";
            this.IdColumn.Name = "IdColumn";
            this.IdColumn.ReadOnly = true;
            this.IdColumn.Visible = false;
            // 
            // ClassNameColumn
            // 
            this.ClassNameColumn.DataPropertyName = "ClassId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ClassNameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClassNameColumn.HeaderText = "Class Name";
            this.ClassNameColumn.Name = "ClassNameColumn";
            this.ClassNameColumn.ReadOnly = true;
            this.ClassNameColumn.Width = 110;
            // 
            // SectionNameColumn
            // 
            this.SectionNameColumn.DataPropertyName = "SectionId";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.SectionNameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.SectionNameColumn.HeaderText = "Section Name";
            this.SectionNameColumn.Name = "SectionNameColumn";
            this.SectionNameColumn.ReadOnly = true;
            this.SectionNameColumn.Width = 110;
            // 
            // SubjectNameColumn
            // 
            this.SubjectNameColumn.DataPropertyName = "SubjectId";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.SubjectNameColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.SubjectNameColumn.HeaderText = "Subject Name";
            this.SubjectNameColumn.Name = "SubjectNameColumn";
            this.SubjectNameColumn.ReadOnly = true;
            this.SubjectNameColumn.Width = 110;
            // 
            // TeacherNameColumn
            // 
            this.TeacherNameColumn.DataPropertyName = "TeacherId";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.TeacherNameColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.TeacherNameColumn.HeaderText = "Teacher Name";
            this.TeacherNameColumn.Name = "TeacherNameColumn";
            this.TeacherNameColumn.ReadOnly = true;
            this.TeacherNameColumn.Width = 110;
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
            // ClassRoutine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 478);
            this.Controls.Add(this.ClassRoutineDataGridView);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.sectionSelect);
            this.Controls.Add(this.teacherSelect);
            this.Controls.Add(this.subjectSelect);
            this.Controls.Add(this.classSelect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassRoutine";
            this.Text = "ClassRoutine";
            this.Load += new System.EventHandler(this.ClassRoutine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.classSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sectionSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teacherSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassRoutineDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox classSelect;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonComboBox sectionSelect;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonComboBox subjectSelect;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonComboBox teacherSelect;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonButton Submit;
        private Krypton.Toolkit.KryptonDataGridView ClassRoutineDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TeacherNameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumn;
    }
}