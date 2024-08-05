using IronXL;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SchoolManagement.Helper.Helper;

namespace SchoolManagement
{
    public partial class StudentAttandence : Form
    {
        DataTable getTable = null;
        SchoolManagementEntities Db = new SchoolManagementEntities();
        List <StudentAttandance> studentattandanceexcel=new List<StudentAttandance> ();
        public StudentAttandence()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var processTable = new ProcessTable();
            System.Windows.Forms.OpenFileDialog openfiledialog1 = new System.Windows.Forms.OpenFileDialog();
            openfiledialog1.ShowDialog();
            openfiledialog1.Filter = "allfiles|*.xls";

            FileInfo f = new FileInfo(openfiledialog1.FileName);
            f = new FileInfo(openfiledialog1.FileName);
            long postedFile = f.Length;

            if (!Helper.Helper.CheckIfFileSizeWithinLimit(postedFile, 25 * 1024 * 1024)) //25 Mb
            {
                MessageBox.Show("File Shoul not more than be greater than 10 Mb");
                return;
            }
            if (!string.Equals(f.Extension, ".csv", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("File Shoul be csv file");
                return;
            }
            txtfilepath.Text = openfiledialog1.FileName;
            try
            {
                //recordlabel.Visible = false;
                var Listleadcolumnandcsvcolumn = new List<LeadColumnAndCSVColumn>();
                getTable = Commonfunction.GetDataTabletFromCSVFile(f, openfiledialog1.FileName);
                var tryToMappingLeadFieldBasedOnMatchingColumnOFCSV = Commonfunction.GetSuggestionForLeadExcel();
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("StudentId", typeof(string)));
                dt.Columns.Add(new DataColumn("SchoolId", typeof(string)));
                dt.Columns.Add(new DataColumn("ClassId", typeof(string)));
                dt.Columns.Add(new DataColumn("SectionId", typeof(string)));
                dt.Columns.Add(new DataColumn("Attandance", typeof(string)));
                dt.Columns.Add(new DataColumn("Attandance Date", typeof(string)));


                for (int i = 0; i < getTable?.Rows.Count; i++)
                {
                    DataRow dr = dt.NewRow();
                    if (i == 2)
                        break;
                    var leadcolumnandcsvcolumn = new LeadColumnAndCSVColumn();
                    var rowrecord = new RowRecord();
                    int j = 0;
                    List<object> details = new List<object>();
                    foreach (DataColumn col in getTable.Columns)
                    {
                        leadcolumnandcsvcolumn.FieldsInStudent = tryToMappingLeadFieldBasedOnMatchingColumnOFCSV.FirstOrDefault(x => x.label == col.ColumnName)?.value ?? "Do Not Map This Field,Please Check Your Excel";
                        leadcolumnandcsvcolumn.FieldsInCsV = col.ColumnName;

                        leadcolumnandcsvcolumn.Record_1_InFile = getTable.Rows[i][col.ColumnName].ToString();
                        details.Add(getTable.Rows[i][col.ColumnName]);
                        dr[j] = getTable.Rows[i][col.ColumnName];
                        //StudentGridExcel.Rows[i].Cells[j] = getTable.Rows[i][col.ColumnName];
                        j++;
                    }

                    dt.Rows.Add(dr);
                    Listleadcolumnandcsvcolumn.Add(leadcolumnandcsvcolumn);
                    var tabledetail = string.Join(", ", details);
                }
                StudentGridExcel.DataSource = dt;
                processTable.CompareLeadColumnToCSV = Listleadcolumnandcsvcolumn;
                StudentGridExcel.Refresh();
            }
            catch (DuplicateNameException ex)
            {
                //recordlabel.Visible = true;
                //TempData["SuccessMessage"] = new SuccessMessageWithDownLoadGuid { IsSuccess = true, fileGuid = "", Message = "The File has duplicate column please make them unique" };
                //return View(nameof(ImportLeadFile), processTable);
            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                var postedFile = txtfilepath.Text;
                WorkBook wb = WorkBook.Create(ExcelFileFormat.XLS);
                WorkSheet ws = wb.DefaultWorkSheet;
                if (getTable != null)
                {
                    int uniqueOrDuplicateLeads = 0;
                    var StudentId = getTable.Columns.Contains("StudentId");
                    var SchoolId = getTable.Columns.Contains("SchoolId");
                    var ClassId = getTable.Columns.Contains("ClassId");
                    var SectionId = getTable.Columns.Contains("SectionId");
                    var Attandance = getTable.Columns.Contains("Attandance");
                    var AttandanceDate = getTable.Columns.Contains("Attandance Date");

                    if (StudentId == false || SchoolId == false || SchoolId == false || ClassId == false || SectionId == false || Attandance == false || AttandanceDate == false)
                    {
                        MessageBox.Show("Parent column not map please check column of excel csv");
                        return;
                    }

                    var duplicatestudent = CheckStudentAttandance(getTable);
                    if (duplicatestudent != null)
                    {
                        var path = "File_" + Guid.NewGuid() + "Test.csv";
                        string folderPath = "D:\\school\\" + path;

                        StringBuilder sb = new StringBuilder();

                        IEnumerable<string> columnNames = duplicatestudent.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
                        sb.AppendLine(string.Join(",", columnNames));

                        foreach (DataRow row in duplicatestudent.Rows)
                        {
                            IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                            sb.AppendLine(string.Join(",", fields));
                        }
                        using (System.Windows.Forms.SaveFileDialog saveFileDialog = new System.Windows.Forms.SaveFileDialog())
                        {
                            saveFileDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
                            saveFileDialog.FilterIndex = 1;
                            saveFileDialog.RestoreDirectory = true;
                            // Set initial directory to user's Documents folder
                            string filePath = saveFileDialog.FileName;

                            if (!string.IsNullOrWhiteSpace(folderPath))
                            {
                                SaveCSVToFile(sb.ToString(), folderPath);
                                this.Controls.Clear();
                                this.InitializeComponent();
                                this.Refresh();
                                MessageBox.Show("Successfully file uploaded!,if any error please check the excel file with reason column,added to your pc!");
                                return;

                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                this.Controls.Clear();
                this.InitializeComponent();
                this.Refresh();
                MessageBox.Show(ex.ToString());
            }

        }
        public DataTable CheckStudentAttandance(DataTable leadDataTable)
        {

            var result = true;
            try
            {
                studentattandanceexcel.Clear();
                //var getorignalTable = TempData["OrginalTable"] as DataTable;
                var getorignalTable = leadDataTable;

                List<string> phoneNoList = new List<string>();

                var countPhoneNumber = 0;

                var schoolId = Convert.ToInt32(GlobalAccount.SchoolId);

                if (!getorignalTable.Columns.Contains("Reason Behind Failure"))
                {
                    getorignalTable.Columns.Add("Reason Behind Failure", typeof(string));
                }

                using (var modifiyOrignalTable = new DataTable())
                {
                    foreach (DataRow row in getorignalTable.Rows)
                    {

                        int p = 0;
                        int s = 0;
                        Random r = new Random();
                        var student = new StudentAttandance();
                        var StudentId = row.Table.Columns.Contains("StudentId");
                        var SchoolId = row.Table.Columns.Contains("SchoolId");
                        var ClassId = row.Table.Columns.Contains("ClassId");
                        var SectionId = row.Table.Columns.Contains("SectionId");
                        var Attandance = row.Table.Columns.Contains("Attandance");
                        var AttandanceDate = row.Table.Columns.Contains("Attandance Date");


                        if (StudentId)
                        {
                            var studentsid = "";
                            studentsid = row.FieldOrDefault<string>("StudentId");

                            if (!string.IsNullOrEmpty(studentsid))
                            {
                                student.StudentId = studentsid;
                            }
                            else
                            {
                                row["Reason Behind Failure"] = "StudentId is empty,please check it!";
                                row.EndEdit();
                                p = 1;
                                continue;
                            }
                        }

                        if (SchoolId)
                        {
                            var schoolsid = "";
                            schoolsid = row.FieldOrDefault<string>("SchoolId");
                            if (!string.IsNullOrEmpty(schoolsid))
                            {
                                student.SchoolId = Convert.ToInt32(schoolsid);
                            }
                            else
                            {
                                row["Reason Behind Failure"] = "School Id is empty,please check it!";
                                row.EndEdit();
                                p = 1;
                                continue;
                            }
                        }

                        if (ClassId)
                        {
                            var classesid = "";
                            classesid = row.FieldOrDefault<string>("ClassId");
                            if (!string.IsNullOrEmpty(classesid))
                            {
                                student.ClassId = Convert.ToInt32(classesid);
                            }
                            else
                            {
                                row["Reason Behind Failure"] = "Class Id is empty,please check it!";
                                row.EndEdit();
                                p = 1;
                                continue;
                            }

                        }
                        if (SectionId)
                        {
                            var SectionIds = "";
                            SectionIds = row.FieldOrDefault<string>("SectionId");
                            if (!string.IsNullOrEmpty(SectionIds))
                            {

                                student.SectionId = SectionIds;
                            }
                            else
                            {
                                var reasons = "";
                                var reason = row.Table.Columns.Contains("Reason Behind Failure");
                                if (reason)
                                {
                                    row["Reason Behind Failure"] = "Section Id is empty,please check it!";
                                    row.EndEdit();
                                    p = 1;
                                    continue;
                                }
                            }
                        }
                        if (Attandance)
                        {
                            var Attandances = "";
                            Attandances = row.FieldOrDefault<string>("");
                            if (!string.IsNullOrEmpty(Attandances))
                            {
                                var attandance = 0;
                                if(Attandances=="Present")
                                {
                                    student.Attandance = 1;
                                }
                                else if(Attandances=="Absent")
                                {
                                    student.Attandance = 2;
                                }
                                else if(Attandances.Trim()=="HalfDay")
                                {
                                    student.Attandance = 3;
                                }
                                
                            }
                            else
                            {
                                var reasons = "";
                                var reason = row.Table.Columns.Contains("Reason Behind Failure");
                                if (reason)
                                {
                                    row["Reason Behind Failure"] = "Section Id is empty,please check it!";
                                    row.EndEdit();
                                    p = 1;
                                    continue;
                                }
                            }
                        }
                        if (AttandanceDate)
                        {
                            var SectionIds = "";
                            SectionIds = row.FieldOrDefault<string>("SectionId");
                            if (!string.IsNullOrEmpty(SectionIds))
                            {
                                student.SectionId = SectionIds;
                            }
                            else
                            {
                                var reasons = "";
                                var reason = row.Table.Columns.Contains("Reason Behind Failure");
                                if (reason)
                                {
                                    row["Reason Behind Failure"] = "Section Id is empty,please check it!";
                                    row.EndEdit();
                                    p = 1;
                                    continue;
                                }
                            }
                        }
                        studentattandanceexcel.Add(student);
                        Db.SaveChanges();
                    }
                }


               
                if (studentattandanceexcel != null && studentattandanceexcel.Count > 0)
                {
                    Db.StudentAttandances.AddRange(studentattandanceexcel);
                    Db.SaveChanges();
                }

                return getorignalTable;
            }
            catch (Exception ex)
            {
                //Log.Debug(ex);
                throw;
                //return Json(ex);
            }
        }
        public void SaveCSVToFile(string csvContent, string filePath)
        {
            File.WriteAllText(filePath, csvContent);
        }

    }
}


