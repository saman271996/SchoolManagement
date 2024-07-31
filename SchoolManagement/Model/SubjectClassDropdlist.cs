using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class SubjectClassDropdlist
    {
        public string Text { get; set; }
        public int Value { get; set; }
        public string Values { get; set; }

        public override string ToString()
        {
            return Text; 
        }
    }
}
