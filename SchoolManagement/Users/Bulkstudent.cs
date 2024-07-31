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
using static SchoolManagement.Helper.Helper;


namespace SchoolManagement
{
    public partial class Bulkstudent : Form
    {
       
        DataTable dt = new DataTable();
        SchoolManagementEntities Db = new SchoolManagementEntities();
        public Bulkstudent()
        {
            InitializeComponent();
        }
        private void BulkStudents_Load(object sender, EventArgs e)
        {

            //Class group bind
            Class.DisplayMember = "Key";
            Class.ValueMember = "Value";
            Class.DataSource =Numberreturns();

            //section bind
            Section.DisplayMember = "Key";
            Section.ValueMember = "Value";
            Section.DataSource = Enum.GetValues(typeof(Sections));
            // Student Type
            StudentTypes.DisplayMember = "Key";
            StudentTypes.ValueMember = "Value";
            StudentTypes.DataSource = Enum.GetValues(typeof(StudentType));
            //Sudent Gender
            StudentGender.DisplayMember = "Key";
            StudentGender.ValueMember = "Value";
            StudentGender.DataSource = Enum.GetValues(typeof(Gender));
          
            Multistudent.ReadOnly = true;

        }



        private void Addmore_Click(object sender, EventArgs e)
        {
            Multistudent.Rows.Add(StudentName.Text, Phone.Text, Email.Text, StudentTypes.Text, StudentGender.Text);
            Multistudent.Refresh();
        }

        private void Multistudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Multistudent.ReadOnly = false;
        }

        private void kryptonPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SubmitRecord_Click(object sender, EventArgs e)
        {
            var classid =Convert.ToInt32(Class.SelectedValue);
            var sectionId= Convert.ToInt32(Section.SelectedValue);
            var classdetails = Db.Students.AsNoTracking().Where(x=>x.SchoolId==GlobalAccount.SchoolId && x.ClassId==classid && x.SectionId==sectionId).ToList();
            
           
                if (!Db.Parents.Any(x => (x.FathersMailId == ParentAccount.FathersMailId || x.FathersMobileNumber == ParentAccount.FathersMobileNumber || x.MothersMailId == ParentAccount.MothersMailId || x.MothersMobileNumber == ParentAccount.MothersMobileNumber) && x.IsActive == true))
                {
                    var parents = new Parent
                    {
                        ParentId = ParentAccount.ParentId,
                        SchoolId = ParentAccount.SchoolId,
                        FathersName = ParentAccount.FathersName,
                        MothersName = ParentAccount.MothersName,
                        FathersMailId = ParentAccount.FathersMailId,
                        MothersMailId = ParentAccount.MothersMailId,
                        FathersMobileNumber = ParentAccount.FathersMobileNumber,
                        MothersMobileNumber = ParentAccount.MothersMobileNumber,
                        FathersOccupation = ParentAccount.FathersOccupation,
                        MothersOccupation = ParentAccount.MothersOccupation,
                        FathersBloodGroup = ParentAccount.FathersBloodGroup,
                        MothersBloodGroup = ParentAccount.MothersBloodGroup,
                        Address = ParentAccount.Address,
                        Password = ParentAccount.Password,
                    };
                    Db.Parents.Add(parents);
                    Db.SaveChanges();

                }
            }
    }
}


