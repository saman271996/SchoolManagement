using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SchoolManagement.Helper;
using  SchoolManagement.HelperClasses;
using SchoolManagement.Model;

namespace SchoolManagement
{
    public partial class StaffDetails : Form
    {
        Form form;
        private int Id;
        SchoolManagementEntities DbContext;
        public StaffDetails()
        {
            InitializeComponent();
            DbContext = new SchoolManagementEntities();
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {
            GetdataFromDatabase();
        }

        private void GetdataFromDatabase()
        {
            //var data = from m in dbContext.SchoolStaffs
            //           join cl in dbContext.Classes on m.ClassId equals cl.ClassId
            //           join sb in dbContext.Subjects on m.SubjectId equals sb.SubjectId
            //           where m.IsDelete != true
            //           select new
            //           {
            //               m.Id,
            //               FullName = m.FirstName + " " + m.LastName,
            //               m.Gender,
            //               m.Address,
            //               ClassName = cl.ClassName,
            //               SubjectName = sb.SubjectName,
            //               m.Designation,
            //           };
            //SchoolStaffDataGridView.DataSource = data;


            var data = DbContext.SchoolStaffs.Where(m => m.IsDelete != true).Select(m => new
            {
                m.Id,
                FullName = m.FirstName + " " + m.LastName,
                m.Gender,
                m.Address,
                m.ClassId,
                m.SubjectId,
                m.Designation,
            }).ToList();
            SchoolStaffDataGridView.DataSource = data;
        }

        private void SchoolStaffDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            EditStaffViewModel.Id = 0;
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < SchoolStaffDataGridView.Columns.Count && SchoolStaffDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                Id = Convert.ToInt32(SchoolStaffDataGridView.Rows[e.RowIndex].Cells["IdColumn"].Value);
                EditStaffViewModel.Id = Id;
                if (Id != null && Id != 0)
                {
                    this.Hide();
                    form = new SchoolSatff();
                    form.Show();
                }
            }
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < SchoolStaffDataGridView.Columns.Count && SchoolStaffDataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                Id = Convert.ToInt32(SchoolStaffDataGridView.Rows[e.RowIndex].Cells["IdColumn"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var entityToDelete = DbContext.SchoolStaffs.Find(Id);

                    if (entityToDelete != null)
                    {

                        entityToDelete.IsDelete = true;
                        DbContext.SaveChanges();

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
