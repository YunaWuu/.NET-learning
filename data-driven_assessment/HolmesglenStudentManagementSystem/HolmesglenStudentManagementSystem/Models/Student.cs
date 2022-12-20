using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models
{
    public class Student
    {
        public string StudentId;
        public string FirstName;
        public string LastName;
        public string Email;

        public Student()
        {
            StudentId = "";
            FirstName = "";
            LastName = "";
            Email = "";
        }

        public Student(string studentId, string firstName, string lastName, string email)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            Email = email;
        }
    }
}
