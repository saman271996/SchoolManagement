using Krypton.Toolkit;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SchoolManagement.Helper.Helper;

namespace SchoolManagement
{
    public partial class Student_MainForm : Form
    {
        Form form;
       
        public Student_MainForm()
        {
            InitializeComponent();
        }

        private void Student_MainFormLoad(object sender, EventArgs e)
        {
           
            try
            {
                Student_Admission.Enabled = false;
                student_excel.Enabled = true;
                form = new Parents();
                form.TopLevel = false;
                Student_BodyPanel.Controls.Add(form);
                form.Show();
            }
            catch (Exception ex)
            {
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {

            Student_Admission.StateCommon.Back.Color1 = Color.RosyBrown;
            student_excel.StateCommon.Back.Color1 = Color.White;
            kryptonButton4.StateCommon.Back.Color1 = Color.White;
            form.Hide();
           
            Parents ps = new Parents();
            var studentTypes =Parents.SetValueForText1;
            if(studentTypes==1)
            {
                form = (Students)Application.OpenForms["Students"];
                if (form == null)
                {
                    form = new Students();
                }
                form.TopLevel = false;
                Student_BodyPanel.Controls.Add(form);
            }
            else if(studentTypes==2)
            {
                form = (Bulkstudent)Application.OpenForms["Bulkstudent"];
                if (form == null)
                {
                    form = new Bulkstudent();
                }
                form.TopLevel = false;
                Student_BodyPanel.Controls.Add(form);
            }
            form.Show();
        }

       

        private void kryptonButton3_Click(object sender, EventArgs e)
        {
            student_excel.StateCommon.Back.Color1 = Color.RosyBrown;
            Student_Admission.StateCommon.Back.Color1 = Color.White;
            kryptonButton4.StateCommon.Back.Color1 = Color.White;
            form.Hide();
            form = (StudentExcel)Application.OpenForms["StudentExcel"];
            if (form == null)
            {
                form = new StudentExcel();
            }
            form.TopLevel = false;
            Student_BodyPanel.Controls.Add(form);
            form.Show();
        }

     

        private void Parents_Click(object sender, EventArgs e)
        {
            kryptonButton4.StateCommon.Back.Color1 = Color.RosyBrown;
            student_excel.StateCommon.Back.Color1 = Color.White;
            Student_Admission.StateCommon.Back.Color1 = Color.White;
            try
            {
                form = (Parents)Application.OpenForms["Students"];
                //Application.OpenForms.OfType<Students>().First().Hide();

                form = (Parents)Application.OpenForms["Parents"];
                Application.OpenForms.OfType<Student_MainForm>().First().Student_BodyPanel.Dock = DockStyle.Fill;
                form.TopLevel = false;
                form.Visible = true;
                Application.OpenForms.OfType<Student_MainForm>().First().Student_BodyPanel.Controls.Add(form);
                form.BringToFront();
                form.Show();
                
            }
            catch (Exception ex)
            {
            }
        }

      
    }
}
