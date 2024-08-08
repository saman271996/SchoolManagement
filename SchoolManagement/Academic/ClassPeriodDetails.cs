using Dapper;
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

namespace SchoolManagement.Academic
{
    public partial class ClassPeriodDetails : Form
    {
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
            GetClassPeriodRecord();
        }

        private void GetClassPeriodRecord()
        {
            try
            {
                var schoolid = 2008;
                DataTable dt = new DataTable();

                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = new StringBuilder($@"select clteach.Id,class.ClassName,concat(schstf.FirstName, ' ', schstf.LastName) as StaffName,clasec.SectionName
                    from ClassTeacherAcademic clteach left join Class class on class.ClassId=clteach.ClassId left join SchoolStaff schstf on schstf.Id = clteach.ClassTeacher 
                    left join Class_Section clasec on clasec.SectionId =clteach.SectionId 
                    where clteach.IsActive=1 and clteach.SchoolId={schoolid}");
                    var properties = connection.Query<ClassRoutineViewModel>(sql.ToString()).ToList();

                    foreach (var item in properties)
                    {
                        DetailPeriodDataGridView.Rows.Add(item.Id, item.ClassName, item.SectionName, item.StaffName);
                    }

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
