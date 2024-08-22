using Dapper;
using DocumentFormat.OpenXml.VariantTypes;
using SchoolManagement.Academic;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Accounting
{
    public partial class StudentFeeDetails : Form
    {
        private int schoolId;
        private int classId;
        private string yearFee;
        private string installment;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 DbContext = new SchoolManagementEntities1();
        Form frm;
        public StudentFeeDetails()
        {
            InitializeComponent();
        }

        private void StudentFeeDetails_Load(object sender, EventArgs e)
        {
            StudentClassFeesRecord();
        }

        private void StudentClassFeesRecord()
        {
            try
            {
                var schoolid = 2008;
                System.Data.DataTable dt = new System.Data.DataTable();

                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = new StringBuilder($@"select StuFeeAC.Id,StuFeeAC.SchoolId,StuFeeAC.ClassId,StuFeeAC.YearFee,StuFeeAC.Installment,class.ClassName
                    from StudentFeeAccounting StuFeeAC left join Class class on class.ClassId=StuFeeAC.ClassId
                    where StuFeeAC.IsActive=1 and StuFeeAC.SchoolId={schoolid}");
                    var properties = connection.Query<StudentFeeModel>(sql.ToString()).ToList();

                    foreach (var item in properties)
                    {
                        StuFeeDetailsDataGridView.Rows.Add(item.Id, item.SchoolId, item.ClassName, item.YearFee, item.Installment);
                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void StuFeeDetailsDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStaffViewModel.SchoolId = 0;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < StuFeeDetailsDataGridView.Columns.Count && StuFeeDetailsDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                schoolId = Convert.ToInt32(StuFeeDetailsDataGridView.Rows[e.RowIndex].Cells["SchoolIdColumn"]?.Value);
                classId = Convert.ToInt32(StuFeeDetailsDataGridView.Rows[e.RowIndex].Cells["ClassNameColumn"]?.Value);
                yearFee = StuFeeDetailsDataGridView.Rows[e.RowIndex].Cells["YearlyFeeColumn"].Value?.ToString();
                installment = StuFeeDetailsDataGridView.Rows[e.RowIndex].Cells["InstallmentColumn"].Value?.ToString();

                EditStaffViewModel.SchoolId = schoolId;

                getStudentFeeData(schoolId);
            }
        }

        public void getStudentFeeData(int schoolId)
        {
            try
            {
                var frm = (StudentFeeDetails)Application.OpenForms["StudentFeeDetails"];
                if (frm == null)
                {

                    frm = new StudentFeeDetails();
                }
                var getClassFeeData = DbContext.StudentFeeAccountings.AsNoTracking().FirstOrDefault(x => x.SchoolId == schoolId);
                if (getClassFeeData != null)
                {
                    using (var connection = new SqlConnection(ConnectionString))
                    {
                        var sql = new StringBuilder($@"select clP.Id as Id,clP.Period,clP.TimingFrom,clP.TimingTo,clP.Duration,sub.SubjectId,sub.SubjectName,schstf.Id as TeacherId, concat(schstf.FirstName, ' ', schstf.LastName) as TeacherName
                            from ClassPeriodAcademic clP left join Class class on class.ClassId=clP.ClassId left join Subject sub on sub.SubjectId=clP.SubjectId left join SchoolStaff schstf on schstf.Id = clP.TeacherId
                            where clP.IsActive=1 and clP.SchoolId={schoolId} and clP.ClassId={classId}");
                        var properties = connection.Query<ClassPeriodViewModel>(sql.ToString()).ToList();

                        var periodDataGridView = frm.Controls.Find("PeriodDataGridView", true).FirstOrDefault() as DataGridView;
                        if (periodDataGridView != null)
                        {
                            foreach (var item in properties)
                            {

                                periodDataGridView.Rows.Add(item.Id, item.Period, item.SubjectId, item.TeacherId, item.TimingFrom, item.TimingTo, item.Duration);
                            }
                        }
                        if (!frm.Visible)
                        {
                            frm.TopLevel = true;
                            frm.Show();
                            //frm.StudentFeeSubmit.Text = "Update";
                        }

                        var currentForm = Application.OpenForms.OfType<Form>().FirstOrDefault(f => f != frm);
                        if (currentForm != null)
                        {
                            currentForm.Hide();
                        }
                    }
                }
                else
                {
                    MessageBox.Show(" not found.");
                    return;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
