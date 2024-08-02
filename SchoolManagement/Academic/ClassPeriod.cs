using DocumentFormat.OpenXml.VariantTypes;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Academic
{
    public partial class ClassPeriod : Form
    {
        private SchoolManagementEntities dbContext = new SchoolManagementEntities();
        public ClassPeriod()
        {
            InitializeComponent();
        }

        private void ClassPeriod_Load(object sender, EventArgs e)
        {
            ClassDataIntoComboBox();
            SectionDataIntoComboBox(GetSelectedClassId());
            SchoolStaffDataIntoComboBox(GetSelectedClassId());

            PeriodDataGridView.Visible = false;
            Submit.Visible = false;
        }

        private void ClassDataIntoComboBox()
        {
            var selectClass = dbContext.Classes.Where(s => s.Isdelete != true).AsEnumerable();
            classSelect.Items.Clear();

            foreach (var select in selectClass)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = select.ClassName,
                    Value = select.ClassId,
                };

                classSelect.Items.Add(item);
            }
        }

        private void SectionDataIntoComboBox(int classId)
        {
            var selectClass_Section = dbContext.Class_Section.Where(s => s.IsDelete != true && s.ClassId == classId).AsEnumerable();
            sectionSelect.Items.Clear();

            foreach (var select in selectClass_Section)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = select.SectionName,
                    Values = select.SectionId,
                };

                sectionSelect.Items.Add(item);
            }
        }

        private void SchoolStaffDataIntoComboBox(int classId)
        {
            var selectSchoolStaff = dbContext.SchoolStaffs.Where(s => s.IsDelete != true && s.ClassId == classId).AsEnumerable();
            teacherSelect.Items.Clear();

            foreach (var selectStaff in selectSchoolStaff)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = $"{selectStaff.FirstName} {selectStaff.LastName}",
                    Value = selectStaff.Id
                };

                teacherSelect.Items.Add(item);
            }
        }

        private int GetSelectedClassId()
        {
            var selectedItem = (SubjectClassDropdlist)classSelect.SelectedItem;
            return selectedItem != null ? selectedItem.Value : 0;
        }

        private void classSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedClassId = GetSelectedClassId();

            SectionDataIntoComboBox(selectedClassId);
            SchoolStaffDataIntoComboBox(selectedClassId);
        }

        private void period_KeyUp(object sender, KeyEventArgs e)
        {
            int newRow;
            bool isValidNumber = int.TryParse(period.Text, out newRow);

            if (isValidNumber && newRow > 0)
            {
                PeriodDataGridView.Rows.Clear();
                for (int i = 0; i < newRow; i++)
                {

                    PeriodDataGridView.Rows.Add();
                    PeriodDataGridView.Rows[i].Cells[0].Value = (i + 1) + " Period";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            PeriodDataGridView.Visible = true;
            Submit.Visible = true;
        }

        private void Submit_Click(object sender, EventArgs e)
        {

        }
    }
}
