using Krypton.Toolkit;
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

namespace SchoolManagement
{
    public partial class StudentExcel : Form
    {
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
            DataTable getTable = null;
           
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
                dt.Columns.Add(new DataColumn("Name", typeof(string)));
                dt.Columns.Add(new DataColumn("Email", typeof(string)));
                dt.Columns.Add(new DataColumn("Phone Number", typeof(string)));
                dt.Columns.Add(new DataColumn("Gender", typeof(string)));
                dt.Columns.Add(new DataColumn("Student Type", typeof(string)));
      
                for (int i=0;i< getTable?.Rows.Count; i++)
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
            //try
            //{
                var postedFile = txtfilepath.Text;

                //string ConnString = @"connectionString=""metadata=res://*/Model.SchoolManagement.csdl|res://*/Model.SchoolManagement.ssdl|res://*/Model.SchoolManagement.msl;provider=System.Data.SqlClient;provider connection string=&quot;data source=DESKTOP-9T1O73D;initial catalog=SchoolManagement;integrated security=True;multipleactiveresultsets=True;encrypt=True;trustservercertificate=True;"" providerName=""System.Data.SqlClient";
                //DataTable Data = new DataTable();

                //using (OleDbConnection conn = new OleDbConnection(ConnString))
                //{
                //    conn.Open();

                //    OleDbCommand cmd = new OleDbCommand(@"SELECT * FROM [dataGridView1_Data$]", conn);
                //    OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
                //    adapter.Fill(Data);



                //    conn.Close();
                //}
                //string ConnStr = ConnString;
                //using (SqlBulkCopy bulkCopy = new SqlBulkCopy(ConnStr))
                //{
                //    bulkCopy.DestinationTableName = "Student";
                //    bulkCopy.ColumnMappings.Add("Name", "Name");
                //    bulkCopy.ColumnMappings.Add("Email", "Email");
                //    bulkCopy.ColumnMappings.Add("PhoneNumber", "PhoneNumber");

                //    bulkCopy.WriteToServer(Data);
                //    MessageBox.Show("UPLOAD SUCCESSFULLY");
                //}
                //    DataTable getTable = null;
                //    var processTable = new ProcessTable();
                //    if (postedFile != null)
                //    {

                //        try
                //        {
                //            getTable = CommonFunctions.GetDataTabletFromCSVFile(postedFile);
                //        }
                //        catch (DuplicateNameException ex)
                //        {
                //            //TempData["SuccessMessage"] = new SuccessMessageWithDownLoadGuid { IsSuccess = true, fileGuid = "", Message = "The File has duplicate column please make them unique" };
                //            //return View(nameof(ImportLeadFile), processTable);
                //        }


                //        TempData["OrginalTable"] = getTable; //will user tempdata

                //        var user = SessionHandler.UserData;



                //        var tryToMappingLeadFieldBasedOnMatchingColumnOFCSV = LeadCSVHelper.GetSuggestionForLeadExcel(LeadCSVHelper.CurrentCompanyCustomQuestion);

                //        var Listleadcolumnandcsvcolumn = new List<LeadColumnAndCSVColumn>();

                //        if (userInput?.TempleteId != null && userInput.TempleteId == -1)//user dint select any templete
                //        {
                //            foreach (DataColumn col in getTable.Columns)
                //            {
                //                var leadcolumnandcsvcolumn = new LeadColumnAndCSVColumn
                //                {
                //                    FieldsInLead = tryToMappingLeadFieldBasedOnMatchingColumnOFCSV.FirstOrDefault(x => x.label == col.ColumnName)?.value ?? "Do Not Map This Field",
                //                    FieldsInCsV = col.ColumnName
                //                };
                //                if (getTable.Rows.Count > 0)
                //                {
                //                    leadcolumnandcsvcolumn.Record_1_InFile = getTable.Rows[0][col.ColumnName].ToString();
                //                }
                //                if (getTable.Rows.Count > 1)
                //                {
                //                    leadcolumnandcsvcolumn.Record_2_InFile = getTable.Rows[1][col.ColumnName].ToString();
                //                }

                //                Listleadcolumnandcsvcolumn.Add(leadcolumnandcsvcolumn);

                //            }
                //        }
                //        else
                //        {
                //            var getTemplete = Db.CompanyExcelLeadTempletes.AsNoTracking().FirstOrDefault(x => x.Id == userInput.TempleteId);

                //            var processTableFromTempleteMapping = JsonConvert.DeserializeObject<ProcessTable>(getTemplete.TempleteMapping);

                //            foreach (DataColumn col in getTable.Columns)
                //            {
                //                var leadcolumnandcsvcolumn = new LeadColumnAndCSVColumn
                //                {  //map lead fields from templete saved value
                //                    FieldsInLead = processTableFromTempleteMapping.CompareLeadColumnToCSV.FirstOrDefault(a => a.FieldsInCsV == col.ColumnName)?.FieldsInLead ?? "Do Not Map This Field",
                //                    FieldsInCsV = col.ColumnName
                //                };
                //                if (getTable.Rows.Count > 0)
                //                {
                //                    leadcolumnandcsvcolumn.Record_1_InFile = getTable.Rows[0][col.ColumnName].ToString();
                //                }
                //                if (getTable.Rows.Count > 1)
                //                {
                //                    leadcolumnandcsvcolumn.Record_2_InFile = getTable.Rows[1][col.ColumnName].ToString();
                //                }
                //                Listleadcolumnandcsvcolumn.Add(leadcolumnandcsvcolumn);

                //            }
                //        }

                //        processTable.CompareLeadColumnToCSV = Listleadcolumnandcsvcolumn;
                //    }
                //}
                //catch (Exception ex)
                //{

                //}
            }

        private void StudentExcel_Load(object sender, EventArgs e)
        {

        }

        
    }
    }

        
    


