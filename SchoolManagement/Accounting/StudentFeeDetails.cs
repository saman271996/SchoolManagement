using Dapper;
using DocumentFormat.OpenXml.VariantTypes;
using DocumentFormat.OpenXml.Wordprocessing;
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
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Accounting
{
    public partial class StudentFeeDetails : Form
    {
        private int schoolId;
        private int id;
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

            StuFeeDetailsDataGridView.ReadOnly = true;
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
                id = Convert.ToInt32(StuFeeDetailsDataGridView.Rows[e.RowIndex].Cells["IdColumn"]?.Value);
                schoolId = Convert.ToInt32(StuFeeDetailsDataGridView.Rows[e.RowIndex].Cells["SchoolIdColumn"]?.Value);
                EditStaffViewModel.Id = id;
                EditStaffViewModel.SchoolId = schoolId;

                int rowIndex = e.RowIndex;
                DataGridViewRow row = StuFeeDetailsDataGridView.Rows[e.RowIndex];
                row.ReadOnly = false;
                DataGridViewButtonColumn buttonColumn = (DataGridViewButtonColumn)StuFeeDetailsDataGridView.Columns["EditColumn"];
                buttonColumn.Text = "Update";
               
            }
        }

        public void UpdateStudentFeeData(int id, int schoolId)
        {
            try
            {
               
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
     }
}
