using System.Windows.Forms;

namespace SchoolManagement
{
    partial class AdminDashboard
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
            this.SuspendLayout();
            // 
            // AdminDashboard
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "AdminDashboard";
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonContextMenu kryptonContextMenu1;
        private Krypton.Navigator.KryptonPage kryptonPage1;
        private Timer menutransition;
        private Timer AcedmicTransition;
        private Timer AccountingTransition;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private PictureBox pictureBox3;
        private Label label3;
        private Label label2;
        private PictureBox pictureBox4;
        private Label label4;
        private Label label1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private Label label5;
        private Label label7;
        private Label label6;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel5;
        private PictureBox pictureBox7;
        private Label label8;
        private Label label9;
        private PictureBox pictureBox8;
        private Krypton.Toolkit.KryptonPanel kryptonPanel6;
        private PictureBox pictureBox9;
        private Label label10;
        private Label label11;
        private PictureBox pictureBox10;
        private Krypton.Toolkit.KryptonPanel kryptonPanel7;
        private PictureBox pictureBox11;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private Panel panel1;
        private Label label12;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private PictureBox pictureBox12;
        private Panel panel2;
        private PictureBox pictureBox13;
        private Label label13;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private DataGridViewTextBoxColumn Student;
        private DataGridViewTextBoxColumn Class;
        private DataGridViewTextBoxColumn InvoiceTitle;
        private DataGridViewTextBoxColumn TotalAmount;
        private DataGridViewTextBoxColumn PaidAmount;
        private DataGridViewTextBoxColumn Status;
        private DataGridViewTextBoxColumn Expenses;
        private DataGridViewTextBoxColumn Amount;
    }
}