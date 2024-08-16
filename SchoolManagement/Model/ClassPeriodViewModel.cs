using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Model
{
    public class ClassPeriodViewModel
    {
        public int Id { get; set; }
        public string Period { get; set; }
        public string SubjectName { get; set; }
        public int SubjectId { get; set; }
        public string TeacherName { get; set; }
        public int TeacherId { get; set; }
        public string TimingFrom { get; set; }
        public string TimingTo { get; set; }
        public string Duration { get; set; }

    }
}
