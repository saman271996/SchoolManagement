namespace SchoolManagement
{
    partial class MainLayoutForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainLayoutForm));
            this.UserPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.userclick = new System.Windows.Forms.Button();
            this.Student = new System.Windows.Forms.Button();
            this.Teacher_Staff = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Acedmic = new System.Windows.Forms.Button();
            this.Daily_attandance = new System.Windows.Forms.Button();
            this.Syllabus = new System.Windows.Forms.Button();
            this.Subject = new System.Windows.Forms.Button();
            this.Class = new System.Windows.Forms.Button();
            this.Class_Routine = new System.Windows.Forms.Button();
            this.Department = new System.Windows.Forms.Button();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Accounting = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.HeaderPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Dashboard = new System.Windows.Forms.Button();
            this.Sidepanel = new Krypton.Toolkit.KryptonPanel();
            this.MainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonContextMenu1 = new Krypton.Toolkit.KryptonContextMenu();
            this.menutransition = new System.Windows.Forms.Timer(this.components);
            this.AcedmicTransition = new System.Windows.Forms.Timer(this.components);
            this.AccountingTransition = new System.Windows.Forms.Timer(this.components);
            this.UserPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sidepanel)).BeginInit();
            this.SuspendLayout();
            // 
            // UserPanel
            // 
            this.UserPanel.Controls.Add(this.userclick);
            this.UserPanel.Controls.Add(this.Student);
            this.UserPanel.Controls.Add(this.Teacher_Staff);
            this.UserPanel.Location = new System.Drawing.Point(3, 99);
            this.UserPanel.Name = "UserPanel";
            this.UserPanel.Size = new System.Drawing.Size(201, 40);
            this.UserPanel.TabIndex = 13;
            // 
            // userclick
            // 
            this.userclick.BackColor = System.Drawing.Color.White;
            this.userclick.FlatAppearance.BorderSize = 0;
            this.userclick.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userclick.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userclick.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(74)))), ((int)(((byte)(93)))));
            this.userclick.Image = ((System.Drawing.Image)(resources.GetObject("userclick.Image")));
            this.userclick.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.userclick.Location = new System.Drawing.Point(0, 0);
            this.userclick.Margin = new System.Windows.Forms.Padding(0);
            this.userclick.Name = "userclick";
            this.userclick.Size = new System.Drawing.Size(201, 40);
            this.userclick.TabIndex = 3;
            this.userclick.Text = "  User";
            this.userclick.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.userclick.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.userclick.UseVisualStyleBackColor = false;
            this.userclick.Click += new System.EventHandler(this.userclick_Click);
            // 
            // Student
            // 
            this.Student.BackColor = System.Drawing.Color.White;
            this.Student.FlatAppearance.BorderSize = 0;
            this.Student.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Student.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(74)))), ((int)(((byte)(93)))));
            this.Student.Image = ((System.Drawing.Image)(resources.GetObject("Student.Image")));
            this.Student.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Student.Location = new System.Drawing.Point(0, 40);
            this.Student.Margin = new System.Windows.Forms.Padding(0);
            this.Student.Name = "Student";
            this.Student.Size = new System.Drawing.Size(201, 40);
            this.Student.TabIndex = 5;
            this.Student.Text = "  Student ";
            this.Student.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Student.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Student.UseVisualStyleBackColor = false;
            this.Student.Click += new System.EventHandler(this.Student_Click);
            // 
            // Teacher_Staff
            // 
            this.Teacher_Staff.BackColor = System.Drawing.Color.White;
            this.Teacher_Staff.FlatAppearance.BorderSize = 0;
            this.Teacher_Staff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Teacher_Staff.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Teacher_Staff.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(74)))), ((int)(((byte)(93)))));
            this.Teacher_Staff.Image = ((System.Drawing.Image)(resources.GetObject("Teacher_Staff.Image")));
            this.Teacher_Staff.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Teacher_Staff.Location = new System.Drawing.Point(0, 80);
            this.Teacher_Staff.Margin = new System.Windows.Forms.Padding(0);
            this.Teacher_Staff.Name = "Teacher_Staff";
            this.Teacher_Staff.Size = new System.Drawing.Size(201, 40);
            this.Teacher_Staff.TabIndex = 5;
            this.Teacher_Staff.Text = "  Teacher/Staff";
            this.Teacher_Staff.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Teacher_Staff.UseVisualStyleBackColor = false;
            this.Teacher_Staff.Click += new System.EventHandler(this.Teacher_Staff_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.Acedmic);
            this.flowLayoutPanel1.Controls.Add(this.Daily_attandance);
            this.flowLayoutPanel1.Controls.Add(this.Syllabus);
            this.flowLayoutPanel1.Controls.Add(this.Subject);
            this.flowLayoutPanel1.Controls.Add(this.Class);
            this.flowLayoutPanel1.Controls.Add(this.Class_Routine);
            this.flowLayoutPanel1.Controls.Add(this.Department);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 145);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(188, 40);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // Acedmic
            // 
            this.Acedmic.AllowDrop = true;
            this.Acedmic.BackColor = System.Drawing.Color.White;
            this.Acedmic.FlatAppearance.BorderSize = 0;
            this.Acedmic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Acedmic.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Acedmic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Acedmic.Image = ((System.Drawing.Image)(resources.GetObject("Acedmic.Image")));
            this.Acedmic.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Acedmic.Location = new System.Drawing.Point(0, 0);
            this.Acedmic.Margin = new System.Windows.Forms.Padding(0);
            this.Acedmic.Name = "Acedmic";
            this.Acedmic.Size = new System.Drawing.Size(201, 40);
            this.Acedmic.TabIndex = 9;
            this.Acedmic.Text = "  Acedmic";
            this.Acedmic.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Acedmic.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Acedmic.UseVisualStyleBackColor = false;
            this.Acedmic.Click += new System.EventHandler(this.Acedmic_Click);
            // 
            // Daily_attandance
            // 
            this.Daily_attandance.AllowDrop = true;
            this.Daily_attandance.BackColor = System.Drawing.Color.White;
            this.Daily_attandance.FlatAppearance.BorderSize = 0;
            this.Daily_attandance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Daily_attandance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Daily_attandance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Daily_attandance.Image = ((System.Drawing.Image)(resources.GetObject("Daily_attandance.Image")));
            this.Daily_attandance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Daily_attandance.Location = new System.Drawing.Point(0, 40);
            this.Daily_attandance.Margin = new System.Windows.Forms.Padding(0);
            this.Daily_attandance.Name = "Daily_attandance";
            this.Daily_attandance.Size = new System.Drawing.Size(201, 40);
            this.Daily_attandance.TabIndex = 6;
            this.Daily_attandance.Text = "  Daily Attandance";
            this.Daily_attandance.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Daily_attandance.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Daily_attandance.UseVisualStyleBackColor = false;
            this.Daily_attandance.Click += new System.EventHandler(this.button2_Click);
            // 
            // Syllabus
            // 
            this.Syllabus.AllowDrop = true;
            this.Syllabus.BackColor = System.Drawing.Color.White;
            this.Syllabus.FlatAppearance.BorderSize = 0;
            this.Syllabus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Syllabus.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Syllabus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Syllabus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Syllabus.Location = new System.Drawing.Point(0, 80);
            this.Syllabus.Margin = new System.Windows.Forms.Padding(0);
            this.Syllabus.Name = "Syllabus";
            this.Syllabus.Size = new System.Drawing.Size(201, 40);
            this.Syllabus.TabIndex = 9;
            this.Syllabus.Text = "  Syllabus";
            this.Syllabus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Syllabus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Syllabus.UseVisualStyleBackColor = false;
            this.Syllabus.Click += new System.EventHandler(this.button10_Click);
            // 
            // Subject
            // 
            this.Subject.AllowDrop = true;
            this.Subject.BackColor = System.Drawing.Color.White;
            this.Subject.FlatAppearance.BorderSize = 0;
            this.Subject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Subject.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Subject.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Subject.Image = ((System.Drawing.Image)(resources.GetObject("Subject.Image")));
            this.Subject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Subject.Location = new System.Drawing.Point(0, 120);
            this.Subject.Margin = new System.Windows.Forms.Padding(0);
            this.Subject.Name = "Subject";
            this.Subject.Size = new System.Drawing.Size(201, 40);
            this.Subject.TabIndex = 8;
            this.Subject.Text = "  Subject";
            this.Subject.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Subject.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Subject.UseVisualStyleBackColor = false;
            this.Subject.Click += new System.EventHandler(this.button8_Click);
            // 
            // Class
            // 
            this.Class.AllowDrop = true;
            this.Class.BackColor = System.Drawing.Color.White;
            this.Class.FlatAppearance.BorderSize = 0;
            this.Class.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Class.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Class.Image = ((System.Drawing.Image)(resources.GetObject("Class.Image")));
            this.Class.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Class.Location = new System.Drawing.Point(0, 160);
            this.Class.Margin = new System.Windows.Forms.Padding(0);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(201, 40);
            this.Class.TabIndex = 10;
            this.Class.Text = "  Class";
            this.Class.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Class.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Class.UseVisualStyleBackColor = false;
            this.Class.Click += new System.EventHandler(this.button12_Click);
            // 
            // Class_Routine
            // 
            this.Class_Routine.AllowDrop = true;
            this.Class_Routine.BackColor = System.Drawing.Color.White;
            this.Class_Routine.FlatAppearance.BorderSize = 0;
            this.Class_Routine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Class_Routine.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Class_Routine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Class_Routine.Image = ((System.Drawing.Image)(resources.GetObject("Class_Routine.Image")));
            this.Class_Routine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Class_Routine.Location = new System.Drawing.Point(0, 200);
            this.Class_Routine.Margin = new System.Windows.Forms.Padding(0);
            this.Class_Routine.Name = "Class_Routine";
            this.Class_Routine.Size = new System.Drawing.Size(201, 40);
            this.Class_Routine.TabIndex = 7;
            this.Class_Routine.Text = "  Class Routine";
            this.Class_Routine.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Class_Routine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Class_Routine.UseVisualStyleBackColor = false;
            this.Class_Routine.Click += new System.EventHandler(this.button4_Click);
            // 
            // Department
            // 
            this.Department.AllowDrop = true;
            this.Department.BackColor = System.Drawing.Color.White;
            this.Department.FlatAppearance.BorderSize = 0;
            this.Department.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Department.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Department.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Department.Image = ((System.Drawing.Image)(resources.GetObject("Department.Image")));
            this.Department.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Department.Location = new System.Drawing.Point(0, 240);
            this.Department.Margin = new System.Windows.Forms.Padding(0);
            this.Department.Name = "Department";
            this.Department.Size = new System.Drawing.Size(201, 40);
            this.Department.TabIndex = 11;
            this.Department.Text = "  Department";
            this.Department.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Department.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Department.UseVisualStyleBackColor = false;
            this.Department.Click += new System.EventHandler(this.button14_Click);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.Accounting);
            this.flowLayoutPanel3.Controls.Add(this.button16);
            this.flowLayoutPanel3.Controls.Add(this.button17);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(0, 188);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(201, 40);
            this.flowLayoutPanel3.TabIndex = 14;
            // 
            // Accounting
            // 
            this.Accounting.AllowDrop = true;
            this.Accounting.BackColor = System.Drawing.Color.White;
            this.Accounting.FlatAppearance.BorderSize = 0;
            this.Accounting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Accounting.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accounting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Accounting.Image = ((System.Drawing.Image)(resources.GetObject("Accounting.Image")));
            this.Accounting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Accounting.Location = new System.Drawing.Point(2, 0);
            this.Accounting.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.Accounting.Name = "Accounting";
            this.Accounting.Size = new System.Drawing.Size(198, 40);
            this.Accounting.TabIndex = 5;
            this.Accounting.Text = "  Accounting";
            this.Accounting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Accounting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Accounting.UseVisualStyleBackColor = false;
            this.Accounting.Click += new System.EventHandler(this.Accounting_Click);
            // 
            // button16
            // 
            this.button16.AllowDrop = true;
            this.button16.BackColor = System.Drawing.Color.White;
            this.button16.FlatAppearance.BorderSize = 0;
            this.button16.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button16.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.Location = new System.Drawing.Point(0, 40);
            this.button16.Margin = new System.Windows.Forms.Padding(0);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(201, 40);
            this.button16.TabIndex = 6;
            this.button16.Text = "  Student Fee Manager";
            this.button16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button16.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button16.UseVisualStyleBackColor = false;
            this.button16.UseWaitCursor = true;
            // 
            // button17
            // 
            this.button17.AllowDrop = true;
            this.button17.BackColor = System.Drawing.Color.White;
            this.button17.FlatAppearance.BorderSize = 0;
            this.button17.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button17.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.button17.Image = ((System.Drawing.Image)(resources.GetObject("button17.Image")));
            this.button17.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.Location = new System.Drawing.Point(0, 80);
            this.button17.Margin = new System.Windows.Forms.Padding(0);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(201, 40);
            this.button17.TabIndex = 7;
            this.button17.Text = "  Expense Manager";
            this.button17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button17.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button17.UseVisualStyleBackColor = false;
            this.button17.UseWaitCursor = true;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.pictureBox2);
            this.HeaderPanel.Controls.Add(this.Dashboard);
            this.HeaderPanel.Controls.Add(this.UserPanel);
            this.HeaderPanel.Controls.Add(this.flowLayoutPanel1);
            this.HeaderPanel.Controls.Add(this.flowLayoutPanel3);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(210, 537);
            this.HeaderPanel.TabIndex = 10;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(201, 56);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // Dashboard
            // 
            this.Dashboard.BackColor = System.Drawing.Color.White;
            this.Dashboard.FlatAppearance.BorderSize = 0;
            this.Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Dashboard.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dashboard.Image = ((System.Drawing.Image)(resources.GetObject("Dashboard.Image")));
            this.Dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.Location = new System.Drawing.Point(0, 56);
            this.Dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.Dashboard.Name = "Dashboard";
            this.Dashboard.Size = new System.Drawing.Size(201, 40);
            this.Dashboard.TabIndex = 0;
            this.Dashboard.Text = "  Dashboard";
            this.Dashboard.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Dashboard.UseVisualStyleBackColor = false;
            this.Dashboard.Click += new System.EventHandler(this.Dashboard_Click);
            // 
            // Sidepanel
            // 
            this.Sidepanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.Sidepanel.Location = new System.Drawing.Point(210, 0);
            this.Sidepanel.Margin = new System.Windows.Forms.Padding(0);
            this.Sidepanel.Name = "Sidepanel";
            this.Sidepanel.Size = new System.Drawing.Size(574, 59);
            this.Sidepanel.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.Sidepanel.TabIndex = 11;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(210, 59);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(574, 478);
            this.MainPanel.TabIndex = 0;
            // 
            // menutransition
            // 
            this.menutransition.Tick += new System.EventHandler(this.menutransition_Tick);
            // 
            // AcedmicTransition
            // 
            this.AcedmicTransition.Tick += new System.EventHandler(this.AcedmicTransition_Tick);
            // 
            // AccountingTransition
            // 
            this.AccountingTransition.Tick += new System.EventHandler(this.AccountingTransition_Tick);
            // 
            // MainLayoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 537);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Sidepanel);
            this.Controls.Add(this.HeaderPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainLayoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainLayoutForm";
            this.Load += new System.EventHandler(this.MainLayoutForm_Load);
            this.UserPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Sidepanel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button Dashboard;
        private System.Windows.Forms.FlowLayoutPanel UserPanel;
        private System.Windows.Forms.Button userclick;
        private System.Windows.Forms.Button Student;
        private System.Windows.Forms.Button Teacher_Staff;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button Acedmic;
        private System.Windows.Forms.Button Daily_attandance;
        private System.Windows.Forms.Button Syllabus;
        private System.Windows.Forms.Button Subject;
        private System.Windows.Forms.Button Class;
        private System.Windows.Forms.Button Class_Routine;
        private System.Windows.Forms.Button Department;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button Accounting;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.FlowLayoutPanel HeaderPanel;
        private Krypton.Toolkit.KryptonPanel Sidepanel;
        public System.Windows.Forms.FlowLayoutPanel MainPanel;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private System.Windows.Forms.Timer menutransition;
        private System.Windows.Forms.Timer AcedmicTransition;
        private System.Windows.Forms.Timer AccountingTransition;
    }
}