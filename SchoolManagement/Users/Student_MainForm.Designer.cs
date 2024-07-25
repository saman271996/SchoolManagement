namespace SchoolManagement
{
    partial class Student_MainForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.kryptonButton4 = new Krypton.Toolkit.KryptonButton();
            this.Student_Admission = new Krypton.Toolkit.KryptonButton();
            this.student_excel = new Krypton.Toolkit.KryptonButton();
            this.Student_BodyPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.kryptonButton4);
            this.flowLayoutPanel1.Controls.Add(this.Student_Admission);
            this.flowLayoutPanel1.Controls.Add(this.student_excel);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(584, 36);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // kryptonButton4
            // 
            this.kryptonButton4.Location = new System.Drawing.Point(0, 0);
            this.kryptonButton4.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonButton4.Name = "kryptonButton4";
            this.kryptonButton4.Size = new System.Drawing.Size(194, 33);
            this.kryptonButton4.StateCommon.Back.Color1 = System.Drawing.Color.RosyBrown;
            this.kryptonButton4.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.kryptonButton4.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kryptonButton4.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton4.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonButton4.TabIndex = 27;
            this.kryptonButton4.Values.Text = "Parent Registration";
            this.kryptonButton4.Click += new System.EventHandler(this.Parents_Click);
            // 
            // Student_Admission
            // 
            this.Student_Admission.Location = new System.Drawing.Point(194, 0);
            this.Student_Admission.Margin = new System.Windows.Forms.Padding(0);
            this.Student_Admission.Name = "Student_Admission";
            this.Student_Admission.Size = new System.Drawing.Size(194, 33);
            this.Student_Admission.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.Student_Admission.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.Student_Admission.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.Student_Admission.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.Student_Admission.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Admission.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Student_Admission.TabIndex = 24;
            this.Student_Admission.Values.Text = "Student Admisssion";
            this.Student_Admission.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // student_excel
            // 
            this.student_excel.Location = new System.Drawing.Point(388, 0);
            this.student_excel.Margin = new System.Windows.Forms.Padding(0);
            this.student_excel.Name = "student_excel";
            this.student_excel.Size = new System.Drawing.Size(195, 33);
            this.student_excel.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.student_excel.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.student_excel.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.student_excel.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.student_excel.StateCommon.Content.LongText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_excel.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_excel.TabIndex = 26;
            this.student_excel.Values.Text = "Excel upload";
            this.student_excel.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // Student_BodyPanel
            // 
            this.Student_BodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Student_BodyPanel.Location = new System.Drawing.Point(0, 36);
            this.Student_BodyPanel.Margin = new System.Windows.Forms.Padding(0);
            this.Student_BodyPanel.Name = "Student_BodyPanel";
            this.Student_BodyPanel.Size = new System.Drawing.Size(584, 442);
            this.Student_BodyPanel.TabIndex = 1;
            // 
            // Student_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(584, 478);
            this.Controls.Add(this.Student_BodyPanel);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Student_MainForm";
            this.Text = "Student_MainForm";
            this.Load += new System.EventHandler(this.Student_MainFormLoad);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        public Krypton.Toolkit.KryptonButton Student_Admission;
        private Krypton.Toolkit.KryptonButton student_excel;
        public System.Windows.Forms.FlowLayoutPanel Student_BodyPanel;
        public Krypton.Toolkit.KryptonButton kryptonButton4;
    }
}