using Krypton.Toolkit;
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
using Dapper;
using System.Windows.Forms;
using static SchoolManagement.Helper.Helper;
using System.Data.SqlClient;

namespace SchoolManagement
{
    public partial class ClassAcademic : Form
    {
        private Panel paginationPanel;
        private List<ClassViewModel> allData;
        private int pageSize = 10;
        private int currentPage = 0;
        private string SectionId;
        private int widthtag = 0;
        private int widthtagnew = 1;
        private string StreamId;
        private SchoolManagementEntities1 dbContext;
        validations validates = new validations();
        private static readonly string ConnectionString = System.Configuration.ConfigurationManager.ConnectionStrings["SchoolManagementConnectionString"].ConnectionString;
        protected SqlConnection Con = new SqlConnection(ConnectionString);
        public ClassAcademic()
        {
            InitializeComponent();
            paginationPanel = new Panel
            {
                Name = "paginationPanel",
                Dock = DockStyle.Bottom,
                Height = 40,
                Width = 200
            };

            this.Controls.Add(paginationPanel);
            dbContext = new SchoolManagementEntities1();
        }

        private void ClassAcademic_Load(object sender, EventArgs e)
        {
            classesdataload();
        }
        private void classesdataload()
        {
            flowLayoutPanel.Visible = false;
            flowLayoutPanel.AutoSize = true;
            flowLayoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;

            GetdataFromDatabase();
            UpdatePaginationButtons();
            UpdateDataGridView();
            LoadDataIntoComboBox();
        }

