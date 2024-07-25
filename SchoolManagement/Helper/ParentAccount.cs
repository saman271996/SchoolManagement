using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Helper
{
    public static class ParentAccount
    {
      
        public static string ParentId { get; set; }
        public static int SchoolId { get; set; }
        public static string Password { get; set; }
        public static string FathersName { get; set; }
        public static string MothersName { get; set; }
        public static string FathersMailId { get; set; }
        public static string MothersMailId { get; set; }
        public static string NoOfChildren { get; set; }
        public static string FathersMobileNumber { get; set; }
        public  static string MothersMobileNumber { get; set; }
        public static string FathersOccupation { get; set; }
        public static string MothersOccupation { get; set; }
        public static string FathersBloodGroup { get; set; }
        public static string MothersBloodGroup { get; set; }
        public static string Address { get; set; }
        public static Nullable<bool> IsActive { get; set; }
        public static Nullable<bool> IsDelete { get; set; }
        public static Nullable<System.DateTime> DateAdded { get; set; }
        public  static Nullable<System.DateTime> DateModified { get; set; }
    }
}
