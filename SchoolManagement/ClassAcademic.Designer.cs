namespace SchoolManagement
{
    partial class ClassAcademic
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.ClassName = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.ClassSection = new Krypton.Toolkit.KryptonTextBox();
            this.ClassDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.ClassIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Submit = new Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrevious = new Krypton.Toolkit.KryptonButton();
            this.btnNext = new Krypton.Toolkit.KryptonButton();
            this.btnBetweenPg = new Krypton.Toolkit.KryptonLabel();
            this.TotalCount = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(74, 16);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Class Name";
            // 
            // ClassName
            // 
            this.ClassName.Location = new System.Drawing.Point(9, 35);
            this.ClassName.MinimumSize = new System.Drawing.Size(0, 30);
            this.ClassName.Name = "ClassName";
            this.ClassName.Size = new System.Drawing.Size(275, 30);
            this.ClassName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ClassName.StateCommon.Border.Rounding = 2F;
            this.ClassName.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassName.TabIndex = 1;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(292, 13);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(51, 16);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "Section";
            // 
            // ClassSection
            // 
            this.ClassSection.Location = new System.Drawing.Point(297, 35);
            this.ClassSection.MinimumSize = new System.Drawing.Size(0, 30);
            this.ClassSection.Name = "ClassSection";
            this.ClassSection.Size = new System.Drawing.Size(275, 30);
            this.ClassSection.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ClassSection.StateCommon.Border.Rounding = 2F;
            this.ClassSection.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassSection.TabIndex = 5;
            this.ClassSection.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxClassSection_KeyPress);
            // 
            // ClassDataGridView
            // 
            this.ClassDataGridView.AllowUserToResizeColumns = false;
            this.ClassDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            this.ClassDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.ClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClassIdColumn,
            this.ClassNameColumn,
            this.SectionNameColumn,
            this.EditColumnButton,
            this.DeleteColumnButton});
            this.ClassDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ClassDataGridView.Location = new System.Drawing.Point(2, 181);
            this.ClassDataGridView.Name = "ClassDataGridView";
            this.ClassDataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.ClassDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.ClassDataGridView.Size = new System.Drawing.Size(579, 230);
            this.ClassDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.ClassDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.ClassDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.ClassDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.ClassDataGridView.TabIndex = 6;
            this.ClassDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassDataGridView_CellClick);
            // 
            // ClassIdColumn
            // 
            this.ClassIdColumn.DataPropertyName = "ClassId";
            this.ClassIdColumn.HeaderText = "ClassId";
            this.ClassIdColumn.Name = "ClassIdColumn";
            this.ClassIdColumn.ReadOnly = true;
            this.ClassIdColumn.Visible = false;
            // 
            // ClassNameColumn
            // 
            this.ClassNameColumn.DataPropertyName = "ClassName";
            this.ClassNameColumn.HeaderText = "ClassName";
            this.ClassNameColumn.Name = "ClassNameColumn";
            this.ClassNameColumn.ReadOnly = true;
            this.ClassNameColumn.Width = 149;
            // 
            // SectionNameColumn
            // 
            this.SectionNameColumn.DataPropertyName = "SectionName";
            this.SectionNameColumn.HeaderText = "SectionName";
            this.SectionNameColumn.Name = "SectionNameColumn";
            this.SectionNameColumn.ReadOnly = true;
            this.SectionNameColumn.Width = 149;
            // 
            // EditColumnButton
            // 
            this.EditColumnButton.HeaderText = "Edit";
            this.EditColumnButton.Name = "EditColumnButton";
            this.EditColumnButton.ReadOnly = true;
            this.EditColumnButton.Text = "Edit";
            this.EditColumnButton.UseColumnTextForButtonValue = true;
            this.EditColumnButton.Width = 119;
            // 
            // DeleteColumnButton
            // 
            this.DeleteColumnButton.HeaderText = "Delete";
            this.DeleteColumnButton.Name = "DeleteColumnButton";
            this.DeleteColumnButton.ReadOnly = true;
            this.DeleteColumnButton.Text = "Delete";
            this.DeleteColumnButton.UseColumnTextForButtonValue = true;
            this.DeleteColumnButton.Width = 119;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(9, 89);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(107, 33);
            this.Submit.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.Submit.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Submit.StateCommon.Border.Rounding = 2F;
            this.Submit.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.TabIndex = 26;
            this.Submit.Values.Text = "Submit";
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel.Location = new System.Drawing.Point(297, 68);
            this.flowLayoutPanel.MaximumSize = new System.Drawing.Size(275, 1000);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanel.TabIndex = 27;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(108, 420);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(59, 25);
            this.btnPrevious.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnPrevious.StateCommon.Border.Rounding = 2F;
            this.btnPrevious.TabIndex = 28;
            this.btnPrevious.Values.Text = "Previous";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(382, 420);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(66, 25);
            this.btnNext.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnNext.StateCommon.Border.Rounding = 2F;
            this.btnNext.TabIndex = 28;
            this.btnNext.Values.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnBetweenPg
            // 
            this.btnBetweenPg.Location = new System.Drawing.Point(184, 422);
            this.btnBetweenPg.Name = "btnBetweenPg";
            this.btnBetweenPg.Size = new System.Drawing.Size(13, 20);
            this.btnBetweenPg.TabIndex = 29;
            this.btnBetweenPg.Values.Text = ".";
            // 
            // TotalCount
            // 
            this.TotalCount.Location = new System.Drawing.Point(339, 423);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(13, 20);
            this.TotalCount.TabIndex = 29;
            this.TotalCount.Values.Text = ".";
            // 
            // ClassAcademic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 478);
            this.Controls.Add(this.TotalCount);
            this.Controls.Add(this.btnBetweenPg);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.ClassSection);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ClassDataGridView);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.ClassName);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassAcademic";
            this.Text = "ClassAcademic";
            this.Load += new System.EventHandler(this.ClassAcademic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox ClassName;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox ClassSection;
        private Krypton.Toolkit.KryptonDataGridView ClassDataGridView;
        private Krypton.Toolkit.KryptonButton Submit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionNameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumnButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumnButton;
        private Krypton.Toolkit.KryptonButton btnPrevious;
        private Krypton.Toolkit.KryptonButton btnNext;
        private Krypton.Toolkit.KryptonLabel btnBetweenPg;
        private Krypton.Toolkit.KryptonLabel TotalCount;
    }
}