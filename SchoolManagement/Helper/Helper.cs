using SchoolManagement.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Helper
{
    public class Helper
    {
        public enum BloodGroups
        {
            [Description("A")]
            A,
            [Description("B")]
            B,
            [Description("AB")]
            AB
        }
        public enum Gender
        {
            [Description("Male")]
            Male = 1,
            [Description("Female")]
            Female = 2,
            [Description("Transgender")]
            Transgender = 3
        }
        public enum StudentType
        {
            [Description("Deskcolor")]
            Deskcolor = 1,
            [Description("Hosteler")]
            Hosteler = 2,
        }

        public static List<int> Numberreturns()
        {
            List<int> number = new List<int>();
            for (int i = 1; i <= 12; i++)
            {
                number.Add(i);
            }
            return number;
        }
        public enum Sections
        {
            [Description("A")]
            A = 1,
            [Description("B")]
            B = 2,
            [Description("C")]
            C = 3
        }
        public enum StudentParents
        {
            [Description("1Vikash")]
            Vikash1 = 1,
            [Description("2Rohit")]
            Rohit2 = 2,
            [Description("3Sumit")]
            Sumit3 = 3,
            [Description("4Amit")]
            Amit4 = 4,
            [Description("5Ashok")]
            Ashok5 = 5,
            [Description("6Puneet")]
            Puneet6 = 6,
            [Description("7Dinesh")]
            Dinesh7 = 7,
            [Description("8Rohits")]
            Rohits8 = 8,
            [Description("9Sumits")]
            Sumits9 = 9,
            [Description("10Amits")]
            Amits10 = 10,
            [Description("11Ashoks")]
            Ashoks11 = 11,
            [Description("12Puneets")]
            Puneets12 = 12,
            [Description("Kautilya Kumar Sharma h/o Shri Mamata Kumar Sharma")]
            KautilyaKumarSharmah_oShriMamataKumarSharma = 13,
        }
        public enum StudentAdmission
        {
            [Description("Select")]
            Select = 0,
            [Description("Single")]
            Single = 1,
            [Description("Multiple")]
            Multiple = 2,

        }
        public enum SchoolStaffs
        {
            [Description("Director")]
            Director = 0,
            [Description("Principal")]
            Principal = 1,
            [Description("Accountant_Manager")]
            Accountant_Manager = 2,
            [Description("Teacher")]
            Teacher = 3,
            [Description("Receptionist")]
            Receptionist = 4,
            [Description("Librarian")]
            Librarian = 5,
        }
        public enum SchoolStaffGender
        {
            [Description("Male")]
            Male = 0,
            [Description("Female")]
            Female = 1,
            [Description("Other")]
            Other = 2,
        }
        public class ProcessTable
        {

            public int TempleteId { get; set; }
            public string TempleteName { get; set; }
            public bool SaveLeads { get; set; }
            public List<LeadColumnAndCSVColumn> CompareLeadColumnToCSV { get; set; }

            public CheckDuplicatePhoneNoModel CheckDuplicatePhoneNoModel { get; set; }
        }
        public class CheckDuplicatePhoneNoModel
        {
            public bool IsDataInFile { get; set; }
            public bool IsDuplicate { get; set; }
            public int Total { get; set; }
            public int TotalDuplicate { get; set; }
            public int Unique { get; set; }
            public int DuplicateInExcel { get; set; }
            public int DuplicateInDB { get; set; }
            public bool ShouldDownloadDuplicateFile { get; set; }
        }
        public static bool CheckIfFileSizeWithinLimit(long filesize, int allowFileSize = 1 * 1024 * 1024 * 1024)
        {
            var isValid = true;
            // Verification.  
            if (filesize != null)
            {
                // Initialization.  
                var fileSize = filesize;
                // Settings.  
                isValid = fileSize <= allowFileSize;
            }
            // Info  
            return isValid;
        }

    }

}
