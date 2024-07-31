using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static SchoolManagement.Helper.Helper;

namespace SchoolManagement
{
    public partial class Students : Form
    {
        SchoolManagementEntities Db = new SchoolManagementEntities();
        Helper.Helper helper = new Helper.Helper();
        validations validates = new validations(); 
        Form form;
        public Students()
        {
            InitializeComponent();

        }


        //single student register
        private void StudentRegister_Click(object sender, EventArgs e)
        {

            Random r = new Random();
            
            var password =Name.Text.Substring(0, 2) + Phone.Text.Substring(0, 4) + r.Next(0, 1000000000);
            var studentid = Name.Text.Substring(0, 2) + r.Next(0, 1000000000) + r.Next(0, 100000000);
            try
            {
                var studenttype = StudentType.Text;
                if (string.IsNullOrEmpty(studenttype))
                {
                    studenttype = "0";
                }
                var StudentTyped = Convert.ToInt32(studenttype);
                if (StudentTyped == null)
                {
                    MessageBox.Show("Please Select Student Type");
                    return;
                }

                //validate
                var students = new Student
                {
                    StudentId = studentid,
                    Name = Name.Text,
                    Email = Email.Text,
                    PhoneNumber = Phone.Text,
                    StudentType = StudentTyped,
                    ParentId = GlobalAccount.ParentId,
                    SchoolId = Convert.ToInt32(GlobalAccount.SchoolId),
                    ClassId = 1,
                    SectionId = 1,
                    Birthday = DateTime.Now,
                    Gender = Gender.Text,
                    BloodGroup = BloodGroup.Text,
                    Address = Address.Text,
                    IsActive = true,
                    Isdelete = false,
                    DateAdded = DateTime.Now,
                    DateModified = DateTime.Now,
                    Password = password,
                };
                var messages_students = validates.ValidateStudents(students);
                if (messages_students.Status != false)
                {
                    MessageBox.Show(messages_students.Message);
                    return;
                }
                else
                {
                    var schoolsemailcheck = Db.Students.AsNoTracking().FirstOrDefault(x => x.Email.Trim() == Email.Text.Trim() || x.PhoneNumber == Phone.Text)?.Email;
                    if ((string.IsNullOrEmpty(schoolsemailcheck)))
                    {
                        if (!Db.Parents.Any(x => (x.FathersMailId == ParentAccount.FathersMailId || x.FathersMobileNumber == ParentAccount.FathersMobileNumber || x.MothersMailId == ParentAccount.MothersMailId || x.MothersMobileNumber == ParentAccount.MothersMobileNumber) && x.IsActive == true))
                        {
                            var parents = new Parent
                            {
                                ParentId = ParentAccount.ParentId,
                                SchoolId = ParentAccount.SchoolId,
                                FathersName = ParentAccount.FathersName,
                                MothersName = ParentAccount.MothersName,
                                FathersMailId = ParentAccount.FathersMailId,
                                MothersMailId = ParentAccount.MothersMailId,
                                FathersMobileNumber = ParentAccount.FathersMobileNumber,
                                MothersMobileNumber = ParentAccount.MothersMobileNumber,
                                FathersOccupation = ParentAccount.FathersOccupation,
                                MothersOccupation = ParentAccount.MothersOccupation,
                                FathersBloodGroup = ParentAccount.FathersBloodGroup,
                                MothersBloodGroup = ParentAccount.MothersBloodGroup,
                                Address = ParentAccount.Address,
                                Password = ParentAccount.Password,
                            };
                            Db.Parents.Add(parents);
                            Db.SaveChanges();

                        }

                        Db.Students.Add(students);
                        Db.SaveChanges();
                        MessageBox.Show("Student is register successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Already student is register");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show("Something went wrong,if problem continue occurs,please contact to Singhtek!");
                return;
            }
        }

        private void Students_Load(object sender, EventArgs e)
        {
            form = new Students();
            //Blood group bind
            BloodGroup.DisplayMember = "Key";
            BloodGroup.ValueMember = "Value";
            BloodGroup.DataSource = Enum.GetValues(typeof(BloodGroups));

            //gender bind
            Gender.DisplayMember = "Key";
            Gender.ValueMember = "Value";
            Gender.DataSource = Enum.GetValues(typeof(Gender));

        }

        private void BloodGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Image_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Set the initial directory (optional)
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

                // Set the filter for the file extension and default file type
                //openFileDialog.Filter = "JPG Files (*.jpg)|*.jpg|All Files (*.*)|*.*";

                // Show the dialog and get the selected file path
                DialogResult result = openFileDialog.ShowDialog();

                if (result == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
