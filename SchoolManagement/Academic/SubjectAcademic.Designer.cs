namespace SchoolManagement
{
    partial class SubjectAcademic
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
            this.SelectClasses = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.SubjectName = new Krypton.Toolkit.KryptonTextBox();
            this.SubjectDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.SubjectIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectClassColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubjectNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteButtonColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.SubjectSubmit = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.SelectClasses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectClasses
            // 
            this.SelectClasses.AllowDrop = true;
            this.SelectClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SelectClasses.DropDownHeight = 180;
            this.SelectClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectClasses.DropDownWidth = 273;
            this.SelectClasses.IntegralHeight = false;
            this.SelectClasses.Location = new System.Drawing.Point(9, 35);
            this.SelectClasses.MinimumSize = new System.Drawing.Size(0, 30);
            this.SelectClasses.Name = "SelectClasses";
            this.SelectClasses.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.SelectClasses.Size = new System.Drawing.Size(275, 30);
            this.SelectClasses.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.SelectClasses.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SelectClasses.StateCommon.ComboBox.Border.Rounding = 2F;
            this.SelectClasses.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectClasses.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.SelectClasses.TabIndex = 2;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(86, 16);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 3;
            this.kryptonLabel1.Values.Text = "Select a Class";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(292, 13);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(85, 16);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Subject Name";
            // 
            // SubjectName
            // 
            this.SubjectName.Location = new System.Drawing.Point(297, 35);
            this.SubjectName.MinimumSize = new System.Drawing.Size(0, 30);
            this.SubjectName.Name = "SubjectName";
            this.SubjectName.Size = new System.Drawing.Size(275, 30);
            this.SubjectName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SubjectName.StateCommon.Border.Rounding = 2F;
            this.SubjectName.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectName.TabIndex = 6;
            // 
            // SubjectDataGridView
            // 
            this.SubjectDataGridView.AllowUserToResizeColumns = false;
            this.SubjectDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.SubjectDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SubjectDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SubjectDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SubjectIdColumn,
            this.SelectClassColumn,
            this.SubjectNameColumn,
            this.EditButtonColumn,
            this.DeleteButtonColumn});
            this.SubjectDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.SubjectDataGridView.Location = new System.Drawing.Point(2, 181);
            this.SubjectDataGridView.Name = "SubjectDataGridView";
            this.SubjectDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.SubjectDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.SubjectDataGridView.Size = new System.Drawing.Size(579, 246);
            this.SubjectDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.SubjectDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.SubjectDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.SubjectDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.SubjectDataGridView.TabIndex = 29;
            this.SubjectDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SubjectDataGridView_CellClick);
            // 
            // SubjectIdColumn
            // 
            this.SubjectIdColumn.DataPropertyName = "SubjectId";
            this.SubjectIdColumn.HeaderText = "SubjectId";
            this.SubjectIdColumn.Name = "SubjectIdColumn";
            this.SubjectIdColumn.ReadOnly = true;
            this.SubjectIdColumn.Visible = false;
            // 
            // SelectClassColumn
            // 
            this.SelectClassColumn.DataPropertyName = "ClassName";
            this.SelectClassColumn.HeaderText = "Class";
            this.SelectClassColumn.Name = "SelectClassColumn";
            this.SelectClassColumn.ReadOnly = true;
            this.SelectClassColumn.Width = 129;
            // 
            // SubjectNameColumn
            // 
            this.SubjectNameColumn.DataPropertyName = "SubjectName";
            this.SubjectNameColumn.HeaderText = "Subject Name";
            this.SubjectNameColumn.Name = "SubjectNameColumn";
            this.SubjectNameColumn.ReadOnly = true;
            this.SubjectNameColumn.Width = 169;
            // 
            // EditButtonColumn
            // 
            this.EditButtonColumn.HeaderText = "Edit";
            this.EditButtonColumn.Name = "EditButtonColumn";
            this.EditButtonColumn.ReadOnly = true;
            this.EditButtonColumn.Text = "Edit";
            this.EditButtonColumn.UseColumnTextForButtonValue = true;
            this.EditButtonColumn.Width = 119;
            // 
            // DeleteButtonColumn
            // 
            this.DeleteButtonColumn.HeaderText = "Delete";
            this.DeleteButtonColumn.Name = "DeleteButtonColumn";
            this.DeleteButtonColumn.ReadOnly = true;
            this.DeleteButtonColumn.Text = "Delete";
            this.DeleteButtonColumn.UseColumnTextForButtonValue = true;
            this.DeleteButtonColumn.Width = 119;
            // 
            // SubjectSubmit
            // 
            this.SubjectSubmit.Location = new System.Drawing.Point(9, 89);
            this.SubjectSubmit.Name = "SubjectSubmit";
            this.SubjectSubmit.Size = new System.Drawing.Size(107, 33);
            this.SubjectSubmit.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.SubjectSubmit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SubjectSubmit.StateCommon.Border.Rounding = 2F;
            this.SubjectSubmit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectSubmit.TabIndex = 30;
            this.SubjectSubmit.Values.Text = "Submit";
            this.SubjectSubmit.Click += new System.EventHandler(this.SubjectSubmit_Click);
            // 
            // SubjectAcademic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 478);
            this.Controls.Add(this.SubjectSubmit);
            this.Controls.Add(this.SubjectDataGridView);
            this.Controls.Add(this.SubjectName);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.Controls.Add(this.SelectClasses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SubjectAcademic";
            this.Text = "SubjectAcademic";
            this.Load += new System.EventHandler(this.SubjectAcademic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SelectClasses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SubjectDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonComboBox SelectClasses;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox SubjectName;
        private Krypton.Toolkit.KryptonDataGridView SubjectDataGridView;
        private Krypton.Toolkit.KryptonButton SubjectSubmit;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SelectClassColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubjectNameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditButtonColumn;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteButtonColumn;
    }
}