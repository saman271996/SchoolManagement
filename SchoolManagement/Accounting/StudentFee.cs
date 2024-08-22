using CsvHelper;
using Dapper;
using DocumentFormat.OpenXml.Drawing.Charts;
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

namespace SchoolManagement.Accounting
{
    public partial class StudentFee : Form
    {
        private int schoolId = 2008;
        private int classId;
        SchoolManagementEntities1 DbContext = new SchoolManagementEntities1();
        validations validate = new validations();
        public StudentFee()
        {
            InitializeComponent();
        }

        private void StudentFee_Load(object sender, EventArgs e)
        {
            StudentClassFeesRecord();
        }
        
        private void StudentClassFeesRecord()
        {
            var data = DbContext.Classes.Where(m => m.IsActive == true).Select(m => new
            {
                m.ClassName,
            }).ToList();
            StudentFeeDataGridView.DataSource = data;
        }

        private void StudentFeeSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                List<StudentFeeAccounting> studentFees = new List<StudentFeeAccounting>();
                classId = Convert.ToInt32(StudentFeeDataGridView.CurrentRow.Cells["ClassColumn"]?.Value);

                bool classFessExist = DbContext.StudentFeeAccountings.Any(s => s.SchoolId == schoolId && s.ClassId == classId && s.IsActive == true);
                if (!classFessExist)
                {
                    foreach (DataGridViewRow row in StudentFeeDataGridView.Rows)
                    {
                        int classId = Convert.ToInt32(row.Cells["ClassColumn"]?.Value);
                        string yearFee = row.Cells["YearlyFeesColumn"].Value?.ToString();
                        string installment = row.Cells["InstallmentColumn"].Value?.ToString();

                        var newStudentFee = new StudentFeeAccounting
                        {
                            SchoolId = schoolId,
                            ClassId = classId,
                            YearFee = yearFee,
                            Installment = installment,
                            IsActive = true,
                            IsDelete = false,
                            DateAdded = DateTime.Now,
                            DateModified = DateTime.Now,
                        };

                        var isrowmessage = validate.ValidateStudentFee(newStudentFee);
                        if (isrowmessage.Status == true)
                        {
                            int rowIndex = row.Index + 1;
                            MessageBox.Show("Data is not filled in row" + " " + rowIndex + " " + "please check it!", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        studentFees.Add(newStudentFee);
                    }

                    DbContext.StudentFeeAccountings.AddRange(studentFees);
                    DbContext.SaveChanges();
                    MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else 
                {
                    MessageBox.Show("Record already exist", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                for (int i = 0; i < StudentFeeDataGridView.Rows.Count; i++)
                {
                    StudentFeeDataGridView.Rows[i].Cells["YearlyFeesColumn"].Value = string.Empty;
                    StudentFeeDataGridView.Rows[i].Cells["InstallmentColumn"].Value = string.Empty;
                }
            }
        }
    }
}
