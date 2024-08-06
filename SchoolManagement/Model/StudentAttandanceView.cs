using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class StudentAttandanceView
    {
       public string StudentId { get; set; }
       public int SchoolId { get; set; }
       public int ClassId { get; set; }
       public string SectionId { get; set; }
       public string Attandance { get; set; }
       public DateTime AttandanceDate { get; set; }
    }
}
