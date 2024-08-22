using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class StudentFeeModel
    {
        public int Id { get; set; }
        public int SchoolId { get; set; }
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string YearFee { get; set; }
        public string Installment { get; set; }
    }
}
