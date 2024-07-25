using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement
{
    public class ListItem
    {
        public string Text { get; set; }
        public object Value { get; set; }
        public ListItem(int Value, string Text) {
         
            Value = Value;
            Text = Text;
        }
        public override string ToString()
        {
            return Text;
        }

    }


}
