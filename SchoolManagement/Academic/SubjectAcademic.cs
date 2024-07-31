using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.EntitySql;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagement
{
    public partial class SubjectAcademic : Form
    {
        private int SubjectId;
        SchoolManagementEntities dbContext = new SchoolManagementEntities();
        validations validates = new validations();
        public SubjectAcademic()
        {
            InitializeComponent();
        }

        private void SubjectAcademic_Load(object sender, EventArgs e)
        {
            GetdataFromDatabase();
            LoadDataIntoComboBox();
        }

        private void GetdataFromDatabase()
        {
            var data = dbContext.Subjects.Where(m => m.IsDelete != true).Select(m => new
            {
                m.SubjectId,
                m.ClassName,
                m.SubjectName
            }).ToList();
            SubjectDataGridView.DataSource = data;
        }

        private void LoadDataIntoComboBox()
        {
            var selectClass = dbContext.Classes.Where(s => s.Isdelete != true).AsEnumerable();
            SelectClasses.Items.Clear();

            foreach (var select in selectClass)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = select.ClassName,
                    Value = select.ClassId,
                };

                SelectClasses.Items.Add(item);
            }
        }

        private void SubjectSubmit_Click(object sender, EventArgs e)
        {
            if (SubjectSubmit.Text == "Submit")
            {
                try
                {
                    if (!string.IsNullOrEmpty(SelectClasses.Text))
                    {
                        if (string.IsNullOrEmpty(SubjectName.Text))
                        {
                            MessageBox.Show("Please enter the subject name");
                            return;
                        }
                        SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)SelectClasses.SelectedItem;

                        Subject newSubject = new Subject()
                        {
                            ClassId = selectedClass.Value,
                            SchoolId = GlobalAccount.SchoolId,
                            ClassName = SelectClasses.Text,
                            SubjectName = SubjectName.Text,
                            IsActive = true,
                            IsDelete = false,
                            DateAdded = DateTime.Now,
                            DateModified = DateTime.Now,
                        };

                        dbContext.Subjects.Add(newSubject);
                        dbContext.SaveChanges();
                        MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        GetdataFromDatabase();
                        SelectClasses.SelectedIndex = -1;
                        SubjectName.Text = "";
                        
                    }
                    else
                    {
                        MessageBox.Show("Please select the class");
                        return;
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (SubjectSubmit.Text == "Update")
            {
                UpdateSection();
            }
        }

        private void UpdateSection()
        {
            try
            {
                if (SubjectDataGridView.SelectedRows.Count == 0)
                {
                    var subjectToUpdate = dbContext.Subjects.Find(SubjectId);

                    if (subjectToUpdate != null)
                    {
                        SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)SelectClasses.SelectedItem;

                        subjectToUpdate.ClassId = selectedClass.Value;
                        subjectToUpdate.ClassName = SelectClasses.Text;
                        subjectToUpdate.SubjectName = SubjectName.Text;
                        var messages_subject = validates.ValidateSubject(subjectToUpdate);
                        if (messages_subject.Status == true)
                        {
                            MessageBox.Show(messages_subject.Message);
                        }
                        else
                        {
                            subjectToUpdate.DateModified = DateTime.Now;
                            dbContext.SaveChanges();
                            MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
   
                            SelectClasses.SelectedIndex = -1;
                            SubjectName.Text = "";
                            SubjectSubmit.Text = "Submit";
                            GetdataFromDatabase();
                        }
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

        private void SubjectDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < SubjectDataGridView.Columns.Count && SubjectDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                string ClassNameEdit, SubjectNameEdit;
                SubjectId = Convert.ToInt32(SubjectDataGridView.Rows[e.RowIndex].Cells["SubjectIdColumn"].Value);
                ClassNameEdit = Convert.ToString(SubjectDataGridView.Rows[e.RowIndex].Cells["SelectClassColumn"].Value);
                SubjectNameEdit = Convert.ToString(SubjectDataGridView.Rows[e.RowIndex].Cells["SubjectNameColumn"].Value);
                SelectClasses.Text = ClassNameEdit;
                SubjectName.Text = SubjectNameEdit;

                SubjectSubmit.Text = "Update";
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < SubjectDataGridView.Columns.Count && SubjectDataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                SubjectId = Convert.ToInt32(SubjectDataGridView.Rows[e.RowIndex].Cells["SubjectIdColumn"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var entityToDelete = dbContext.Subjects.Find(SubjectId);

                    if (entityToDelete != null)
                    {

                        entityToDelete.IsDelete = true;
                        dbContext.SaveChanges();

                        GetdataFromDatabase();

                        MessageBox.Show("Record deleted successfully.");
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
