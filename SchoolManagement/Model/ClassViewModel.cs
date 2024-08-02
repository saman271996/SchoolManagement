using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class ClassViewModel
    {
        public int Id { get;set; }
        public int ClassId { get; set; }
        public string SectionId { get; set; }
        public int StreamId { get; set; }
        public string ClassName { get; set; }
        public string SectionName { get; set; }
        public string StreamName { get; set; }
    }
}
