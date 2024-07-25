using SchoolManagement.Properties;
using System;
using System.Drawing;
using System.Linq;

namespace SchoolManagement
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.Name = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.Email = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.StudentType = new Krypton.Toolkit.KryptonComboBox();
            this.Class = new Krypton.Toolkit.KryptonLabel();
            this.kryptonComboBox1 = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.SelectSection = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.Birthday = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.Gender = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel8 = new Krypton.Toolkit.KryptonLabel();
            this.BloodGroup = new Krypton.Toolkit.KryptonComboBox();
            this.kryptonLabel9 = new Krypton.Toolkit.KryptonLabel();
            this.Phone = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel10 = new Krypton.Toolkit.KryptonLabel();
            this.Address = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Student_Register = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.StudentType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectSection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodGroup)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(22, 71);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(41, 17);
            this.kryptonLabel1.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 26;
            this.kryptonLabel1.Values.Text = "Name\r\n";
            // 
            // Name
            // 
            this.Name.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.Name.Location = new System.Drawing.Point(22, 92);
            this.Name.MinimumSize = new System.Drawing.Size(0, 30);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(250, 30);
            this.Name.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.Name.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Name.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Name.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Name.StateCommon.Border.Rounding = 2F;
            this.Name.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Name.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.TabIndex = 27;
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(287, 71);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(40, 17);
            this.kryptonLabel2.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel2.TabIndex = 28;
            this.kryptonLabel2.Values.Text = "Email\r\n";
            // 
            // Email
            // 
            this.Email.InputControlStyle = Krypton.Toolkit.InputControlStyle.Ribbon;
            this.Email.Location = new System.Drawing.Point(287, 92);
            this.Email.MinimumSize = new System.Drawing.Size(0, 30);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(275, 30);
            this.Email.StateActive.Content.Color1 = System.Drawing.Color.Black;
            this.Email.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Email.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Email.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Email.StateCommon.Border.Rounding = 2F;
            this.Email.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Email.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.TabIndex = 29;
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(22, 133);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(82, 16);
            this.kryptonLabel3.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel3.TabIndex = 30;
            this.kryptonLabel3.Values.Text = "Student Type";
            // 
            // StudentType
            // 
            this.StudentType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.StudentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentType.DropDownWidth = 347;
            this.StudentType.IntegralHeight = false;
            this.StudentType.Location = new System.Drawing.Point(22, 154);
            this.StudentType.MinimumSize = new System.Drawing.Size(0, 30);
            this.StudentType.Name = "StudentType";
            this.StudentType.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.StudentType.Size = new System.Drawing.Size(250, 30);
            this.StudentType.StateCommon.ComboBox.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.StudentType.StateCommon.ComboBox.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.StudentType.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StudentType.StateCommon.ComboBox.Border.Rounding = 2F;
            this.StudentType.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.StudentType.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentType.TabIndex = 33;
            // 
            // Class
            // 
            this.Class.Location = new System.Drawing.Point(22, 193);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(40, 16);
            this.Class.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.TabIndex = 34;
            this.Class.Values.Text = "Class";
            // 
            // kryptonComboBox1
            // 
            this.kryptonComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.kryptonComboBox1.DropDownWidth = 273;
            this.kryptonComboBox1.IntegralHeight = false;
            this.kryptonComboBox1.Location = new System.Drawing.Point(22, 213);
            this.kryptonComboBox1.MinimumSize = new System.Drawing.Size(0, 30);
            this.kryptonComboBox1.Name = "kryptonComboBox1";
            this.kryptonComboBox1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonComboBox1.Size = new System.Drawing.Size(250, 30);
            this.kryptonComboBox1.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonComboBox1.StateCommon.ComboBox.Border.Rounding = 2F;
            this.kryptonComboBox1.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonComboBox1.TabIndex = 35;
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(287, 252);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(51, 16);
            this.kryptonLabel5.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel5.TabIndex = 36;
            this.kryptonLabel5.Values.Text = "Section";
            // 
            // SelectSection
            // 
            this.SelectSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SelectSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectSection.DropDownWidth = 273;
            this.SelectSection.IntegralHeight = false;
            this.SelectSection.Location = new System.Drawing.Point(287, 274);
            this.SelectSection.MinimumSize = new System.Drawing.Size(0, 30);
            this.SelectSection.Name = "SelectSection";
            this.SelectSection.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.SelectSection.Size = new System.Drawing.Size(275, 30);
            this.SelectSection.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SelectSection.StateCommon.ComboBox.Border.Rounding = 2F;
            this.SelectSection.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectSection.TabIndex = 37;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(22, 252);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(56, 16);
            this.kryptonLabel6.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel6.TabIndex = 38;
            this.kryptonLabel6.Values.Text = "Birthday";
            // 
            // Birthday
            // 
            this.Birthday.AllowDrop = true;
            this.Birthday.AutoShift = true;
            this.Birthday.Location = new System.Drawing.Point(22, 274);
            this.Birthday.MinimumSize = new System.Drawing.Size(0, 30);
            this.Birthday.Name = "Birthday";
            this.Birthday.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Birthday.Size = new System.Drawing.Size(250, 30);
            this.Birthday.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Birthday.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Birthday.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Birthday.StateCommon.Border.Rounding = 2F;
            this.Birthday.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Birthday.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Birthday.TabIndex = 39;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(287, 193);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(50, 16);
            this.kryptonLabel7.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel7.TabIndex = 40;
            this.kryptonLabel7.Values.Text = "Gender";
            // 
            // Gender
            // 
            this.Gender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Gender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Gender.DropDownWidth = 273;
            this.Gender.IntegralHeight = false;
            this.Gender.Location = new System.Drawing.Point(287, 213);
            this.Gender.MinimumSize = new System.Drawing.Size(0, 30);
            this.Gender.Name = "Gender";
            this.Gender.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.Gender.Size = new System.Drawing.Size(275, 30);
            this.Gender.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Gender.StateCommon.ComboBox.Border.Rounding = 2F;
            this.Gender.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Gender.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.Gender.TabIndex = 41;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(287, 310);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(79, 16);
            this.kryptonLabel8.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel8.TabIndex = 42;
            this.kryptonLabel8.Values.Text = "Blood Group";
            // 
            // BloodGroup
            // 
            this.BloodGroup.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.BloodGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.BloodGroup.DropDownWidth = 273;
            this.BloodGroup.IntegralHeight = false;
            this.BloodGroup.Location = new System.Drawing.Point(287, 332);
            this.BloodGroup.MinimumSize = new System.Drawing.Size(0, 30);
            this.BloodGroup.Name = "BloodGroup";
            this.BloodGroup.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.BloodGroup.Size = new System.Drawing.Size(275, 30);
            this.BloodGroup.Sorted = true;
            this.BloodGroup.StateCommon.ComboBox.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.BloodGroup.StateCommon.ComboBox.Border.Rounding = 2F;
            this.BloodGroup.StateCommon.ComboBox.Content.Color1 = System.Drawing.Color.Black;
            this.BloodGroup.StateCommon.ComboBox.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BloodGroup.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.BloodGroup.TabIndex = 43;
            this.BloodGroup.SelectedIndexChanged += new System.EventHandler(this.BloodGroup_SelectedIndexChanged);
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(287, 133);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(45, 16);
            this.kryptonLabel9.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel9.TabIndex = 44;
            this.kryptonLabel9.Values.Text = "Phone";
            // 
            // Phone
            // 
            this.Phone.Location = new System.Drawing.Point(287, 154);
            this.Phone.MinimumSize = new System.Drawing.Size(0, 30);
            this.Phone.Name = "Phone";
            this.Phone.Size = new System.Drawing.Size(275, 30);
            this.Phone.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Phone.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Phone.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Phone.StateCommon.Border.Rounding = 2F;
            this.Phone.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Phone.StateCommon.Content.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone.TabIndex = 45;
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(22, 310);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(56, 16);
            this.kryptonLabel10.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel10.TabIndex = 46;
            this.kryptonLabel10.Values.Text = "Address";
            // 
            // Address
            // 
            this.Address.Location = new System.Drawing.Point(20, 332);
            this.Address.Multiline = true;
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(252, 53);
            this.Address.StateCommon.Border.Color1 = System.Drawing.SystemColors.ActiveBorder;
            this.Address.StateCommon.Border.Color2 = System.Drawing.SystemColors.ActiveBorder;
            this.Address.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Address.StateCommon.Border.Rounding = 2F;
            this.Address.StateCommon.Content.Color1 = System.Drawing.Color.Black;
            this.Address.TabIndex = 47;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(510, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 42);
            this.pictureBox1.TabIndex = 50;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Student_Register
            // 
            this.Student_Register.Location = new System.Drawing.Point(20, 391);
            this.Student_Register.Name = "Student_Register";
            this.Student_Register.Size = new System.Drawing.Size(107, 28);
            this.Student_Register.StateCommon.Back.Color1 = System.Drawing.Color.DodgerBlue;
            this.Student_Register.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Student_Register.StateCommon.Border.Rounding = 2F;
            this.Student_Register.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Register.TabIndex = 51;
            this.Student_Register.Values.Text = "Submit";
            this.Student_Register.Click += new System.EventHandler(this.StudentRegister_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(22, 23);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(111, 19);
            this.kryptonLabel4.StateCommon.LongText.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel4.TabIndex = 52;
            this.kryptonLabel4.Values.Text = "Student\'s Detail";
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 442);
            this.Controls.Add(this.kryptonLabel4);
            this.Controls.Add(this.Student_Register);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.kryptonLabel10);
            this.Controls.Add(this.Phone);
            this.Controls.Add(this.kryptonLabel9);
            this.Controls.Add(this.BloodGroup);
            this.Controls.Add(this.kryptonLabel8);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.kryptonLabel7);
            this.Controls.Add(this.Birthday);
            this.Controls.Add(this.kryptonLabel6);
            this.Controls.Add(this.SelectSection);
            this.Controls.Add(this.kryptonLabel5);
            this.Controls.Add(this.kryptonComboBox1);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.StudentType);
            this.Controls.Add(this.kryptonLabel3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.kryptonLabel2);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.kryptonLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            //this.Name = "Students";
            this.Text = "Student";
            this.Load += new System.EventHandler(this.Students_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StudentType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SelectSection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BloodGroup)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonTextBox Name;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonTextBox Email;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonComboBox StudentType;
        private Krypton.Toolkit.KryptonLabel Class;
        private Krypton.Toolkit.KryptonComboBox kryptonComboBox1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonComboBox SelectSection;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonDateTimePicker Birthday;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonComboBox Gender;
        private Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private Krypton.Toolkit.KryptonComboBox BloodGroup;
        private Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private Krypton.Toolkit.KryptonTextBox Phone;
        private Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private Krypton.Toolkit.KryptonTextBox Address;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private Krypton.Toolkit.KryptonButton Student_Register;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
    }
}