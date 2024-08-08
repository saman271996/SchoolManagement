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
        SchoolManagementEntities1 DbContext;
        public StaffDetails()
        {
            InitializeComponent();
            DbContext = new SchoolManagementEntities1();
        }

        private void StaffDetails_Load(object sender, EventArgs e)
        {
            
            GetdataFromDatabase();
        }

        private void GetdataFromDatabase()
        {
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

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            form = (SchoolSatff)Application.OpenForms["SchoolSatff"];
            if (form == null)
            {
                form = new SchoolSatff();
            }
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.Visible = true;
            Application.OpenForms.OfType<MainLayoutForm>().First().MainPanel.Controls.Add(form);
            form.BringToFront();
            form.Show();
        }
    }

}
