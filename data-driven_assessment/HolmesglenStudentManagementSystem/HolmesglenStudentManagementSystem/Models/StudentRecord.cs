using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models
{
    public class StudentRecord
    {
        public string StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public StudentRecord() { }

        public StudentRecord(string StudentID, string FirstName, string LastName, string Email)
        {
            this.StudentID = StudentID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
        }
    }
}
