using Krypton.Toolkit;
using CsvHelper;
using SchoolManagement.Helper;
using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using static SchoolManagement.Helper.Helper;
using IronXL;
using DocumentFormat.OpenXml.Office2016.Presentation.Command;

namespace SchoolManagement
{
    public partial class StudentExcel : Form
    {
        DataTable getTable = null;
        public List<Parent> parentexcel = new List<Parent>();
        public List<Student> studentexcel = new List<Student>();
        SchoolManagementEntities Db = new SchoolManagementEntities();
       
        public StudentExcel()
        {
            InitializeComponent();
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tt = new ToolTip();
            tt.BackColor = Color.AliceBlue;
            tt.ForeColor = Color.White;
            tt.SetToolTip(this.pictureBox1, "Download Sample");

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
                recordlabel.Visible = false;
                var Listleadcolumnandcsvcolumn = new List<LeadColumnAndCSVColumn>();
                getTable = Commonfunction.GetDataTabletFromCSVFile(f, openfiledialog1.FileName);
                var tryToMappingLeadFieldBasedOnMatchingColumnOFCSV = Commonfunction.GetSuggestionForLeadExcel();
                DataTable dt = new DataTable();
                dt.Columns.Add(new DataColumn("StudentName", typeof(string)));
                dt.Columns.Add(new DataColumn("StudentEmail", typeof(string)));
                dt.Columns.Add(new DataColumn("StudentPhoneNumber", typeof(string)));
                //dt.Columns.Add(new DataColumn("Gender", typeof(string)));
                dt.Columns.Add(new DataColumn("FatherName", typeof(string)));
                dt.Columns.Add(new DataColumn("MotherName", typeof(string)));
                dt.Columns.Add(new DataColumn("FatherEmail", typeof(string)));
                dt.Columns.Add(new DataColumn("MotherEmail", typeof(string)));
                dt.Columns.Add(new DataColumn("FatherPhoneNumber", typeof(string)));
                dt.Columns.Add(new DataColumn("MotherPhoneNumber", typeof(string)));

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
                recordlabel.Visible = true;
                //TempData["SuccessMessage"] = new SuccessMessageWithDownLoadGuid { IsSuccess = true, fileGuid = "", Message = "The File has duplicate column please make them unique" };
                //return View(nameof(ImportLeadFile), processTable);
            }
        }

