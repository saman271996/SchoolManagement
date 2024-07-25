using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using  SchoolManagement.HelperClasses;
using static SchoolManagement.Helper.Helper;

namespace SchoolManagement
{
    public partial class SchoolSatff : Form
    {
        SchoolManagementEntities dbContext = new SchoolManagementEntities();
        validations validates = new validations();
        public SchoolSatff()
        {
            InitializeComponent();
        }

        private void SchoolSatff_Load(object sender, EventArgs e)
        {
            SelectStaff.DisplayMember = "Key";
            SelectStaff.ValueMember = "Value";
            SelectStaff.DataSource = Enum.GetValues(typeof(SchoolStaffs));

            Gender.DisplayMember = "Key";
            Gender.ValueMember = "Value";
            Gender.DataSource = Enum.GetValues(typeof(SchoolStaffGender));

            LoadDataIntoClassComboBox();
            LoadDataIntoSubjectComboBox();
        }

        private void LoadDataIntoClassComboBox()
        {
            var selectClass = dbContext.Class_Section.AsEnumerable();
            TeacherSelectClass.Items.Clear();

            foreach (var select in selectClass)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = select.ClassName,
                    Value = select.ClassId
                };

                TeacherSelectClass.Items.Add(item);
            }
        }

        private void LoadDataIntoSubjectComboBox()
        {
            var selectSubject = dbContext.Subjects.AsEnumerable();
            TeacherSelectSubject.Items.Clear();

            foreach (var subject in selectSubject)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = subject.SubjectName,
                    Value = subject.SubjectId
                };

                TeacherSelectSubject.Items.Add(item);
            }
        }

        private void SelectStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SelectStaff.SelectedIndex == 0)
            {
                SelectStaffTeacherPanel.Visible = true;
                SelectStaffTeacherPanel.Visible = false;
            }
            else if (SelectStaff.SelectedIndex == 1)
            {
                SelectStaffTeacherPanel.Visible = true;
                SelectStaffTeacherPanel.Visible = false;
            }
            else if (SelectStaff.SelectedIndex == 2)
            {
                SelectStaffTeacherPanel.Visible = true;
                SelectStaffTeacherPanel.Visible = false;
            }
            else if (SelectStaff.SelectedIndex == 3)
            {
                SelectStaffTeacherPanel.Visible = false;
                SelectStaffTeacherPanel.Visible = true;
            }
            else if (SelectStaff.SelectedIndex == 4)
            {
                SelectStaffTeacherPanel.Visible = true;
                SelectStaffTeacherPanel.Visible = false;
            }
            else if (SelectStaff.SelectedIndex == 5)
            {
                SelectStaffTeacherPanel.Visible = true;
                SelectStaffTeacherPanel.Visible = false;
            }
        }

        private void TeacherSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                Random randomno = new Random();
                if (!dbContext.Users.Any(x => x.Email == Email.Text && x.PhoneNumber == PhoneNumber.Text && x.IsActive == true))
                {
                    if (FullName.Text.Trim().Length > 2 && PhoneNumber.Text.Trim().Length == 10)
                    {
                        var unique = FullName.Text.Substring(0, 2) + "" + PhoneNumber.Text.Substring(0, 4) + "" + randomno.Next(0, 1000000000) + randomno.Next(0, 800000000);
                        string[] names = FullName.Text.Trim().Split(new char[] { ' ' }, 2, StringSplitOptions.RemoveEmptyEntries);
                        string firstName = names.Length > 0 ? names[0] : "";
                        string lastName = names.Length > 1 ? names[1] : "";

                        var newUser = new User
                        {
                            UserName = firstName + " " + lastName,
                            Email = Email.Text,
                            PhoneNumber = PhoneNumber.Text,
                            SchoolUser = 0,//Admin user 
                                           //MenuRights = Globals.DefaultMenuRights,
                            UserType = 0,
                            IsActive = true,
                            IsDelete = false,
                            DateAdded = DateTime.Now,
                            DateModified = DateTime.Now,
                            Password = unique,
                        };

                        SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)TeacherSelectClass.SelectedItem;
                        SubjectClassDropdlist subjectClass = (SubjectClassDropdlist)TeacherSelectSubject.SelectedItem;

                        SchoolStaff schoolStaff = new SchoolStaff()
                        {
                            UserId = 0,
                            FirstName = firstName,
                            LastName = lastName,
                            Gender = Gender.Text,
                            Salary = Salary.Text,
                            Experience = Experience.Text,
                            Address = Address.Text,
                            BankName = BankName.Text,
                            AccountNumber = AccountNumber.Text,
                            IFSCCode = IFSCCode.Text,
                            BranchName = BranchName.Text,
                            ClassId = selectedClass.Value,
                            SubjectId = subjectClass.Value,
                            Designation = Designation.Text,
                            IsActive = true,
                            IsDelete = false,
                            DateAdded = DateTime.Now, 
                            DateModified = DateTime.Now,
                        };

                        var messages_subject = validates.ValidateSchoolStaff(schoolStaff, newUser);
                        if (messages_subject.Status == true)
                        {
                            MessageBox.Show(messages_subject.Message);
                        }
                        else
                        {
                            dbContext.SchoolStaffs.Add(schoolStaff);
                            dbContext.Users.Add(newUser);
                            dbContext.SaveChanges();
                            MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            Gender.SelectedIndex = -1;
                            FullName.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("Name should be more than two characters and Phone Number should be exact 10 digit.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        FullName.Focus();
                        PhoneNumber.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("User with the same Email, Phone Number, and active status already exists.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}