using Dapper;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
using DocumentFormat.OpenXml.VariantTypes;
using Microsoft.VisualBasic.ApplicationServices;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SchoolManagement.Helper.Helper;
using static System.Net.WebRequestMethods;

namespace SchoolManagement.Academic
{
    public partial class ClassPeriod : Form
    {
        private int Id;
        private int SchoolId;
        private int subjectId;
        private List<int> selectedSubjects = new List<int>();
        private bool isCellValueChanging = false;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        private SchoolManagementEntities1 dbContext = new SchoolManagementEntities1();
        validations validate = new validations();
        Form form;
        public ClassPeriod()
        {
            InitializeComponent();
        }

        private void ClassPeriod_Load(object sender, EventArgs e)
        {
            ClassDataIntoComboBox();
            SectionDataIntoComboBox(GetSelectedClassId());
            SchoolStaffDataIntoComboBox(GetSelectedClassId());

            period.Text = classperiods.TotalPeriod;
            SchoolId = EditStaffViewModel.SchoolId;
        }

        private void ClassDataIntoComboBox()
        {
            var selectClass = dbContext.Classes.Where(s => s.Isdelete != true).AsEnumerable();
            classSelect.Items.Clear();

            classSelect.Text = "Please select a value";
            foreach (var select in selectClass)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = select.ClassName,
                    Value = select.ClassId,
                };

                classSelect.Items.Add(item);
            }

            int classes = classperiods.Classid;
            var selectedItem = classSelect.Items.Cast<SubjectClassDropdlist>().FirstOrDefault(i => i.Value == classes);
            if (selectedItem != null)
            {
                classSelect.SelectedItem = selectedItem;
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
            var sectionIds = classperiods.SectionId;
            var selectedItem = sectionSelect.Items.Cast<SubjectClassDropdlist>().FirstOrDefault(i => i.Values == sectionIds);

            if (selectedItem != null)
            {
                sectionSelect.SelectedItem = selectedItem;
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
            var teacherIds = classperiods.TeacherId;
            var selectedItem = teacherSelect.Items.Cast<SubjectClassDropdlist>().FirstOrDefault(i => i.Value == teacherIds);

            if (selectedItem != null)
            {
                teacherSelect.SelectedItem = selectedItem;
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
                        PeriodDataGridView.Rows[i].Cells[1].Value = "Period "+(i + 1);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please select a class and select a section");
                period.Text = string.Empty;
            }
        }

        private void PeriodDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == PeriodDataGridView.Columns["TimingFromColumn"]?.Index)
            {
                DateTimePicker dtpTime = new DateTimePicker
                {
                    ShowUpDown = true,
                    Format = DateTimePickerFormat.Time,
                    CustomFormat = "hh:mm tt",
                };
                string currentTime = DateTime.Now.ToString("hh:mm tt");

                PeriodDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = currentTime;
                DataGridViewCell cell = PeriodDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Rectangle cellRectangle = PeriodDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtpTime.Location = new Point(cellRectangle.X, cellRectangle.Y);
                dtpTime.Size = new Size(cellRectangle.Width, cellRectangle.Height);

                foreach (Control control in PeriodDataGridView.Controls)
                {
                    if (control is DateTimePicker)
                    {
                        PeriodDataGridView.Controls.Remove(control);
                        control.Dispose();
                    }
                }

                PeriodDataGridView.Controls.Add(dtpTime);
                dtpTime.Focus();

                dtpTime.ValueChanged += (s, evt) =>
                {
                    PeriodDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dtpTime.Value.ToString("hh:mm tt");
                };

                dtpTime.Leave += (s, evt) =>
                {
                    PeriodDataGridView.Controls.Remove(dtpTime);
                    dtpTime.Dispose();
                };

            }

