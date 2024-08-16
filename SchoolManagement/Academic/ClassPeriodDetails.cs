using Dapper;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.Excel;
using DocumentFormat.OpenXml.Office2013.PowerPoint.Roaming;
using DocumentFormat.OpenXml.VariantTypes;
using SchoolManagement.Helper;
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
    public partial class ClassPeriodDetails : Form
    {
        private int classId;
        private string sectionId;
        private int schoolId;
        private int teacherId;
        private string periodEdit;
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities1 Db = new SchoolManagementEntities1();
        Form frm;
        public ClassPeriodDetails()
        {
            InitializeComponent();
        }

        private void ClassPeriodDetails_Load(object sender, EventArgs e)
        {
            ClassRecord();
        }

        private void ClassRecord()
        {
            try
            {
                var schoolid = 2008;
                System.Data.DataTable dt = new System.Data.DataTable();

                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = new StringBuilder($@"select clteach.Id,clteach.SchoolId,clteach.ClassId,clteach.SectionId,clteach.ClassTeacher,clteach.Period,class.ClassName,concat(schstf.FirstName, ' ', schstf.LastName) as StaffName,clasec.SectionName
                    from ClassTeacherAcademic clteach left join Class class on class.ClassId=clteach.ClassId left join SchoolStaff schstf on schstf.Id = clteach.ClassTeacher 
                    left join Class_Section clasec on clasec.SectionId =clteach.SectionId 
                    where clteach.IsActive=1 and clteach.SchoolId={schoolid}");
                    var properties = connection.Query<ClassRoutineViewModel>(sql.ToString()).ToList();

                    foreach (var item in properties)
                    {
                        DetailPeriodDataGridView.Rows.Add(item.Id, item.ClassName, item.SectionName, item.StaffName, item.Period, item.ClassId, item.SectionId, item.SchoolId, item.ClassTeacher);
                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void DetailPeriodDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStaffViewModel.ClassId = 0;
            EditStaffViewModel.SchoolId = 0;
            EditStaffViewModel.SectionId = "";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < DetailPeriodDataGridView.Columns.Count && DetailPeriodDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                classId = Convert.ToInt32(DetailPeriodDataGridView.Rows[e.RowIndex].Cells["ClassIdColumn"]?.Value);
                schoolId = Convert.ToInt32(DetailPeriodDataGridView.Rows[e.RowIndex].Cells["SchoolIdColumn"]?.Value);
                sectionId = DetailPeriodDataGridView.Rows[e.RowIndex].Cells["SectionIdColumn"].Value?.ToString();
                teacherId = Convert.ToInt32(DetailPeriodDataGridView.Rows[e.RowIndex].Cells["TeacherIdColumn"]?.Value);
                periodEdit = DetailPeriodDataGridView.Rows[e.RowIndex].Cells["TotalPeriodColumn"].Value?.ToString();

                EditStaffViewModel.SchoolId = schoolId;

                var a = classId;
                classperiods.Classid = a;
                var b = sectionId;
                classperiods.SectionId = b;

                var c = teacherId;
                classperiods.TeacherId = c;

                var d = periodEdit;
                classperiods.TotalPeriod = d;

                getPeriodData(classId, schoolId, sectionId);

            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < DetailPeriodDataGridView.Columns.Count && DetailPeriodDataGridView.Columns[e.ColumnIndex].HeaderText == "ViewPeriod")
            {
                
            }
        }

        public void getPeriodData(int classId, int schoolId, string sectionId)
        {
            try
            {
                var frm = (ClassPeriod)Application.OpenForms["ClassPeriod"];
                if (frm == null)
                {

                    frm = new ClassPeriod();
                }
                var getTotalPeriods = Db.ClassTeacherAcademics.AsNoTracking().FirstOrDefault(x => x.ClassId == classId && x.SchoolId == schoolId && x.SectionId == sectionId);
                if (getTotalPeriods != null)
                {
                    var getPeriodDetails = Db.ClassPeriodAcademics.AsNoTracking().FirstOrDefault(x => x.ClassId == classId && x.SchoolId == schoolId && x.SectionId == sectionId);
                    if (getPeriodDetails != null)
                    {
                        using (var connection = new SqlConnection(ConnectionString))
                        {
                            var sql = new StringBuilder($@"select clP.Id as Id,clP.Period,clP.TimingFrom,clP.TimingTo,clP.Duration,sub.SubjectId,sub.SubjectName,schstf.Id as TeacherId, concat(schstf.FirstName, ' ', schstf.LastName) as TeacherName
                                from ClassPeriodAcademic clP left join Class class on class.ClassId=clP.ClassId left join Subject sub on sub.SubjectId=clP.SubjectId left join SchoolStaff schstf on schstf.Id = clP.TeacherId
                                where clP.IsActive=1 and clP.SchoolId={schoolId} and clP.ClassId={classId} and clP.SectionId='{sectionId}'");
                            var properties = connection.Query<ClassPeriodViewModel>(sql.ToString()).ToList();

                            var periodDataGridView = frm.Controls.Find("PeriodDataGridView", true).FirstOrDefault() as DataGridView;
                            if (periodDataGridView != null)
                            {
                                foreach (var item in properties)
                                {
                                    
                                    periodDataGridView.Rows.Add(item.Id, item.Period, item.SubjectId, item.TeacherId, item.TimingFrom, item.TimingTo, item.Duration);
                                }

                                var subjectColumn = periodDataGridView.Columns["SubjectColumn"] as DataGridViewComboBoxColumn;
                                subjectColumn.DisplayMember = "Text";
                                subjectColumn.ValueMember = "Value";
                                subjectColumn.DataSource = properties.Select(p => new { Value = p.SubjectId, Text = p.SubjectName }).Distinct().ToList();

                                var teacherColumn = periodDataGridView.Columns["TeacherNameColumn"] as DataGridViewComboBoxColumn;
                                teacherColumn.DisplayMember = "Text";
                                teacherColumn.ValueMember = "Value";
                                teacherColumn.DataSource = properties.Select(p => new { Value = p.TeacherId, Text = p.TeacherName }).Distinct().ToList();
                            }
                            if (!frm.Visible)
                            {
                                frm.TopLevel = true;
                                //frm.StartPosition = FormStartPosition.CenterScreen;
                                frm.Show();
                                frm.Submit.Text = "Update";
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
                        MessageBox.Show("Period record not found.");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Total period record not found.");
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
