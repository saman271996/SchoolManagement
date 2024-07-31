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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.ClassSection = new Krypton.Toolkit.KryptonTextBox();
            this.ClassDataGridView = new Krypton.Toolkit.KryptonDataGridView();
            this.SectionIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamIdColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StreamNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SectionNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EditColumnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.DeleteColumnButton = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Submit = new Krypton.Toolkit.KryptonButton();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.btnBetweenPg = new Krypton.Toolkit.KryptonLabel();
            this.TotalCount = new Krypton.Toolkit.KryptonLabel();
            this.ClassName = new Krypton.Toolkit.KryptonComboBox();
            this.section_streamType = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.previousBtn = new Krypton.Toolkit.KryptonButton();
            this.nextBtn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.ClassDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassName)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(5, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(40, 16);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Class";
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
            this.ClassSection.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.ClassDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ClassDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SectionIdColumn,
            this.StreamIdColumn,
            this.ClassNameColumn,
            this.StreamNameColumn,
            this.SectionNameColumn,
            this.EditColumnButton,
            this.DeleteColumnButton});
            this.ClassDataGridView.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ClassDataGridView.Location = new System.Drawing.Point(2, 181);
            this.ClassDataGridView.Name = "ClassDataGridView";
            this.ClassDataGridView.ReadOnly = true;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.ClassDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.ClassDataGridView.Size = new System.Drawing.Size(579, 246);
            this.ClassDataGridView.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.ClassDataGridView.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.ClassDataGridView.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.White;
            this.ClassDataGridView.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.White;
            this.ClassDataGridView.TabIndex = 6;
            this.ClassDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClassDataGridView_CellClick);
            // 
            // SectionIdColumn
            // 
            this.SectionIdColumn.DataPropertyName = "SectionId";
            this.SectionIdColumn.HeaderText = "SectionId";
            this.SectionIdColumn.Name = "SectionIdColumn";
            this.SectionIdColumn.ReadOnly = true;
            this.SectionIdColumn.Visible = false;
            // 
            // StreamIdColumn
            // 
            this.StreamIdColumn.DataPropertyName = "StreamId";
            this.StreamIdColumn.HeaderText = "StreamId";
            this.StreamIdColumn.Name = "StreamIdColumn";
            this.StreamIdColumn.ReadOnly = true;
            this.StreamIdColumn.Visible = false;
            // 
            // ClassNameColumn
            // 
            this.ClassNameColumn.DataPropertyName = "ClassId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.ClassNameColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.ClassNameColumn.HeaderText = "ClassName";
            this.ClassNameColumn.Name = "ClassNameColumn";
            this.ClassNameColumn.ReadOnly = true;
            this.ClassNameColumn.Width = 119;
            // 
            // StreamNameColumn
            // 
            this.StreamNameColumn.DataPropertyName = "StreamName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.StreamNameColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.StreamNameColumn.HeaderText = "StreamName";
            this.StreamNameColumn.Name = "StreamNameColumn";
            this.StreamNameColumn.ReadOnly = true;
            this.StreamNameColumn.Width = 119;
            // 
            // SectionNameColumn
            // 
            this.SectionNameColumn.DataPropertyName = "SectionName";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.SectionNameColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.SectionNameColumn.HeaderText = "SectionName";
            this.SectionNameColumn.Name = "SectionNameColumn";
            this.SectionNameColumn.ReadOnly = true;
            // 
            // EditColumnButton
            // 
            this.EditColumnButton.HeaderText = "Edit";
            this.EditColumnButton.Name = "EditColumnButton";
            this.EditColumnButton.ReadOnly = true;
            this.EditColumnButton.Text = "Edit";
            this.EditColumnButton.UseColumnTextForButtonValue = true;
            // 
            // DeleteColumnButton
            // 
            this.DeleteColumnButton.HeaderText = "Delete";
            this.DeleteColumnButton.Name = "DeleteColumnButton";
            this.DeleteColumnButton.ReadOnly = true;
            this.DeleteColumnButton.Text = "Delete";
            this.DeleteColumnButton.UseColumnTextForButtonValue = true;
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(9, 138);
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
            // btnBetweenPg
            // 
            this.btnBetweenPg.Location = new System.Drawing.Point(230, 446);
            this.btnBetweenPg.Name = "btnBetweenPg";
            this.btnBetweenPg.Size = new System.Drawing.Size(13, 20);
            this.btnBetweenPg.TabIndex = 29;
            this.btnBetweenPg.Values.Text = ".";
            // 
            // TotalCount
            // 
            this.TotalCount.Location = new System.Drawing.Point(320, 446);
            this.TotalCount.Name = "TotalCount";
            this.TotalCount.Size = new System.Drawing.Size(13, 20);
            this.TotalCount.TabIndex = 29;
            this.TotalCount.Values.Text = ".";
            // 
            // ClassName
            // 
            this.ClassName.AllowDrop = true;
            this.ClassName.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ClassName.DropDownHeight = 180;
            this.ClassName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassName.DropDownWidth = 273;
            this.ClassName.IntegralHeight = false;
            this.ClassName.Location = new System.Drawing.Point(9, 35);
            this.ClassName.MinimumSize = new System.Drawing.Size(0, 30);
            this.ClassName.Name = "ClassName";
            this.ClassName.PaletteMode = Krypton.Toolkit.PaletteMode.Office2007White;
            this.ClassName.Size = new System.Drawing.Size(275, 30);
            this.ClassName.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.ClassName.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ClassName.StateCommon.ComboBox.Border.Rounding = 2F;
            this.ClassName.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClassName.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.ClassName.TabIndex = 30;
            this.ClassName.SelectionChangeCommitted += new System.EventHandler(this.ClassName_SelectionChangeCommitted);
            // 
            // section_streamType
            // 
            this.section_streamType.Location = new System.Drawing.Point(9, 92);
            this.section_streamType.MinimumSize = new System.Drawing.Size(0, 30);
            this.section_streamType.Name = "section_streamType";
            this.section_streamType.Size = new System.Drawing.Size(275, 30);
            this.section_streamType.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.section_streamType.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.section_streamType.StateCommon.Border.Rounding = 2F;
            this.section_streamType.TabIndex = 31;
            this.section_streamType.Visible = false;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(3, 70);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(83, 16);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 32;
            this.kryptonLabel3.Values.Text = "Stream Name";
            this.kryptonLabel3.Visible = false;
            // 
            // previousBtn
            // 
            this.previousBtn.Location = new System.Drawing.Point(134, 445);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(80, 25);
            this.previousBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.previousBtn.StateCommon.Border.Rounding = 1F;
            this.previousBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousBtn.TabIndex = 33;
            this.previousBtn.Values.Text = "< Prev";
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Location = new System.Drawing.Point(354, 445);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(80, 25);
            this.nextBtn.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nextBtn.StateCommon.Border.Rounding = 1F;
            this.nextBtn.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextBtn.TabIndex = 33;
            this.nextBtn.Values.Text = "Next >";
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // ClassAcademic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 478);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.section_streamType);
            this.Controls.Add(this.ClassName);
            this.Controls.Add(this.TotalCount);
            this.Controls.Add(this.btnBetweenPg);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.ClassSection);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.ClassDataGridView);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClassAcademic";
            this.Text = "ClassAcademic";
            this.Load += new System.EventHandler(this.ClassAcademic_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox ClassSection;
        private Krypton.Toolkit.KryptonDataGridView ClassDataGridView;
        private Krypton.Toolkit.KryptonButton Submit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private Krypton.Toolkit.KryptonButton btnPrevious;
        private Krypton.Toolkit.KryptonButton btnNext;
        private Krypton.Toolkit.KryptonLabel btnBetweenPg;
        private Krypton.Toolkit.KryptonLabel TotalCount;
        private Krypton.Toolkit.KryptonComboBox ClassName;
        private Krypton.Toolkit.KryptonTextBox section_streamType;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton previousBtn;
        private Krypton.Toolkit.KryptonButton nextBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamIdColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn StreamNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SectionNameColumn;
        private System.Windows.Forms.DataGridViewButtonColumn EditColumnButton;
        private System.Windows.Forms.DataGridViewButtonColumn DeleteColumnButton;
    }
}