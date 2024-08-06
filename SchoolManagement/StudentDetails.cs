using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SchoolManagement.Helper;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using DocumentFormat.OpenXml.Bibliography;
using System.IO;
using Dapper;
namespace SchoolManagement
{
    public partial class StudentDetails : Form
    {
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        SchoolManagementEntities Db = new SchoolManagementEntities();
        Form frm;
        public StudentDetails()
        {
            InitializeComponent();
        }

        private void StudentDetails_Load(object sender, EventArgs e)
        {

            studentrecord();
        }
        private void studentrecord()
        {
            try
            {
                var schoolid = 2008;
                DataTable dt = new DataTable();
                
               
                using (var connection = new SqlConnection(ConnectionString))
                {
                    var sql = new StringBuilder($@"select stu.Id,stu.Name,stu.Email,stu.PhoneNumber,par.FathersName,par.MothersName,par.FathersMailId,
                    par.MothersMailId,par.FathersMobileNumber,par.MothersMobileNumber,par.FathersOccupation,par.MothersOccupation
                    from Student stu left join parent par on par.ParentId=stu.ParentId
                    where stu.IsActive=1 and stu.SchoolId={schoolid}");
                    var properties = connection.Query<StudentViewModel>(sql.ToString()).ToList();
                    //StudentRecord.DataSource = properties;
                    foreach (var item in properties)
                    {
                        StudentRecord.Rows.Add(item.Name, item.Email, item.PhoneNumber, "", "", "", item.FathersName, item.MothersName, item.FathersMobileNumber, item.MothersMobileNumber);

                    }

                }
            }
            catch (Exception ex) { 
            }
        }

        private void StudentRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frm = new Student_MainForm();
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            frm.TopLevel = false;
            frm.Visible = true;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(frm);
           
            frm.Show();
 
        }
    }
}