        private void Upload_Click(object sender, EventArgs e)
        {
            try
            {
                parentexcel.Clear();
                studentexcel.Clear();
                var postedFile = txtfilepath.Text;
                WorkBook wb = WorkBook.Create(ExcelFileFormat.XLS);
                WorkSheet ws = wb.DefaultWorkSheet;
                if (getTable != null)
                {
                    int uniqueOrDuplicateLeads = 0;
                    var parentfname = getTable.Columns.Contains("FatherName");
                    var parentmname = getTable.Columns.Contains("MotherName");
                    var parentfemail = getTable.Columns.Contains("FatherEmail");
                    var parenteemail = getTable.Columns.Contains("MotherEmail");
                    var parentfmobile = getTable.Columns.Contains("FatherPhoneNumber");
                    var parentmmobile = getTable.Columns.Contains("MotherPhoneNumber");

                    if (parentfname == false || parentmname == false || parenteemail == false || parentfemail == false || parentfmobile == false || parentmmobile == false || parentmmobile == false)
                    {
                        MessageBox.Show("Parent column not map please check column of excel csv");
                        return;
                    }
                    var studentname=  getTable.Columns.Contains("StudentName");
                    var studentemail= getTable.Columns.Contains("StudentEmail");
                    var studentphonenumber= getTable.Columns.Contains("StudentPhoneNumber");
                    if (studentname==false || studentemail==false || studentphonenumber==false)
                    {
                        MessageBox.Show("Student column not map please check column of excel csv");
                        return;
                    }    
                    var duplicatestudent = CheckLeadsPhoneNumber(getTable);
                    if(duplicatestudent!=null)
                    { 
                    var path = "File_"+ Guid.NewGuid() + "Test.csv";
                    string folderPath = "D:\\school\\"+ path;

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
        public void SaveCSVToFile(string csvContent, string filePath)
        {
            File.WriteAllText(filePath, csvContent);
        }
        private void StudentExcel_Load(object sender, EventArgs e)
        {
            getTable = null;
        }

        public DataTable CheckLeadsPhoneNumber(DataTable leadDataTable)
        {

            var schoolid = 0;
            if (GlobalAccount.SchoolId != null)
            {
                schoolid = Convert.ToInt32(GlobalAccount.SchoolId);
            }

            CheckDuplicatePhoneNoModel checkDuplicatePhoneNoModel = new CheckDuplicatePhoneNoModel();
            var result = true;
            try
            {
                parentexcel.Clear();
                studentexcel.Clear();
                //var getorignalTable = TempData["OrginalTable"] as DataTable;
                var getorignalTable = leadDataTable;

                List<string> phoneNoList = new List<string>();

                var countPhoneNumber = 0;

                var schoolId = Convert.ToInt32(GlobalAccount.SchoolId);
                //var studendetails = Db.Students.AsNoTracking().Where(x => x.SchoolId == schoolid);
                //var parentsdetail = Db.Parents.AsNoTracking().Where(x => x.SchoolId == schoolId);
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
                        var student = new Student();
                        var parent = new Parent();
                        var ParentId = "";

                        var parentfname = row.Table.Columns.Contains("FatherName");
                        var parentmname = row.Table.Columns.Contains("MotherName");
                        var parentfemail = row.Table.Columns.Contains("FatherEmail");
                        var parenteemail = row.Table.Columns.Contains("MotherEmail");
                        var parentfmobile = row.Table.Columns.Contains("FatherPhoneNumber");
                        var parentmmobile = row.Table.Columns.Contains("MotherPhoneNumber");
                       
                        if (parentfname && parentmname)
                        {
                            var parentfs = "";
                            var parentms = "";
                            parentfs = row.FieldOrDefault<string>("FatherName");
                            parentms = row.FieldOrDefault<string>("MotherName");
                            if (!string.IsNullOrEmpty(parentfs) && !string.IsNullOrEmpty(parentms))
                            {
                                ParentId = parentfs.Substring(0, 2) + parentms.Substring(0, 2) + r.Next(0, 100000) + r.Next(0, 1000000);
                                parent.FathersName = parentfs;
                                parent.MothersName = parentms;
                                parent.Password = parentfs.Substring(0, 2) + parentms.Substring(0, 2) + r.Next(0, 100000) + r.Next(0, 1000000); 
                            }
                            else
                            {
                                row["Reason Behind Failure"] = "Parent Name is empty,please check it!";
                                row.EndEdit();
                                p = 1;
                                continue;
                            }
                        }
                        var parentfatheremail = row.Table.Columns.Contains("FatherEmail");
                        if (parentfatheremail)
                        {
                            var fatheremails = "";
                            fatheremails = row.FieldOrDefault<string>("FatherEmail");
                            if (!string.IsNullOrEmpty(fatheremails))
                            {
                                parent.FathersMailId = fatheremails;
                            }
                            else
                            {
                                row["Reason Behind Failure"] = "Father Email is empty,please check it!";
                                row.EndEdit();
                                p = 1;
                                continue;
                            }
                        }
                      
                        if (parentfatheremail)
                        {
                            var motheremails = "";
                            motheremails = row.FieldOrDefault<string>("MotherEmail");
                            if (!string.IsNullOrEmpty(motheremails))
                            {
                                parent.MothersMailId = motheremails;
                            }
                            else
                            {
                                row["Reason Behind Failure"] = "Mother Email is empty,please check it!";
                                row.EndEdit();
                                p = 1;
                                continue;
                            }
                         
                        }
                        if (parentfmobile)
                        {
                            var fatherphonenumber = "";
                            fatherphonenumber = row.FieldOrDefault<string>("FatherPhoneNumber");
                            if (!string.IsNullOrEmpty(fatherphonenumber))
                            {
                                fatherphonenumber = new string(fatherphonenumber.Where(c => char.IsDigit(c)).ToArray());
                                if (fatherphonenumber.Length == 10)
                                {
                                   parent.FathersMobileNumber=fatherphonenumber;    
                                }
                                else
                                {
                                    var reasons = "";
                                    var reason = row.Table.Columns.Contains("Reason Behind Failure");
                                    if (reason)
                                    {
                                        row["Reason Behind Failure"] = "Father Phone no. is not correct!";
                                        row.EndEdit();
                                        p = 1;
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                row["Reason Behind Failure"] = "Father Phone no. is empty!";
                                row.EndEdit();
                                p = 1;
                                continue;
                            }
                        }

                        if (parentmmobile)
                        {
                            var motherphonenumber = "";
                            motherphonenumber = row.FieldOrDefault<string>("MotherPhoneNumber");
                            if (!string.IsNullOrEmpty(motherphonenumber))
                            {
                                motherphonenumber = new string(motherphonenumber.Where(c => char.IsDigit(c)).ToArray());
                                if (motherphonenumber.Length == 10)
                                {
                                    parent.MothersMobileNumber = motherphonenumber;
                                }
                                else
                                {
                                    var reasons = "";
                                    var reason = row.Table.Columns.Contains("Reason Behind Failure");
                                    if (reason)
                                    {
                                        row["Reason Behind Failure"] = "Mother Phone no. is not correct!";
                                        row.EndEdit();
                                        p = 1;
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                row["Reason Behind Failure"] = "Mother Phone no. is empty!";
                                row.EndEdit();
                                p = 1;
                                continue;
                            }
                        }
                        if (p != 1) {
                            var parentss = Db.Parents.FirstOrDefault(x => x.FathersMobileNumber == parent.FathersMobileNumber || x.MothersMobileNumber == parent.MothersMobileNumber || x.FathersMailId == parent.FathersMailId || x.MothersMailId == parent.MothersMailId);
                            if (parentss != null)
                            {
                                ParentId = parentss.ParentId;
                               
                                p = 1;
                            }
                         
                        }


                        student.SchoolId = Convert.ToInt32(GlobalAccount.SchoolId);
                        var studentname = row.Table.Columns.Contains("StudentName");

                        if (studentname)
                        {
                            var students = "";
                            students = row.FieldOrDefault<string>("StudentName");
                            if (!string.IsNullOrEmpty(students))
                            {
                                student.ParentId = ParentId;
                                student.StudentId = students.Substring(0, 2) + r.Next(0, 100000) + r.Next(0, 1000000);
                                student.Name = students;
                                student.Password= students.Substring(0, 2) + r.Next(0, 100000) + r.Next(0, 1000000);
                            }
                            else
                            {
                                row["Reason Behind Failure"] = "Student Name is empty,please check it!";
                                row.EndEdit();
                                s = 1;
                                continue;
                            }
                        }
                        var studentemail = row.Table.Columns.Contains("StudentEmail");
                        if (studentemail)
                        {
                            var studentemails = "";
                            studentemails = row.FieldOrDefault<string>("StudentEmail");
                            if (!string.IsNullOrEmpty(studentemails))
                            {
                                student.Email = studentemails;
                            }
                            else
                            {
                                row["Reason Behind Failure"] = "Student Email is empty,please check it!";
                                row.EndEdit();
                                s = 1;
                                continue;
                            }
                        }
                        int? countryId = null;
                        var studentmobileNo = row.Table.Columns.Contains("StudentPhoneNumber");
                        var studentphonenumber = "";
                        if (studentmobileNo)
                        {
                            studentphonenumber = row.FieldOrDefault<string>("StudentPhoneNumber");
                            if (!string.IsNullOrEmpty(studentphonenumber))
                            {
                                studentphonenumber = new string(studentphonenumber.Where(c => char.IsDigit(c)).ToArray());
                                if (studentphonenumber.Length == 10)
                                {
                                    
                                }
                                else
                                {
                                    var reasons = "";
                                    var reason = row.Table.Columns.Contains("Reason Behind Failure");
                                    if (reason)
                                    {
                                        reasons = row.FieldOrDefault<string>("Reason Behind Failure");
                                        row["Reason Behind Failure"] = "Phone no. is not correct!";
                                        row.EndEdit();
                                        s = 1;
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                row["Reason Behind Failure"] = "Phone no. is empty!";
                                row.EndEdit();
                                s = 1;
                                continue;
                            }
                        }
                        if (s != 1)
                        {
                            var studentss = Db.Students.FirstOrDefault(x => x.PhoneNumber == student.PhoneNumber || x.Email == student.Email);
                            if (studentss != null)
                            {
                               
                                row["Reason Behind Failure"] = "Student is already added with same mobile and email!";
                                s = 1;
                               
                            }

                        }
                        if (p != 1)
                        {
                            parentexcel.Add(parent);
                        }
                        if (s != 1)
                        {
                            studentexcel.Add(student);
                        }
                    }
                }

                if(parentexcel!=null && parentexcel.Count>0)
                {
                    Db.Parents.AddRange(parentexcel);
                    Db.SaveChanges();
                }
                if(studentexcel != null && studentexcel.Count>0)
                {
                    Db.Students.AddRange(studentexcel);
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





    }
}





