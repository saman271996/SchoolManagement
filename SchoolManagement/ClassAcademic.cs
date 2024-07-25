using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Common.EntitySql;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SchoolManagement
{
    public partial class ClassAcademic : Form
    {
        private List<Class_Section> allData;
        private int pageSize = 10;
        private int currentPage = 0;
        private int ClassId;
        private int widthtag = 0;
        private int widthtagnew = 1;
        private SchoolManagementEntities dbContext;
        validations validates = new validations();
        public ClassAcademic()
        {
            InitializeComponent();
            dbContext = new SchoolManagementEntities();

            LoadData();
        }

        private void ClassAcademic_Load(object sender, EventArgs e)
        {
            flowLayoutPanel.Visible = false;
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            TotalCount.Text = ClassDataGridView.Rows.Count.ToString();

            GetdataFromDatabase();
        }

        private void GetdataFromDatabase()
        {
            var data = dbContext.Class_Section.Where(m => m.IsDelete != true && m.SchoolId == GlobalAccount.SchoolId).Select(m => new
            {
                m.ClassId,
                m.ClassName,
               
            }).ToList();
            ClassDataGridView.DataSource = data;
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            if (Submit.Text == "Submit")
            {
                try
                {
                    if (!string.IsNullOrEmpty(ClassName.Text))
                    {
                        Random random = new Random();
                        List<string> sectionIds = new List<string>();
                        List<Section> sections = new List<Section>();

                        foreach (Control control in flowLayoutPanel.Controls)
                        {
                            if (control is FlowLayoutPanel tagPanel)
                            {
                                Section sectioned = new Section();
                                foreach (Control innerControl in tagPanel.Controls)
                                {

                                    if (innerControl is System.Windows.Forms.Label tagLabel)
                                    {
                                        var sectionId = tagLabel.Text + random.Next(0, 1000000) + random.Next(0, 2000000);
                                        sectioned.SectionId = sectionId;
                                        sectioned.SectionName = tagLabel.Text;
                                        sectioned.SchoolId = GlobalAccount.SchoolId;
                                        sections.Add(sectioned);
                                        sectionIds.Add(sectionId);
                                    }

                                }

                            }
                        }

                        if (sections.Count > 0 && sections != null)
                        {
                            dbContext.Sections.AddRange(sections);
                            dbContext.SaveChanges();
                            string concatenatedSectionNames = string.Join(", ", sectionIds);

                            Class_Section newClassSection = new Class_Section()
                            {
                                ClassName = ClassName.Text,
                                //SectionId = concatenatedSectionNames,
                                IsActive = true,
                                IsDelete = false,
                                DateAdded = DateTime.Now,
                                DateModified = DateTime.Now,
                            };
                            dbContext.Class_Section.Add(newClassSection);
                            dbContext.SaveChanges();
                            MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClassName.Text = "";
                            flowLayoutPanel.Controls.Clear();
                            flowLayoutPanel.Visible = false;
                            GetdataFromDatabase();
                        }
                        else
                        {
                            MessageBox.Show("Please enter the section");
                            return;
                        }
                    }
                    else
                    { 
                        MessageBox.Show("Please enter the class");
                        return;
                    }
                    
                }
                catch (Exception ex)
                {

                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else if (Submit.Text == "Update")
            {
                UpdateSection();
            }

        }

        private void UpdateSection()
        {
            try
            {
                if (ClassDataGridView.SelectedRows.Count == 0)
                {
                    var classSectionToUpdate = dbContext.Class_Section.Find(ClassId);

                    if (classSectionToUpdate != null)
                    {

                        if (!string.IsNullOrEmpty(ClassName.Text))
                        {
                            Random random = new Random();
                            List<string> sectionIds = new List<string>();
                            List<Section> sections = new List<Section>();

                            foreach (Control control in flowLayoutPanel.Controls)
                            {
                                if (control is FlowLayoutPanel tagPanel)
                                {
                                    Section updateSectioned = new Section();
                                    foreach (Control innerControl in tagPanel.Controls)
                                    {
                                        if (innerControl is System.Windows.Forms.Label tagLabel)
                                        {
                                            var sectionId = tagLabel.Text + random.Next(0, 1000000) + random.Next(0, 2000000);
                                            updateSectioned.SectionId = sectionId;
                                            updateSectioned.SectionName = tagLabel.Text;
                                            updateSectioned.SchoolId = GlobalAccount.SchoolId;
                                            sections.Add(updateSectioned);
                                            sectionIds.Add(sectionId);
                                        }
                                    }
                                }
                            }

                            if (sections.Count > 0 && sections != null)
                            {
                                dbContext.Sections.AddRange(sections);
                                dbContext.SaveChanges();

                                string concatenatedSectionNames = string.Join(", ", sectionIds);
                                classSectionToUpdate.ClassName = ClassName.Text;
                                //classSectionToUpdate.SectionId = concatenatedSectionNames;

                                classSectionToUpdate.DateModified = DateTime.Now;
                                dbContext.SaveChanges();
                                MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                ClassName.Text = "";
                                flowLayoutPanel.Controls.Clear();
                                flowLayoutPanel.Visible = false;
                                Submit.Text = "Submit";
                                GetdataFromDatabase();
                            }
                            else
                            {
                                MessageBox.Show("Please enter the section");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Please enter the class");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Record not found or failed to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void ClassDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < ClassDataGridView.Columns.Count && ClassDataGridView.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int ClassId = Convert.ToInt32(ClassDataGridView.Rows[e.RowIndex].Cells["ClassIdColumn"].Value);
                DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var entityToDelete = dbContext.Class_Section.Find(ClassId);

                    if (entityToDelete != null)
                    {

                        entityToDelete.IsDelete = true;
                        dbContext.SaveChanges();

                        GetdataFromDatabase();

                        MessageBox.Show("Record deleted successfully.");
                    }
                    else
                    {
                        MessageBox.Show("Record not found or failed to delete.");
                    }
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < ClassDataGridView.Columns.Count && ClassDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                string ClassNameEdit, ClassSectionEdit;
                ClassId = Convert.ToInt32(ClassDataGridView.Rows[e.RowIndex].Cells["ClassIdColumn"].Value);
                ClassNameEdit = Convert.ToString(ClassDataGridView.Rows[e.RowIndex].Cells["ClassNameColumn"].Value);
                ClassSectionEdit = Convert.ToString(ClassDataGridView.Rows[e.RowIndex].Cells["SectionNameColumn"].Value);
                ClassName.Text = ClassNameEdit;
                flowLayoutPanel.Controls.Clear();

                string[] sectionNames = ClassSectionEdit.Split(new string[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string sectionName in sectionNames)
                {
                    AddTag(sectionName);
                }
                Submit.Text = "Update";
                flowLayoutPanel.Visible = true;
            }
        }

        private void TextBoxClassSection_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == ',' || e.KeyChar == (char)Keys.Enter || e.KeyChar == (char)Keys.Space)
            {
                AddTag(ClassSection.Text.Trim());
                e.Handled = true;

                if (flowLayoutPanel.Controls.Count > 0)
                {
                    flowLayoutPanel.Visible = true;
                    if (widthtag >= flowLayoutPanel.Width)
                    {
                        flowLayoutPanel.Height += 26;
                    }
                }
                else
                {
                    flowLayoutPanel.Visible = false;
                }

                ClassSection.Clear();
            }
        }

        private void AddTag(string tag)
        {
            if (!string.IsNullOrWhiteSpace(tag))
            {
                System.Windows.Forms.FlowLayoutPanel tagPanel = new System.Windows.Forms.FlowLayoutPanel();
                tagPanel.AutoSize = true;
                tagPanel.FlowDirection = FlowDirection.LeftToRight;

                System.Windows.Forms.Label tagLabel = new System.Windows.Forms.Label();
                tagLabel.Text = tag;
                tagLabel.AutoSize = true;
                tagLabel.Padding = new Padding(4);
                tagLabel.Margin = new Padding(0);
                tagLabel.BackColor = System.Drawing.Color.Aqua;
                tagPanel.Controls.Add(tagLabel);

                System.Windows.Forms.Button closeButton = new System.Windows.Forms.Button();
                closeButton.Text = "x";
                closeButton.Width = 20;
                closeButton.Height = 24;
                closeButton.Margin = new Padding(0);
                closeButton.FlatStyle = FlatStyle.Flat;
                closeButton.FlatAppearance.BorderSize = 0;
                closeButton.ForeColor = Color.Black;
                closeButton.BackColor = System.Drawing.Color.Aqua;
                closeButton.Click += (sender, e) =>
                {
                    widthtag = tagPanel.Width;
                    closepanelwidth(widthtag, tagPanel);

                };
                tagPanel.Controls.Add(closeButton);
                flowLayoutPanel.Controls.Add(tagPanel);
                widthtag = tagPanel.Width;

            }
        }

        public void closepanelwidth(int sizewidth, FlowLayoutPanel tagpanel)
        {
            flowLayoutPanel.Controls.Remove(tagpanel);
            widthtag = tagpanel.Width;
            if (widthtag >= flowLayoutPanel.Width)
            {
                flowLayoutPanel.Height -= 26;
            }
            if (flowLayoutPanel.Controls.Count == 0)
            {
                flowLayoutPanel.Visible = false;
            }
        }

        private void LoadData()
        {
            allData = dbContext.Class_Section.Where(m => m.IsDelete == !true).ToList();
            ClassDataGridView.AutoGenerateColumns = false;
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            var currentPageData = allData.Skip(currentPage * pageSize).Take(pageSize).ToList();

            ClassDataGridView.DataSource = currentPageData;

            btnPrevious.Enabled = currentPage > 0;
            btnNext.Enabled = currentPage < (allData.Count / pageSize);
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                UpdateDataGridView();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < (allData.Count / pageSize))
            {
                currentPage++;
                UpdateDataGridView();
            }
        }
    }
}
