using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class ClassRoutineViewModel
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string SubjectName { get; set; }
        public string SectionName { get; set; }
        public string StaffName { get; set; }
        public string Period { get; set; }
        public int ClassId { get; set; }
        public string SectionId { get; set; }
        public int SchoolId { get; set; }
        public int ClassTeacher { get;set; }
    }
}
