using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement.Model
{
    public class StudentViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string FathersName { get; set; }
        public string MothersName { get; set; }
        public string FathersMailId { get; set; }
        public string MothersMailId { get; set; }
        public string FathersMobileNumber { get; set; }
        public string MothersMobileNumber { get; set; }
        public string FathersOccupation { get; set; }
        public string MothersOccupation { get; set; }

    }
}
