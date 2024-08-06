using DocumentFormat.OpenXml.VariantTypes;
using Microsoft.VisualBasic.ApplicationServices;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SchoolManagement.Helper.Helper;
using static System.Net.WebRequestMethods;

namespace SchoolManagement.Academic
{
    public partial class ClassPeriod : Form
    {
        private int subjectId;
        private SchoolManagementEntities1 dbContext = new SchoolManagementEntities1();
        validations validate = new validations();
        public ClassPeriod()
        {
            InitializeComponent();
        }

        private void ClassPeriod_Load(object sender, EventArgs e)
        {
            ClassDataIntoComboBox();
            SectionDataIntoComboBox(GetSelectedClassId());
            SchoolStaffDataIntoComboBox(GetSelectedClassId());

            PeriodDataGridView.Visible = false;
            Submit.Visible = false;
        }

        private void ClassDataIntoComboBox()
        {
            var selectClass = dbContext.Classes.Where(s => s.Isdelete != true).AsEnumerable();
            classSelect.Items.Clear();

            foreach (var select in selectClass)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = select.ClassName,
                    Value = select.ClassId,
                };

                classSelect.Items.Add(item);
            }
        }

        private void SectionDataIntoComboBox(int classId)
        {
            var selectClass_Section = dbContext.Class_Section.Where(s => s.IsDelete != true && s.ClassId == classId).AsEnumerable();
            sectionSelect.Items.Clear();

            foreach (var select in selectClass_Section)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = select.SectionName,
                    Values = select.SectionId,
                };

                sectionSelect.Items.Add(item);
            }
        }

        private void SchoolStaffDataIntoComboBox(int classId)
        {
            var selectSchoolStaff = dbContext.SchoolStaffs.Where(s => s.IsDelete != true && s.ClassId == classId).AsEnumerable();
            teacherSelect.Items.Clear();

            foreach (var selectStaff in selectSchoolStaff)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = $"{selectStaff.FirstName} {selectStaff.LastName}",
                    Value = selectStaff.Id
                };

                teacherSelect.Items.Add(item);
            }
        }

        private int GetSelectedClassId()
        {
            var selectedItem = (SubjectClassDropdlist)classSelect.SelectedItem;
            return selectedItem != null ? selectedItem.Value : 0;
        }

        private void classSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedClassId = GetSelectedClassId();

            SectionDataIntoComboBox(selectedClassId);
            SchoolStaffDataIntoComboBox(selectedClassId);
            SubjectDataIntoComboBox(selectedClassId);
        }

        private void period_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(classSelect.Text) && !string.IsNullOrWhiteSpace(sectionSelect.Text))
            {
                int newRow;
                bool isValidNumber = int.TryParse(period.Text, out newRow);

                if (isValidNumber && newRow > 0)
                {
                    PeriodDataGridView.Rows.Clear();
                    for (int i = 0; i < newRow; i++)
                    {

                        PeriodDataGridView.Rows.Add();
                        PeriodDataGridView.Rows[i].Cells[0].Value = (i + 1) + " Period";
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                PeriodDataGridView.Visible = true;
                Submit.Visible = true;
            }
            else
            {
                MessageBox.Show("Please select a class and select a section");
            }
        }

        private void PeriodDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == PeriodDataGridView.Columns["TimingFromColumn"]?.Index)
            {
                DateTimePicker dtpTimeArrived = new DateTimePicker
                {
                    ShowUpDown = true,
                    Format = DateTimePickerFormat.Time,
                    CustomFormat = "hh:mm tt",
                };

                DataGridViewCell cell = PeriodDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Rectangle cellRectangle = PeriodDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtpTimeArrived.Location = new Point(cellRectangle.X, cellRectangle.Y);
                dtpTimeArrived.Size = new Size(cellRectangle.Width, cellRectangle.Height);

                foreach (Control control in PeriodDataGridView.Controls)
                {
                    if (control is DateTimePicker)
                    {
                        PeriodDataGridView.Controls.Remove(control);
                        control.Dispose();
                    }
                }

                PeriodDataGridView.Controls.Add(dtpTimeArrived);
                dtpTimeArrived.Focus();

                dtpTimeArrived.ValueChanged += (s, evt) =>
                {
                    PeriodDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dtpTimeArrived.Value.ToString("hh:mm tt");
                };

            }
            if (e.RowIndex >= 0 && e.ColumnIndex == PeriodDataGridView.Columns["TimingToColumn"]?.Index)
            {
                DateTimePicker dtpTimeArrived = new DateTimePicker
                {
                    ShowUpDown = true,
                    Format = DateTimePickerFormat.Time,
                    CustomFormat = "hh:mm tt",
                };

                DataGridViewCell cell = PeriodDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Rectangle cellRectangle = PeriodDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtpTimeArrived.Location = new Point(cellRectangle.X, cellRectangle.Y);
                dtpTimeArrived.Size = new Size(cellRectangle.Width, cellRectangle.Height);

                foreach (Control control in PeriodDataGridView.Controls)
                {
                    if (control is DateTimePicker)
                    {
                        PeriodDataGridView.Controls.Remove(control);
                        control.Dispose();
                    }
                }

                PeriodDataGridView.Controls.Add(dtpTimeArrived);
                dtpTimeArrived.Focus();

                dtpTimeArrived.ValueChanged += (s, evt) =>
                {
                    PeriodDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dtpTimeArrived.Value.ToString("hh:mm tt");
                };

            }

            if (e.RowIndex >= 0 && e.ColumnIndex == PeriodDataGridView.Columns["SubjectColumn"]?.Index)
            {
                DataGridViewComboBoxCell l_objGridDropbox = new DataGridViewComboBoxCell();


                if (PeriodDataGridView.Columns[e.ColumnIndex].Name.Contains("SubjectColumn"))
                {
                    PeriodDataGridView[e.ColumnIndex, e.RowIndex] = l_objGridDropbox;
                    l_objGridDropbox.DataSource = SubjectDataIntoComboBox(GetSelectedClassId());
                    l_objGridDropbox.ValueMember = "Value";
                    l_objGridDropbox.DisplayMember = "Text";

                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == PeriodDataGridView.Columns["TeacherNameColumn"]?.Index)
            {
                DataGridViewComboBoxCell l_objGridDropbox = new DataGridViewComboBoxCell();

                if (PeriodDataGridView.Columns[e.ColumnIndex].Name.Contains("TeacherNameColumn"))
                {
                    PeriodDataGridView[e.ColumnIndex, e.RowIndex] = l_objGridDropbox;

                    var subjects = SubjectDataIntoComboBox(GetSelectedClassId());

                    int subjectCellValue = Convert.ToInt32(PeriodDataGridView.Rows[e.RowIndex].Cells["SubjectColumn"].Value);
                    subjectId = subjectCellValue;

                    l_objGridDropbox.DataSource = SchoolStaffDataIntoComboBoxGridView(GetSelectedClassId(), subjectId);
                    l_objGridDropbox.ValueMember = "Value";
                    l_objGridDropbox.DisplayMember = "Text";

                }
            }
        }

        private List<SubjectClassDropdlist> SchoolStaffDataIntoComboBoxGridView(int classId, int subjectId)
        {
            var selectSchoolStaff = dbContext.SchoolStaffs.Where(s => s.IsDelete != true && s.ClassId == classId && s.SubjectId == subjectId).AsEnumerable();

            List<SubjectClassDropdlist> items = new List<SubjectClassDropdlist>();

            foreach (var selectStaff in selectSchoolStaff)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = $"{selectStaff.FirstName} {selectStaff.LastName}",
                    Value = selectStaff.Id
                };

                items.Add(item);
            }

            return items;
        }

        private List<SubjectClassDropdlist> SubjectDataIntoComboBox(int classId)
        {
            try
            {
                var selectSubject = dbContext.Subjects.Where(s => s.IsDelete != true && s.ClassId == classId).AsEnumerable();

                List<SubjectClassDropdlist> items = new List<SubjectClassDropdlist>();

                foreach (var subject in selectSubject)
                {
                    SubjectClassDropdlist item = new SubjectClassDropdlist
                    {
                        Text = subject.SubjectName,
                        Value = subject.SubjectId
                    };
                    items.Add(item);
                }

                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                List<ClassPeriodAcademic> classacedmic = new List<ClassPeriodAcademic>();
                List<ClassTeacherAcademic> classteacher = new List<ClassTeacherAcademic>();
                var selectedClass = (SubjectClassDropdlist)classSelect.SelectedItem;
                var selectedTeacher = (SubjectClassDropdlist)teacherSelect.SelectedItem;
                var selectedSection = (SubjectClassDropdlist)sectionSelect.SelectedItem;
                if (selectedClass != null && selectedTeacher != null && selectedSection != null)
                {
                    foreach (DataGridViewRow row in PeriodDataGridView.Rows)
                    {

                        string periodNumber = row.Cells["PeriodColumn"]?.Value?.ToString();
                        int subject = Convert.ToInt32(row.Cells["SubjectColumn"]?.Value);
                        int teacher = Convert.ToInt32(row.Cells["TeacherNameColumn"]?.Value);
                        string timingFrom = row.Cells["TimingFromColumn"]?.Value?.ToString();
                        string timingTo = row.Cells["TimingToColumn"]?.Value?.ToString();
                        string duration = row.Cells["DurationColumn"]?.Value?.ToString();


                        var newClassPeriod = new ClassPeriodAcademic
                        {
                            SchoolId = 2008,
                            ClassId = selectedClass?.Value,
                            SectionId = selectedSection?.Values,
                            Period = periodNumber,
                            SubjectId = subject,
                            TeacherId = teacher,
                            TimingFrom = timingFrom,
                            TimingTo = timingTo,
                            Duration = duration,
                            IsActive = true,
                            IsDelete = false,
                            DateAdded = DateTime.Now,
                            DateModified = DateTime.Now,
                        };

                        var newClassTeacher = new ClassTeacherAcademic
                        {
                            SchoolId = 2008,
                            ClassId = selectedClass.Value,
                            SectionId = selectedSection.Values,
                            ClassTeacher = selectedTeacher.Value,
                            IsActive = true,
                            IsDelete = false,
                            DateAdded = DateTime.Now,
                            DateModified = DateTime.Now,
                        };

                        var isrowmessage = validate.ValidateStudentAttandance(newClassPeriod);
                        if (isrowmessage.Status == true)
                        {
                            classacedmic.Clear();
                            classteacher.Clear();
                            int rowIndex =  row.Index + 1;
                            MessageBox.Show("data is not filled in row" + " " + rowIndex + " "  + "please check it!");
                            return;
                        }
                     
                        classacedmic.Add(newClassPeriod);
                        classteacher.Add(newClassTeacher);
                    }

                    dbContext.ClassPeriodAcademics.AddRange(classacedmic);
                    dbContext.ClassTeacherAcademics.AddRange(classteacher);
                    dbContext.SaveChanges();
                    MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Please enter the above details!!");
                    return;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
