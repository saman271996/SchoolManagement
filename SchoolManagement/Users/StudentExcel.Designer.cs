namespace SchoolManagement
{
    partial class StudentExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentExcel));
            this.button1 = new System.Windows.Forms.Button();
            this.Upload = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StudentGridExcel = new Krypton.Toolkit.KryptonDataGridView();
            this.txtfilepath = new System.Windows.Forms.Label();
            this.recordlabel = new System.Windows.Forms.Label();
            this.kryptonPanel1 = new ComponentFactory.Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridExcel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(102, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(306, 36);
            this.button1.TabIndex = 0;
            this.button1.Text = "Choose file";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Upload
            // 
            this.Upload.BackColor = System.Drawing.Color.DodgerBlue;
            this.Upload.Location = new System.Drawing.Point(435, 100);
            this.Upload.Name = "Upload";
            this.Upload.Size = new System.Drawing.Size(121, 36);
            this.Upload.TabIndex = 2;
            this.Upload.Text = "Upload File";
            this.Upload.UseVisualStyleBackColor = false;
            this.Upload.Click += new System.EventHandler(this.Upload_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 36);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // StudentGridExcel
            // 
            this.StudentGridExcel.AllowUserToAddRows = false;
            this.StudentGridExcel.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.StudentGridExcel.Location = new System.Drawing.Point(12, 178);
            this.StudentGridExcel.Name = "StudentGridExcel";
            this.StudentGridExcel.Size = new System.Drawing.Size(544, 213);
            this.StudentGridExcel.StateCommon.Background.Color1 = System.Drawing.Color.White;
            this.StudentGridExcel.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.StudentGridExcel.TabIndex = 18;
            // 
            // txtfilepath
            // 
            this.txtfilepath.AutoSize = true;
            this.txtfilepath.Location = new System.Drawing.Point(109, 74);
            this.txtfilepath.Name = "txtfilepath";
            this.txtfilepath.Size = new System.Drawing.Size(0, 13);
            this.txtfilepath.TabIndex = 19;
            // 
            // recordlabel
            // 
            this.recordlabel.AutoSize = true;
            this.recordlabel.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recordlabel.Location = new System.Drawing.Point(170, 263);
            this.recordlabel.Name = "recordlabel";
            this.recordlabel.Size = new System.Drawing.Size(161, 22);
            this.recordlabel.TabIndex = 20;
            this.recordlabel.Text = "No Record Found";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(544, 54);
            this.kryptonPanel1.TabIndex = 21;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(12, 12);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(190, 22);
            this.kryptonLabel1.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Import Student Record ";
            // 
            // StudentExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(568, 403);
            this.Controls.Add(this.kryptonPanel1);
            this.Controls.Add(this.recordlabel);
            this.Controls.Add(this.txtfilepath);
            this.Controls.Add(this.StudentGridExcel);
            this.Controls.Add(this.Upload);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StudentExcel";
            this.Text = "StudentExcel";
            this.Load += new System.EventHandler(this.StudentExcel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StudentGridExcel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Upload;
        public Krypton.Toolkit.KryptonDataGridView StudentGridExcel;
        private System.Windows.Forms.Label txtfilepath;
        private System.Windows.Forms.Label recordlabel;
        private ComponentFactory.Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
    }
}