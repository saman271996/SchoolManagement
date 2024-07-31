using Krypton.Toolkit;
using SchoolManagement.Helper;
using SchoolManagement.HelperClasses;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace SchoolManagement
{
    public partial class Login : Form
    {
        SchoolManagementEntities Db = new SchoolManagementEntities();
        Form frm;
        public Login()
        {
            InitializeComponent();
            UserType.Text = "0";
        }
        private void Login_Load(object sender, EventArgs e)
        {
          
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pictureBox2.BackColor = Color.White;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            label_loginheading.Text = "Manager Login";
            UserType.Text = "1";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            pictureBox3.BackColor = Color.White;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox3.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            label_loginheading.Text = "Reception Login";
            UserType.Text = "1";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            pictureBox4.BackColor = Color.White;
            pictureBox1.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox4.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            label_loginheading.Text = "Staff Login";
            UserType.Text = "2";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.White;
            pictureBox2.BackColor = Color.Transparent;
            pictureBox3.BackColor = Color.Transparent;
            pictureBox4.BackColor = Color.Transparent;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox2.BorderStyle = BorderStyle.None;
            pictureBox3.BorderStyle = BorderStyle.None;
            pictureBox4.BorderStyle = BorderStyle.None;
            label_loginheading.Text = "Admin Login";
            UserType.Text = "0";

        }
        public void setpicturecolor(int color)
        {

        }

        private void Login_submit_Click(object sender, EventArgs e)
        {
            var message = "";
            try
            {
                var users = Db.Users.AsNoTracking().FirstOrDefault(x => x.IsActive == true && x.IsDelete == false && (x.Email == Email_Mobile.Text || x.PhoneNumber == Email_Mobile.Text));
                if (users == null)
                {
                    MessageBox.Show("Invalid UserName or Password");
                    return;
                }

                else
                {
                    var schooldetail = Db.SchoolDetails.AsNoTracking().FirstOrDefault(x => x.Id == users.SchoolId);
                    if (schooldetail != null)
                    {

                       GlobalAccount.SchoolId = users.SchoolId;
                       GlobalAccount.UserId = users.UserId;
                       
                        if (users.UserType == Convert.ToInt32(UserType.Text))
                        {
                            this.Hide();
                            frm = new MainLayoutForm();
                            frm.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid UserName or Password");
                        return;
                    }
                }

            }

            catch (Exception ex)
            {

                message = "Please check your internet connection. If issue still continues, contact Variable Soft.";
                return;
            }

        }

        private void Email_Mobile_Enter(object sender, EventArgs e)
        {
            if (Email_Mobile.Text == "Email/Mobile")
            {
                Email_Mobile.Text = "";
            }
        }

        private void Email_Mobile_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Email_Mobile.Text))
            {
                Email_Mobile.Text = "Email/Mobile";
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Password.Text))
            {
                Password.Text = "Password";
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {

            if (Password.Text == "Password")
            {
                Password.Text = "";
            }
        }
    }
}



