using Dapper;
using DocumentFormat.OpenXml.VariantTypes;
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
namespace SchoolManagement.Academic
{
    public partial class ClassRoutine : Form
    {
        private int Id;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 dbContext = new SchoolManagementEntities1();
        validations validates = new validations();
        public ClassRoutine()
        {
            InitializeComponent(); 
        }

        private void ClassRoutine_Load(object sender, EventArgs e)
        {
            ClassDataIntoComboBox();
            SectionDataIntoComboBox(GetSelectedClassId());
            SubjectDataIntoComboBox(GetSelectedClassId());
            SchoolStaffDataIntoComboBox(GetSelectedClassId(), GetSelectedSubjectId());
            GetdataFromDatabase();
        }

        private void GetdataFromDatabase()
        {
            try

            {
                var schoolid = 2008;
                DataTable dt = new DataTable();

                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = new StringBuilder($@"select clrout.Id,class.ClassName,sub.SubjectName, concat(schstf.FirstName, ' ', schstf.LastName) as StaffName,clasec.SectionName
                    from ClassRoutineAcademic clrout left join Class class on class.ClassId=clrout.ClassId left join Subject sub on sub.SubjectId=clrout.SubjectId
                    left join SchoolStaff schstf on schstf.Id = clrout.TeacherId left join Class_Section clasec on clasec.SectionId =clrout.SectionId 
                    where clrout.IsActive=1 and clrout.SchoolId={schoolid}");
                    var properties = connection.Query<ClassRoutineViewModel>(sql.ToString()).ToList();

                    foreach (var item in properties)
                    {
                        ClassRoutineDataGridView.Rows.Add(item.Id, item.ClassName, item.SectionName, item.SubjectName, item.StaffName);
                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
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

        private int GetSelectedClassId()
        {
            var selectedItem = (SubjectClassDropdlist)classSelect.SelectedItem;
            return selectedItem != null ? selectedItem.Value : 0;
        }

        private int GetSelectedSubjectId()
        {
            var selectedItem = (SubjectClassDropdlist)subjectSelect.SelectedItem;
            return selectedItem != null ? selectedItem.Value : 0;
        }

        private void classSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedClassId = GetSelectedClassId();
            int selectedSubjectId = GetSelectedSubjectId();

            SectionDataIntoComboBox(selectedClassId);
            SubjectDataIntoComboBox(selectedClassId);
            SchoolStaffDataIntoComboBox(selectedClassId, selectedSubjectId);
        }

        private void SubjectDataIntoComboBox(int classId)
        {
            var selectSubject = dbContext.Subjects.Where(s => s.IsDelete != true && s.ClassId == classId).AsEnumerable();
            subjectSelect.Items.Clear();

            foreach (var subject in selectSubject)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = subject.SubjectName,
                    Value = subject.SubjectId

                };

                subjectSelect.Items.Add(item);
            }
        }

        private void SchoolStaffDataIntoComboBox(int classId, int subjectId)
        {
            var selectSchoolStaff = dbContext.SchoolStaffs.Where(s => s.IsDelete != true && s.ClassId == classId && s.SubjectId == subjectId).AsEnumerable();
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

        private void subjectSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedClassId = GetSelectedClassId();
            int selectedSubjectId = GetSelectedSubjectId();

            SchoolStaffDataIntoComboBox(selectedClassId, selectedSubjectId);
        }

        private void RefreshClassRoutineDataGridView()
        {
            ClassRoutineDataGridView.Rows.Clear();
            GetdataFromDatabase();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            try
            {
                if (Submit.Text == "Submit")
                {
                    SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)classSelect?.SelectedItem;
                    SubjectClassDropdlist selectedSubject = (SubjectClassDropdlist)subjectSelect?.SelectedItem;
                    SubjectClassDropdlist selectedTeacher = (SubjectClassDropdlist)teacherSelect?.SelectedItem;
                    SubjectClassDropdlist selectedSection = (SubjectClassDropdlist)sectionSelect?.SelectedItem;
                    if (selectedClass != null && selectedSubject != null && selectedTeacher != null && selectedSection != null)
                    {
                        var classRoutine = new ClassRoutineAcademic
                        {
                            SchoolId = 2008,
                            ClassId = selectedClass.Value,
                            SubjectId = selectedSubject.Value,
                            TeacherId = selectedTeacher.Value,
                            SectionId = selectedSection.Values,
                            IsActive = true,
                            IsDelete = false,
                            DateAdded = DateTime.Now,
                            DateModified = DateTime.Now,
                        };
                        var message_classRoutine = validates.ValidateClassRoutine(classRoutine);
                        if (message_classRoutine.Status == true)
                        {
                            MessageBox.Show(message_classRoutine.Message);
                        }
                        else
                        {
                            dbContext.ClassRoutineAcademics.Add(classRoutine);
                            dbContext.SaveChanges();
                            MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            GetdataFromDatabase();
                            classSelect.SelectedIndex = -1;
                            subjectSelect.SelectedIndex = -1;
                            teacherSelect.SelectedIndex = -1;
                            sectionSelect.SelectedIndex = -1;
                        }
                    }
                    else
                    {
                        MessageBox.Show("please fill the above fields");
                    }
                }
                else if(Submit.Text == "Update")
                {
                    UpdateClassRoutine();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateClassRoutine()
        {
            try
            {
                if (ClassRoutineDataGridView.SelectedRows.Count == 0)
                {
                    var classRoutineToUpdate = dbContext.ClassRoutineAcademics.Find(Id);
                    if (classRoutineToUpdate != null) 
                    {
                        SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)classSelect.SelectedItem;
                        SubjectClassDropdlist selectedSubject = (SubjectClassDropdlist)subjectSelect.SelectedItem;
                        SubjectClassDropdlist selectedTeacher = (SubjectClassDropdlist)teacherSelect.SelectedItem;
                        SubjectClassDropdlist selectedSection = (SubjectClassDropdlist)sectionSelect.SelectedItem;

                        classRoutineToUpdate.ClassId = selectedClass.Value;
                        classRoutineToUpdate.SubjectId = selectedSubject.Value;
                        classRoutineToUpdate.TeacherId = selectedTeacher.Value;
                        classRoutineToUpdate.SectionId = selectedSection.Values;

                        classRoutineToUpdate.DateModified = DateTime.Now;
                        dbContext.SaveChanges();
                        MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        RefreshClassRoutineDataGridView();
                        classSelect.SelectedIndex = -1;
                        subjectSelect.SelectedIndex = -1;
                        teacherSelect.SelectedIndex = -1;
                        sectionSelect.SelectedIndex = -1;
                        Submit.Text = "Submit";
                    }
                    else
                    {
                        MessageBox.Show("Record not found or failed to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClassRoutineDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < ClassRoutineDataGridView.Columns.Count && ClassRoutineDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                string ClassNameEdit, SubjectNameEdit, sectionNameEdit, teacherNameEdit;
                Id = Convert.ToInt32(ClassRoutineDataGridView.Rows[e.RowIndex].Cells["IdColumn"].Value);
                ClassNameEdit = Convert.ToString(ClassRoutineDataGridView.Rows[e.RowIndex].Cells["ClassNameColumn"].Value);
                SubjectNameEdit = Convert.ToString(ClassRoutineDataGridView.Rows[e.RowIndex].Cells["SubjectNameColumn"].Value);
                sectionNameEdit = Convert.ToString(ClassRoutineDataGridView.Rows[e.RowIndex].Cells["SectionNameColumn"].Value);
                teacherNameEdit = Convert.ToString(ClassRoutineDataGridView.Rows[e.RowIndex].Cells["TeacherNameColumn"].Value);
                classSelect.Text = ClassNameEdit;
                subjectSelect.Text = SubjectNameEdit;
                sectionSelect.Text = sectionNameEdit;
                teacherSelect.Text = teacherNameEdit;

                Submit.Text = "Update";
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < ClassRoutineDataGridView.Columns.Count && ClassRoutineDataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                Id = Convert.ToInt32(ClassRoutineDataGridView.Rows[e.RowIndex].Cells["IdColumn"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var entityToDelete = dbContext.ClassRoutineAcademics.Find(Id);

                    if (entityToDelete != null)
                    {

                        entityToDelete.IsDelete = true;
                        entityToDelete.IsActive = false;
                        dbContext.SaveChanges();

                        MessageBox.Show("Record deleted successfully.");
                        RefreshClassRoutineDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Record not found or failed to delete.");
                    }
                }
            }
        }
    }
}