        private void GetdataFromDatabase()
        {
            var schoolid = 2008;
            using (var connection = new SqlConnection(ConnectionString))
            {
                var sql = new StringBuilder($@"select cls.Id,cls.ClassId,cls.SectionId,cls.StreamId,cla.ClassName,scs.SectionName,streamed.StreamName from Class_Section cls
                left join class cla on cla.ClassId=cls.ClassId left join Section scs on scs.SectionId=cls.SectionId left join streams streamed on streamed.stramId=cls.StreamId 
                where cls.IsActive=1 and cls.SchoolId={schoolid}");
                allData = connection.Query<ClassViewModel>(sql.ToString()).ToList();
                //StudentRecord.DataSource = properties;
                foreach (var item in allData)
                {
                    ClassDataGridView.Rows.Add(item.Id,item.SectionId,item.StreamId,item.ClassName, item.SectionName, item.StreamName);
                }

            }
            //ClassDataGridView.AutoGenerateColumns = false;

            //allData = dbContext.Sections.Where(m => m.IsDelete != true && m.SchoolId == schoolid).ToList();
            //ClassDataGridView.DataSource = allData;

            //TotalCount.Text = ClassDataGridView.Rows.Count.ToString();
            UpdateDataGridView();
        }

        private void LoadDataIntoComboBox()
        {
            var selectClass = dbContext.Classes.Where(s => s.Isdelete != true).AsEnumerable();
            ClassName.Items.Clear();

            foreach (var select in selectClass)
            {
                SubjectClassDropdlist item = new SubjectClassDropdlist
                {
                    Text = select.ClassName,
                    Value = select.ClassId,
                };
                
                ClassName.Items.Add(item);
            }
            
            
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            try
            {
                SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)ClassName.SelectedItem;
                if (Submit.Text == "Submit")
                {
                    if (!string.IsNullOrEmpty(ClassName.Text))
                    {
                        Random random = new Random();
                        List<string> sectionIds = new List<string>();
                        List<Section> sections = new List<Section>();
                        List<Class_Section> classSections = new List<Class_Section>();
                        Stream streams = new Stream();
                        if (!string.IsNullOrEmpty(section_streamType.Text))
                        {
                            streams.StreamName = section_streamType.Text;
                            streams.SchoolId = GlobalAccount.SchoolId;
                            streams.ClassId = selectedClass.Value;
                            streams.IsActive = true;
                            streams.Isdelete = false;
                            streams.DateAdded = DateTime.Now;
                            streams.DateModified = DateTime.Now;
                            dbContext.Streams.Add(streams);
                            dbContext.SaveChanges();
                        }
                        foreach (Control control in flowLayoutPanel.Controls)
                        {
                            if (control is FlowLayoutPanel tagPanel)
                            {
                                Section sectioned = new Section();
                                foreach (Control innerControl in tagPanel.Controls)
                                {

                                    if (innerControl is System.Windows.Forms.Label tagLabel)
                                    {
                                        SectionId = tagLabel.Text + random.Next(0, 1000000) + random.Next(0, 2000000);

                                        sectioned.SectionId = SectionId;
                                        sectioned.ClassId = selectedClass.Value;
                                        sectioned.SectionName = tagLabel.Text;
                                        sectioned.TypeStatus = true;
                                        sectioned.IsActive = true;
                                        sectioned.IsDelete = false;
                                        sectioned.DateAdded = DateTime.Now;
                                        sectioned.DateModified = DateTime.Now;
                                        sectioned.SchoolId = GlobalAccount.SchoolId;
                                        sections.Add(sectioned);
                                        sectionIds.Add(SectionId);

                                        Class_Section newClassSection = new Class_Section()
                                        {
                                            SchoolId = GlobalAccount.SchoolId,
                                            ClassId = selectedClass.Value,
                                            ClassName = ClassName.Text,
                                            SectionName = tagLabel.Text,
                                            SectionId = SectionId,
                                            StreamId = streams.StramId,
                                            IsActive = true,
                                            IsDelete = false,
                                            DateAdded = DateTime.Now,
                                            DateModified = DateTime.Now,
                                        };
                                        classSections.Add(newClassSection);

                                    }

                                }

                            }
                        }

                        if (sections.Count > 0 && sections != null)
                        {
                            dbContext.Sections.AddRange(sections);
                            dbContext.SaveChanges();
                            dbContext.Class_Section.AddRange(classSections);
                            dbContext.SaveChanges();
                            MessageBox.Show("Data inserted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClassName.SelectedIndex = -1;
                            section_streamType.Text = "";
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
                else if (Submit.Text == "Update")
                {
                    var sectionsed = new Class_Section();
                    if (!string.IsNullOrEmpty(section_streamType.Text))
                    {
                        int str_id = 0;
                        var sections = section_streamType.Text.Trim();
                        var streamed = dbContext.Streams.FirstOrDefault(x => x.SchoolId == 2008 && x.ClassId == selectedClass.Value && x.StreamName.Trim() == sections);
                        if (streamed != null)
                        {
                            str_id = streamed.StramId;
                        }
                        sectionsed = dbContext.Class_Section.FirstOrDefault(x => x.SectionName.Trim() == ClassSection.Text.Trim() && x.SchoolId == 2008 && x.ClassId == selectedClass.Value && x.StreamId == str_id); 
                    }
                    else
                    {
                        sectionsed = dbContext.Class_Section.FirstOrDefault(x => x.SectionName.Trim() == ClassSection.Text.Trim() && x.SchoolId == 2008 && x.ClassId == selectedClass.Value);

                    }
                    if (sectionsed == null)
                    {
                        UpdateSection();
                        MessageBox.Show("updated record sucessfully");
                    }
                    else
                    {
                        MessageBox.Show("already record added");
                    }
                   

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void UpdateSection()
        {
            try
            {
                if (ClassDataGridView.SelectedRows.Count == 0)
                {
                    var sectionToUpdate = dbContext.Sections.FirstOrDefault(s => s.SectionId == SectionId && s.StreamId == StreamId);
                    var classSectionToUpdate = dbContext.Class_Section.FirstOrDefault(cs => cs.SectionId == SectionId);

                    SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)ClassName.SelectedItem;
                    if (selectedClass != null)
                    {
                        var classdatas = dbContext.Sections.FirstOrDefault(x => (x.ClassId == selectedClass.Value && x.SectionName == ClassSection.Text));

                        if (sectionToUpdate != null && classSectionToUpdate != null || sectionToUpdate != null)
                        {

                            sectionToUpdate.SectionName = ClassSection.Text;
                            sectionToUpdate.StreamName = section_streamType.Text;
                            sectionToUpdate.ClassId = selectedClass.Value;
                            sectionToUpdate.DateModified = DateTime.Now;
                            if (sectionToUpdate != null && classSectionToUpdate != null)
                            {
                                classSectionToUpdate.SectionName = ClassSection.Text;
                                classSectionToUpdate.ClassId = selectedClass.Value;
                                classSectionToUpdate.ClassName = ClassName.Text;
                                classSectionToUpdate.DateModified = DateTime.Now;
                            }

                            dbContext.SaveChanges();
                            MessageBox.Show("Data updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            ClassName.SelectedIndex = -1;
                            ClassSection.Text = "";
                            section_streamType.Text = "";
                            Submit.Text = "Submit";
                            GetdataFromDatabase();
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
                SectionId = ClassDataGridView.Rows[e.RowIndex].Cells["SectionIdColumn"].Value?.ToString();
                StreamId = ClassDataGridView.Rows[e.RowIndex].Cells["StreamIdColumn"].Value?.ToString();
                if (!string.IsNullOrEmpty(SectionId) || !string.IsNullOrEmpty(StreamId))
                {

                    DialogResult result = MessageBox.Show("Are you sure you want to delete", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        if (SectionId != null || StreamId != null)
                        {
                            var section = dbContext.Sections.FirstOrDefault(s => s.SectionId == SectionId || s.StreamId == StreamId);
                            var classSection = dbContext.Class_Section.FirstOrDefault(cs => cs.SectionId == SectionId);

                            dbContext.Class_Section.Remove(classSection);
                            dbContext.Sections.Remove(section);
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
                else
                {
                    MessageBox.Show("Section Id is null or Stream Id is null");
                }
            }

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.ColumnIndex < ClassDataGridView.Columns.Count && ClassDataGridView.Columns[e.ColumnIndex].HeaderText == "Edit")
            {
                string ClassNameEdit, ClassSectionEdit, ClassStreamNameEdit;
                SectionId = Convert.ToString(ClassDataGridView.Rows[e.RowIndex].Cells["SectionIdColumn"].Value);
                StreamId = ClassDataGridView.Rows[e.RowIndex].Cells["StreamIdColumn"].Value?.ToString();
                ClassNameEdit = Convert.ToString(ClassDataGridView.Rows[e.RowIndex].Cells["ClassNameColumn"].Value);
                ClassStreamNameEdit = Convert.ToString(ClassDataGridView.Rows[e.RowIndex].Cells["StreamNameColumn"].Value);
                ClassSectionEdit = Convert.ToString(ClassDataGridView.Rows[e.RowIndex].Cells["SectionNameColumn"].Value);
                ClassName.Text = ClassNameEdit;
                ClassSection.Text = ClassSectionEdit;
                section_streamType.Text = ClassStreamNameEdit;
                SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)ClassName.SelectedItem;
                if (selectedClass.Value == 11 || selectedClass.Value == 12)
                {
                    section_streamType.Visible = true;
                    kryptonLabel3.Visible = true;
                    this.ClassSection.Location = new System.Drawing.Point(9, 92);
                    this.section_streamType.Location = new System.Drawing.Point(297, 35);
                    this.kryptonLabel2.Location = new System.Drawing.Point(3, 70);
                    this.kryptonLabel3.Location = new System.Drawing.Point(292, 13);
                    this.flowLayoutPanel.Location = new System.Drawing.Point(297, 93);
                }
                else
                {
                    section_streamType.Visible = false;
                    kryptonLabel3.Visible = false;
                    this.ClassSection.Location = new System.Drawing.Point(297, 35);
                    this.section_streamType.Location = new System.Drawing.Point(9, 92);
                    this.kryptonLabel2.Location = new System.Drawing.Point(292, 13);
                    this.kryptonLabel3.Location = new System.Drawing.Point(3, 70);
                    this.flowLayoutPanel.Location = new System.Drawing.Point(297, 68);
                }

                this.Controls.Remove(flowLayoutPanel);
                Submit.Text = "Update";
            }
        }

        private void ClassName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)ClassName.SelectedItem;
            if (Submit.Text == "Update")
            {
                this.Controls.Clear();
                this.InitializeComponent();
                this.Refresh();
                classesdataload();
                Submit.Text = "Submit";
                return;
            }
            if (selectedClass.Value == 11 || selectedClass.Value == 12)
            {
                StreamId = "1";
                section_streamType.Visible = true;
                kryptonLabel3.Visible = true;
                this.ClassSection.Location = new System.Drawing.Point(9, 92);
                this.section_streamType.Location = new System.Drawing.Point(297, 35);
                this.kryptonLabel2.Location = new System.Drawing.Point(3, 70);
                this.kryptonLabel3.Location = new System.Drawing.Point(292, 13);
                this.flowLayoutPanel.Location = new System.Drawing.Point(297, 93);
            }
            else
            {
                StreamId = "0";
                section_streamType.Text = "";
                section_streamType.Visible = false;
                kryptonLabel3.Visible = false;
                this.ClassSection.Location = new System.Drawing.Point(297, 35);
                this.section_streamType.Location = new System.Drawing.Point(9, 92);
                this.kryptonLabel2.Location = new System.Drawing.Point(292, 13);
                this.kryptonLabel3.Location = new System.Drawing.Point(3, 70);
                this.flowLayoutPanel.Location = new System.Drawing.Point(297, 68);
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

        //private void UpdatePaginationButtons()
        //{
        //    if (paginationPanel == null)
        //    {
        //        throw new InvalidOperationException("paginationPanel is not initialized");
        //    }

        //    foreach (Control control in paginationPanel.Controls)
        //    {
        //        if (control is Button)
        //        {
        //            paginationPanel.Controls.Remove(control);
        //        }
        //    }

        //    for (int i = 0; i < TotalPages; i++)
        //    {
        //        Button paginationButton = new Button
        //        {
        //            Text = (i + 1).ToString(),
        //            Width = 30,
        //            Height = 25
        //        };
        //        paginationButton.Click += PaginationButton_Click;
        //        paginationPanel.Controls.Add(paginationButton);
        //    }

        //}

        //private void PaginationButton_Click(object sender, EventArgs e)
        //{
        //    Button button = (Button)sender;
        //    int pageNumber = int.Parse(button.Text) - 1;
        //    currentPage = pageNumber;
        //    UpdateDataGridView();
        //}

        private void UpdatePaginationButtons()
        {
            if (paginationPanel == null)
            {
                throw new InvalidOperationException("paginationPanel is not initialized");
            }

            paginationPanel.Controls.Clear();

            AddNavigationButton("First", 0, currentPage > 0);
            AddNavigationButton("<", currentPage - 1, currentPage > 0);

            int[] pageSizes = { 10, 20, 30, 40 };
            foreach (var size in pageSizes)
            {
                Button sizeButton = CreateSizeButton(size);
                paginationPanel.Controls.Add(sizeButton);
            }

            AddPageButtons();

            //AddNavigationButton(">", currentPage + 1, currentPage < TotalPages - 1);
            //AddNavigationButton("Last", TotalPages - 1, currentPage < TotalPages - 1);

            //btnBetweenPg.Text = $"Page {currentPage + 1} / {TotalPages}";
        }

        private void AddNavigationButton(string text, int pageNumber, bool enabled)
        {
            Button navButton = new Button
            {
                Text = text,
                Width = 60,
                Height = 25,
                Enabled = enabled
            };
            navButton.Click += (s, e) =>
            {
                currentPage = pageNumber;
                UpdateDataGridView();
            };
            paginationPanel.Controls.Add(navButton);
        }

        private Button CreateSizeButton(int size)
        {
            Button sizeButton = new Button
            {
                Text = size.ToString(),
                Width = 30,
                Height = 25,
                BackColor = pageSize == size ? SystemColors.Highlight : SystemColors.Control
            };
            sizeButton.Click += (s, e) =>
            {
                pageSize = size;
                currentPage = 0;
                UpdateDataGridView();
            };
            return sizeButton;
        }

        private void AddPageButtons()
        {
            //int startPage = Math.Max(0, currentPage - 2);
            //int endPage = Math.Min(TotalPages - 1, currentPage + 2);

            //if (startPage > 0)
            //{
            //    AddPageButton("...", -1, false);
            //}

            //for (int i = startPage; i <= endPage; i++)
            //{
            //    AddPageButton((i + 1).ToString(), i, true);
            //}

            //if (endPage < TotalPages - 1)
            //{
            //    AddPageButton("...", -1, false);
            //}
        }

        private void AddPageButton(string text, int pageNumber, bool enabled)
        {
            Button pageButton = new Button
            {
                Text = text,
                Width = 30,
                Height = 25,
                Enabled = enabled,
                BackColor = pageNumber == currentPage ? SystemColors.Highlight : SystemColors.Control
            };
            pageButton.Click += (s, e) =>
            {
                if (pageNumber >= 0)
                {
                    currentPage = pageNumber;
                    UpdateDataGridView();
                }
            };
            paginationPanel.Controls.Add(pageButton);
        }

        private void UpdateDataGridView()
        {
            if (allData == null || allData.Count == 0)
            {
                ClassDataGridView.DataSource = null;
                return;
            }
            //var currentPageData = allData.Skip(currentPage * pageSize).Take(pageSize).ToList();
            //ClassDataGridView.DataSource = currentPageData;

            //previousBtn.Enabled = currentPage > 0;
            //nextBtn.Enabled = currentPage < TotalPages - 1;

            //btnBetweenPg.Text = $"Page {currentPage + 1} / {TotalPages}";
        }


        private void previousBtn_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                UpdateDataGridView();
            }
        }


        private void nextBtn_Click(object sender, EventArgs e)
        {
            //if (currentPage < TotalPages - 1)
            //{
            //    currentPage++;
            //    UpdateDataGridView();
            //}
        }

        private void ClassSection_KeyUp(object sender, KeyEventArgs e)
        {
            SubjectClassDropdlist selectedClass = (SubjectClassDropdlist)ClassName.SelectedItem;
            int str_id = 0;
            var schoolid = 2008;

            if (selectedClass != null && !string.IsNullOrEmpty(ClassSection.Text))
            {
                if (Submit.Text != "Update")
                {
                    char space = (char)32;
                    if (e.KeyCode == Keys.Oemcomma || e.KeyCode == Keys.Enter || e.KeyCode == Keys.Space)
                    {

                        var section = new Class_Section();
                        if (!string.IsNullOrEmpty(section_streamType.Text))
                        {
                            var sections = section_streamType.Text.Trim();
                            var streamed = dbContext.Streams.FirstOrDefault(x => x.SchoolId == 2008 && x.ClassId == selectedClass.Value && x.StreamName.Trim() == sections);
                            section = dbContext.Class_Section.FirstOrDefault(x => x.SectionName.Trim() == ClassSection.Text.Trim() && x.SchoolId == 2008 && x.ClassId == selectedClass.Value && x.StreamId == str_id);

                            if (streamed != null)
                            {
                                str_id = streamed.StramId;
                            }
                        }
                        else
                        {
                            section = dbContext.Class_Section.FirstOrDefault(x => x.SectionName.Trim() == ClassSection.Text.Trim() && x.SchoolId == 2008 && x.ClassId == selectedClass.Value);
                        }


                        if (section == null)
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
                        else
                        {
                            ClassSection.Text = "";
                            MessageBox.Show("Already Section Exists!!");
                            return;
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Please enter the class and section");
            }
        }
        //private int TotalPages => (int)Math.Ceiling((double)allData.Count / pageSize);


    }
}
