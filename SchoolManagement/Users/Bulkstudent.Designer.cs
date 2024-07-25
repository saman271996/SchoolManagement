namespace SchoolManagement
{
    partial class Bulkstudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bulkstudent));
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.SubmitRecord = new System.Windows.Forms.Button();
            this.Multistudent = new Krypton.Toolkit.KryptonDataGridView();
            this.StudentNames = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.StudentPhone = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.StudentEmails = new Krypton.Toolkit.KryptonDataGridViewTextBoxColumn();
            this.StudentType = new Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            this.StudentGenders = new Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            this.StudentParents = new Krypton.Toolkit.KryptonDataGridViewComboBoxColumn();
            this.Action = new System.Windows.Forms.DataGridViewImageColumn();
            this.AddMore = new System.Windows.Forms.Button();
            this.StudentGender = new Krypton.Toolkit.KryptonComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Email = new Krypton.Toolkit.KryptonTextBox();
            this.Phone = new Krypton.Toolkit.KryptonTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentTypes = new Krypton.Toolkit.KryptonComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentName = new Krypton.Toolkit.KryptonTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Section = new Krypton.Toolkit.KryptonComboBox();
            this.Class = new Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Multistudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Section)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.SubmitRecord);
            this.kryptonPanel1.Controls.Add(this.Multistudent);
            this.kryptonPanel1.Controls.Add(this.AddMore);
            this.kryptonPanel1.Controls.Add(this.StudentGender);
            this.kryptonPanel1.Controls.Add(this.label5);
            this.kryptonPanel1.Controls.Add(this.label4);
            this.kryptonPanel1.Controls.Add(this.Email);
            this.kryptonPanel1.Controls.Add(this.Phone);
            this.kryptonPanel1.Controls.Add(this.label3);
            this.kryptonPanel1.Controls.Add(this.StudentTypes);
            this.kryptonPanel1.Controls.Add(this.label2);
            this.kryptonPanel1.Controls.Add(this.StudentName);
            this.kryptonPanel1.Controls.Add(this.label1);
            this.kryptonPanel1.Controls.Add(this.Section);
            this.kryptonPanel1.Controls.Add(this.Class);
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(569, 399);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.Gainsboro;
            this.kryptonPanel1.TabIndex = 0;
            this.kryptonPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel1_Paint);
            // 
            // SubmitRecord
            // 
            this.SubmitRecord.BackColor = System.Drawing.Color.DodgerBlue;
            this.SubmitRecord.Location = new System.Drawing.Point(3, 363);
            this.SubmitRecord.Name = "SubmitRecord";
            this.SubmitRecord.Size = new System.Drawing.Size(116, 28);
            this.SubmitRecord.TabIndex = 18;
            this.SubmitRecord.Text = "Submit All Record";
            this.SubmitRecord.UseVisualStyleBackColor = false;
            this.SubmitRecord.Click += new System.EventHandler(this.SubmitRecord_Click);
            // 
            // Multistudent
            // 
            this.Multistudent.AllowUserToAddRows = false;
            this.Multistudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentNames,
            this.StudentPhone,
            this.StudentEmails,
            this.StudentType,
            this.StudentGenders,
            this.StudentParents,
            this.Action});
            this.Multistudent.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.Multistudent.Location = new System.Drawing.Point(3, 230);
            this.Multistudent.Name = "Multistudent";
            this.Multistudent.Size = new System.Drawing.Size(566, 127);
            this.Multistudent.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.Multistudent.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.Multistudent.TabIndex = 17;
            this.Multistudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Multistudent_CellContentClick);
            // 
            // StudentNames
            // 
            this.StudentNames.DataPropertyName = "Multistudent_RowsRemoved";
            this.StudentNames.HeaderText = "Name";
            this.StudentNames.Name = "StudentNames";
            this.StudentNames.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentNames.Width = 100;
            // 
            // StudentPhone
            // 
            this.StudentPhone.HeaderText = "Phone";
            this.StudentPhone.Name = "StudentPhone";
            this.StudentPhone.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentPhone.Width = 100;
            // 
            // StudentEmails
            // 
            this.StudentEmails.HeaderText = "Email";
            this.StudentEmails.Name = "StudentEmails";
            this.StudentEmails.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.StudentEmails.Width = 100;
            // 
            // StudentType
            // 
            this.StudentType.DataSource = null;
            this.StudentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentType.DropDownWidth = 121;
            this.StudentType.HeaderText = "Type";
            this.StudentType.Name = "StudentType";
            this.StudentType.Width = 100;
            // 
            // StudentGenders
            // 
            this.StudentGenders.DataSource = null;
            this.StudentGenders.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentGenders.DropDownWidth = 121;
            this.StudentGenders.HeaderText = "Gender";
            this.StudentGenders.Name = "StudentGenders";
            this.StudentGenders.Width = 100;
            // 
            // StudentParents
            // 
            this.StudentParents.DataSource = null;
            this.StudentParents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentParents.DropDownWidth = 121;
            this.StudentParents.HeaderText = "Parent";
            this.StudentParents.Name = "StudentParents";
            this.StudentParents.Width = 100;
            // 
            // Action
            // 
            this.Action.HeaderText = "";
            this.Action.Image = ((System.Drawing.Image)(resources.GetObject("Action.Image")));
            this.Action.Name = "Action";
            this.Action.ReadOnly = true;
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.ToolTipText = "Delete";
            // 
            // AddMore
            // 
            this.AddMore.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.AddMore.Location = new System.Drawing.Point(169, 174);
            this.AddMore.Name = "AddMore";
            this.AddMore.Size = new System.Drawing.Size(75, 23);
            this.AddMore.TabIndex = 16;
            this.AddMore.Text = "Add More";
            this.AddMore.UseVisualStyleBackColor = false;
            this.AddMore.Click += new System.EventHandler(this.Addmore_Click);
            // 
            // StudentGender
            // 
            this.StudentGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.StudentGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentGender.DropDownWidth = 109;
            this.StudentGender.IntegralHeight = false;
            this.StudentGender.Location = new System.Drawing.Point(12, 174);
            this.StudentGender.Name = "StudentGender";
            this.StudentGender.Size = new System.Drawing.Size(130, 21);
            this.StudentGender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.StudentGender.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Student Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Email";
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(284, 110);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(130, 23);
            this.Email.TabIndex = 9;
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(148, 110);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(130, 23);
            this.Phone.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(148, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone No";
            // 
            // StudentTypes
            // 
            this.StudentTypes.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.StudentTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentTypes.DropDownWidth = 109;
            this.StudentTypes.IntegralHeight = false;
            this.StudentTypes.Location = new System.Drawing.Point(422, 110);
            this.StudentTypes.Name = "StudentTypes";
            this.StudentTypes.Size = new System.Drawing.Size(130, 21);
            this.StudentTypes.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.StudentTypes.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(422, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Student Type";
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(12, 110);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(130, 23);
            this.StudentName.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Student Name";
            // 
            // Section
            // 
            this.Section.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Section.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Section.DropDownWidth = 172;
            this.Section.IntegralHeight = false;
            this.Section.Location = new System.Drawing.Point(299, 23);
            this.Section.Name = "Section";
            this.Section.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Section.Size = new System.Drawing.Size(200, 20);
            this.Section.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Section.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.Section.TabIndex = 1;
            // 
            // Class
            // 
            this.Class.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Class.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Class.DropDownWidth = 200;
            this.Class.IntegralHeight = false;
            this.Class.Location = new System.Drawing.Point(12, 23);
            this.Class.MinimumSize = new System.Drawing.Size(0, 20);
            this.Class.Name = "Class";
            this.Class.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Class.Size = new System.Drawing.Size(200, 20);
            this.Class.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.Class.TabIndex = 0;
            // 
            // Bulkstudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 403);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Bulkstudent";
            this.Text = "Bulkstudent";
            this.Load += new System.EventHandler(this.BulkStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Multistudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Section)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Class)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonComboBox Section;
        private Krypton.Toolkit.KryptonComboBox Class;
        private Krypton.Toolkit.KryptonComboBox StudentTypes;
        private System.Windows.Forms.Label label2;
        private Krypton.Toolkit.KryptonTextBox StudentName;
        private System.Windows.Forms.Label label1;
        private Krypton.Toolkit.KryptonTextBox Email;
        private Krypton.Toolkit.KryptonTextBox Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private Krypton.Toolkit.KryptonComboBox StudentGender;
        private System.Windows.Forms.Button AddMore;
        private Krypton.Toolkit.KryptonDataGridView Multistudent;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn StudentNames;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn StudentPhone;
        private Krypton.Toolkit.KryptonDataGridViewTextBoxColumn StudentEmails;
        private Krypton.Toolkit.KryptonDataGridViewComboBoxColumn StudentType;
        private Krypton.Toolkit.KryptonDataGridViewComboBoxColumn StudentGenders;
        private Krypton.Toolkit.KryptonDataGridViewComboBoxColumn StudentParents;
        private System.Windows.Forms.DataGridViewImageColumn Action;
        private System.Windows.Forms.Button SubmitRecord;
    }
}