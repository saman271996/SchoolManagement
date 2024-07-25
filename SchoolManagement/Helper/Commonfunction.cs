using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using System.Runtime.Serialization.Formatters.Binary;

namespace SchoolManagement.Helper
{
    public static class Commonfunction
    {
        public static DataTable GetDataTabletFromCSVFile(FileInfo file, string inputfilename)
        {
            try
            {
                var csvDataTable = new DataTable();

                // Read bytes from http input stream
                var csvBody = string.Empty;

                //using (BinaryReader b = new BinaryReader(file.InputStream))
                //{
                //    var binData = b.ReadBytes(file.file);
                //    csvBody = Encoding.UTF8.GetString(binData);
                //}

                Stream st = null;
               
              
                st = File.Open(inputfilename, FileMode.Open, FileAccess.ReadWrite);
                BinaryReader bf = new BinaryReader(st);
                var binData= bf.ReadBytes(Convert.ToInt32(file.Length));
                csvBody = Encoding.UTF8.GetString(binData);

                //byte[] fileBytes = File.ReadAllBytes(inputfilename);
                //using (BinaryReader b = new BinaryReader(file))
                //{
                //    var binData = b.ReadBytes(st..ContentLength);
                //    csvBody = Encoding.UTF8.GetString(binData);
                //}

                //StringBuilder sb = new StringBuilder();

                //foreach (byte b in fileBytes)
                //{
                //    sb.Append(Convert.ToString(b, 2).PadLeft(8, '0'));
                //}

                //csvBody = sb.ToString();

                var memoryStream = new MemoryStream();
                using (var streamWriter = new StreamWriter(memoryStream))
                {
                    streamWriter.Write(csvBody);
                    streamWriter.Flush();
                    memoryStream.Position = 0;

                    using (TextFieldParser csvReader = new TextFieldParser(memoryStream))
                    {
                        csvReader.SetDelimiters(new string[] { "," });
                        csvReader.HasFieldsEnclosedInQuotes = true;
                        var colFields = csvReader.ReadFields();
                        foreach (string column in colFields)
                        {
                            var datecolumn = new DataColumn(column)
                            {
                                AllowDBNull = true
                            };
                            csvDataTable.Columns.Add(datecolumn);
                        }
                        while (!csvReader.EndOfData)
                        {
                            var fieldData = csvReader.ReadFields();
                            //Making empty value as null
                            for (int i = 0; i < fieldData.Length; i++)
                            {
                                if (fieldData[i] == "")
                                {
                                    fieldData[i] = null;
                                }
                            }

                            csvDataTable.Rows.Add(fieldData);
                        }
                    }

                    return csvDataTable;
                }
            }
            catch (Exception ex)
            {
                //Log.Debug(ex);
                throw;
            }
        }
       

            public static List<CustomDropDownList> GetSuggestionForLeadExcel()
            {
                var list = new List<CustomDropDownList>();

                list.Add(new CustomDropDownList { value = "Name", label = "Name" });
                list.Add(new CustomDropDownList { value = "Email", label = "Email" });
                list.Add(new CustomDropDownList { value = "PhoneNumber", label = "PhoneNumber" });
                return list;

            }

        public class CustomDropDownList
        {
            public string label { get; set; }
            public string value { get; set; }
        }
    }
}