            if (e.RowIndex >= 0 && e.ColumnIndex == PeriodDataGridView.Columns["TimingToColumn"]?.Index)
            {
                DateTimePicker dtpTime = new DateTimePicker
                {
                    ShowUpDown = true,
                    Format = DateTimePickerFormat.Time,
                    CustomFormat = "hh:mm tt",
                };
                string currentTime = DateTime.Now.ToString("hh:mm tt");

                PeriodDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = currentTime;
                DataGridViewCell cell = PeriodDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex];
                Rectangle cellRectangle = PeriodDataGridView.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);
                dtpTime.Location = new Point(cellRectangle.X, cellRectangle.Y);
                dtpTime.Size = new Size(cellRectangle.Width, cellRectangle.Height);

                foreach (Control control in PeriodDataGridView.Controls)
                {
                    if (control is DateTimePicker)
                    {
                        PeriodDataGridView.Controls.Remove(control);
                        control.Dispose();
                    }
                }

                PeriodDataGridView.Controls.Add(dtpTime);
                dtpTime.Focus();

                dtpTime.ValueChanged += (s, evt) =>
                {
                    PeriodDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = dtpTime.Value.ToString("hh:mm tt");
                };

                dtpTime.Leave += (s, evt) =>
                {
                    PeriodDataGridView.Controls.Remove(dtpTime);
                    dtpTime.Dispose();
                };

            }

            foreach (DataGridViewRow row in PeriodDataGridView.Rows)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == PeriodDataGridView.Columns["SubjectColumn"]?.Index)
                {
                    DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();


                    if (PeriodDataGridView.Columns[e.ColumnIndex].Name.Contains("SubjectColumn"))
                    {
                        comboBoxCell.DataSource = SubjectDataIntoComboBox(GetSelectedClassId());
                        comboBoxCell.ValueMember = "Value";
                        comboBoxCell.DisplayMember = "Text";

                        var dataSourceList = comboBoxCell.DataSource as IList;
                        if (dataSourceList != null && dataSourceList.Count > 0)
                        {
                            var defaultValue = ((dynamic)dataSourceList[0]).Value;

                            comboBoxCell.Value = defaultValue;
                        }

                        PeriodDataGridView[e.ColumnIndex, e.RowIndex] = comboBoxCell;
                    }
                }
            }
             
            foreach (DataGridViewRow row in PeriodDataGridView.Rows)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == PeriodDataGridView.Columns["TeacherNameColumn"]?.Index)
                {
                    DataGridViewComboBoxCell comboBoxCell = new DataGridViewComboBoxCell();

                    if (PeriodDataGridView.Columns[e.ColumnIndex].Name.Contains("TeacherNameColumn"))
                    {
                        var subjects = SubjectDataIntoComboBox(GetSelectedClassId());

                        object cellValue = PeriodDataGridView.Rows[e.RowIndex].Cells["SubjectColumn"].Value;
                        if (cellValue != null)
                        {
                            int subjectCellValue;
                            if (int.TryParse(cellValue.ToString(), out subjectCellValue))
                            {
                                subjectId = subjectCellValue;
                            }
                        }
                        else
                        {
                            MessageBox.Show("please select your subject first.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        comboBoxCell.DataSource = SchoolStaffDataIntoComboBoxGridView(GetSelectedClassId(), subjectId);
                        comboBoxCell.ValueMember = "Value";
                        comboBoxCell.DisplayMember = "Text";

                        var dataSourceList = comboBoxCell.DataSource as IList;
                        if (dataSourceList != null && dataSourceList.Count > 0)
                        {
                            var defaultValue = ((dynamic)dataSourceList[0]).Value;

                            comboBoxCell.Value = defaultValue;
                        }

                        PeriodDataGridView[e.ColumnIndex, e.RowIndex] = comboBoxCell;
                    }
                }
            }
        }

        private List<SubjectClassDropdlist> SchoolStaffDataIntoComboBoxGridView(int classId, int subjectId)
        {
            var selectSchoolStaff = dbContext.SchoolStaffs.Where(s => s.IsDelete != true && s.ClassId == classId && s.SubjectId == subjectId).AsEnumerable();

            List<SubjectClassDropdlist> items = new List<SubjectClassDropdlist>();
            SubjectClassDropdlist item = new SubjectClassDropdlist
            {
                Text = "select a techer",
                Values = "",
            };

            items.Add(item);

            foreach (var selectStaff in selectSchoolStaff)
            {
                SubjectClassDropdlist dropitem = new SubjectClassDropdlist
                {
                    Text = $"{selectStaff.FirstName} {selectStaff.LastName}",
                    Value = selectStaff.Id
                };

                items.Add(dropitem);
            }

            return items;
        }

        private List<SubjectClassDropdlist> SubjectDataIntoComboBox(int classId)
        {
            try
            {
                var selectSubject = dbContext.Subjects.Where(s => s.IsDelete != true && s.ClassId == classId).AsEnumerable();

                List<SubjectClassDropdlist> items = new List<SubjectClassDropdlist>();
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = "select a sub",
                    Values = "",
                };

                items.Add(item);

                foreach (var subject in selectSubject)
                {
                    SubjectClassDropdlist dropitem = new SubjectClassDropdlist
                    {
                        Text = subject.SubjectName,
                        Value = subject.SubjectId
                    };
                    items.Add(dropitem);
                }

                return items;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void PeriodDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == PeriodDataGridView.Columns["TimingFromColumn"]?.Index ||
                    e.ColumnIndex == PeriodDataGridView.Columns["TimingToColumn"]?.Index)
                {
                    CalculateAndSetDuration(e.RowIndex);
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex == PeriodDataGridView.Columns["SubjectColumn"].Index)
            {
                if (isCellValueChanging) return;

                int selectedSubject;
                if (int.TryParse(PeriodDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value?.ToString(), out selectedSubject))
                {
                    if (selectedSubjects.Contains(selectedSubject))
                    {
                        isCellValueChanging = true;
                        PeriodDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                        isCellValueChanging = false;

                        MessageBox.Show("This subject is already selected. Please choose another one.");
                        selectedSubjects.Remove(selectedSubject);
                    }
                    else
                    {
                        selectedSubjects.Add(selectedSubject);
                    }
                }
            }
        }

        private void CalculateAndSetDuration(int rowIndex)
        {
            string fromTimeString = PeriodDataGridView.Rows[rowIndex].Cells["TimingFromColumn"].Value?.ToString();
            string toTimeString = PeriodDataGridView.Rows[rowIndex].Cells["TimingToColumn"].Value?.ToString();

            if (DateTime.TryParseExact(fromTimeString, "hh:mm tt", null, System.Globalization.DateTimeStyles.None, out DateTime fromTime) &&
                DateTime.TryParseExact(toTimeString, "hh:mm tt", null, System.Globalization.DateTimeStyles.None, out DateTime toTime))
            {
                TimeSpan duration = toTime - fromTime;
                int hours = duration.Hours;
                int minutes = duration.Minutes;

                if (duration.TotalMinutes == 0)
                {
                    PeriodDataGridView.Rows[rowIndex].Cells["DurationColumn"].Value = "0 minute";
                }
                else
                {
                    string durationString = string.Empty;

                    if (hours > 0)
                    {
                        durationString += $"{hours}hr";
                    }

                    if (minutes > 0)
                    {
                        if (hours > 0)
                        {
                            durationString += " ";
                        }
                        durationString += $"{minutes}minute";
                    }

                    PeriodDataGridView.Rows[rowIndex].Cells["DurationColumn"].Value = durationString;
                }
            }
            else
            {
                PeriodDataGridView.Rows[rowIndex].Cells["DurationColumn"].Value = string.Empty;
            }
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (PeriodSubmit.Text.Trim() == "Submit")
                {
                    List<ClassPeriodAcademic> classacedmic = new List<ClassPeriodAcademic>();
                    var selectedClass = (SubjectClassDropdlist)classSelect.SelectedItem;
                    var selectedTeacher = (SubjectClassDropdlist)teacherSelect.SelectedItem;
                    var selectedSection = (SubjectClassDropdlist)sectionSelect.SelectedItem;
                    if (selectedClass != null && selectedTeacher != null && selectedSection != null)
                    {
                        bool classTeach = dbContext.ClassTeacherAcademics.Any(s => s.SectionId == selectedSection.Values && s.ClassId == selectedClass.Value && s.IsActive == true);
                        if (!classTeach)
                        {
                            var newClassTeacher = new ClassTeacherAcademic
                            {
                                SchoolId = 2008,
                                ClassId = selectedClass.Value,
                                SectionId = selectedSection.Values,
                                ClassTeacher = selectedTeacher.Value,
                                Period = period.Text,
                                IsActive = true,
                                IsDelete = false,
                                DateAdded = DateTime.Now,
                                DateModified = DateTime.Now,
                            };
                            dbContext.ClassTeacherAcademics.Add(newClassTeacher);
                            dbContext.SaveChanges();
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

                                var isrowmessage = validate.ValidateStudentAttandance(newClassPeriod);
                                if (isrowmessage.Status == true)
                                {
                                    classacedmic.Clear();
                                    int rowIndex = row.Index + 1;
                                    MessageBox.Show("Data is not filled in row" + " " + rowIndex + " " + "please check it!");
                                    return;
                                }

                                classacedmic.Add(newClassPeriod);
                            }

                            dbContext.ClassPeriodAcademics.AddRange(classacedmic);
                            dbContext.SaveChanges();
                            MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            classSelect.SelectedIndex = -1;
                            teacherSelect.SelectedIndex = -1;
                            sectionSelect.SelectedIndex = -1;
                            period.Text = "";
                            PeriodDataGridView.Rows.Clear();
                        }
                        else
                        {
                            MessageBox.Show("Record already exist");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please enter the above details!!");
                        return;
                    }
                }
                else if (PeriodSubmit.Text == "Update")
                {
                    UpdateSection();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateSection()
        {
            try
            {
                var selectedClass = (SubjectClassDropdlist)classSelect.SelectedItem;
                var selectedTeacher = (SubjectClassDropdlist)teacherSelect.SelectedItem;
                var selectedSection = (SubjectClassDropdlist)sectionSelect.SelectedItem;

                if (selectedClass != null && selectedTeacher != null && selectedSection != null)
                {
                    var ClassTeacherToUpdate = dbContext.ClassTeacherAcademics.AsNoTracking().FirstOrDefault(x => x.SchoolId == SchoolId && x.ClassId == selectedClass.Value && x.SectionId == selectedSection.Values);
                    if (ClassTeacherToUpdate != null)
                    {
                        ClassTeacherToUpdate.ClassId = selectedClass.Value;
                        ClassTeacherToUpdate.SectionId = selectedSection.Values;
                        ClassTeacherToUpdate.ClassTeacher = selectedTeacher.Value;
                        ClassTeacherToUpdate.Period = period.Text;
                        ClassTeacherToUpdate.DateModified = DateTime.Now;
                        dbContext.Entry(ClassTeacherToUpdate).State = EntityState.Modified;
                        dbContext.SaveChanges();
                        foreach (DataGridViewRow row in PeriodDataGridView.Rows)
                        {
                            if (row.Cells["IdColumn"].Value != null)
                            {
                                Id = Convert.ToInt32(row.Cells["IdColumn"].Value);
                                var classPeriodToUpdate = dbContext.ClassPeriodAcademics.AsNoTracking().FirstOrDefault(x => x.Id == Id && x.SchoolId == ClassTeacherToUpdate.SchoolId && x.ClassId == selectedClass.Value && x.SectionId == selectedSection.Values);
                                if (classPeriodToUpdate != null)
                                {
                                    string periodNumber = row.Cells["PeriodColumn"]?.Value?.ToString();
                                    int subject = Convert.ToInt32(row.Cells["SubjectColumn"]?.Value);
                                    int teacher = Convert.ToInt32(row.Cells["TeacherNameColumn"]?.Value);
                                    string timingFrom = row.Cells["TimingFromColumn"]?.Value?.ToString();
                                    string timingTo = row.Cells["TimingToColumn"]?.Value?.ToString();
                                    string duration = row.Cells["DurationColumn"]?.Value?.ToString();
                                    classPeriodToUpdate.ClassId = selectedClass?.Value;
                                    classPeriodToUpdate.SectionId = selectedSection?.Values;
                                    classPeriodToUpdate.Period = periodNumber;
                                    classPeriodToUpdate.SubjectId = subject;
                                    classPeriodToUpdate.TeacherId = teacher;
                                    classPeriodToUpdate.TimingFrom = timingFrom;
                                    classPeriodToUpdate.TimingTo = timingTo;
                                    classPeriodToUpdate.Duration = duration;
                                    classPeriodToUpdate.DateModified = DateTime.Now;

                                    var isrowmessage = validate.ValidateStudentAttandance(classPeriodToUpdate);
                                    if (isrowmessage.Status == true)
                                    {
                                        int rowIndex = row.Index + 1;
                                        MessageBox.Show("Data is not filled in row" + " " + rowIndex + " " + "please check it!");
                                        return;
                                    }
                                    dbContext.Entry(classPeriodToUpdate).State = EntityState.Modified;
                                    dbContext.SaveChanges();
                                }
                                else
                                {
                                    MessageBox.Show("Class period not found or faild to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                        MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        classSelect.SelectedIndex = -1;
                        teacherSelect.SelectedIndex = -1;
                        sectionSelect.SelectedIndex = -1;
                        period.Text = "";
                        PeriodDataGridView.Rows.Clear();

                        PeriodSubmit.Text = "Submit";
                        this.Hide();
                        form = new ClassPeriodDetails();
                        form.Show();

                    }
                    else
                    {
                        MessageBox.Show("Class teacher record not found or faild to update", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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
