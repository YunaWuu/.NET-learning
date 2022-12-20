using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models
{
    public class StudentSubject
    {
        public string StudentId;
        public string FirstName;
        public string LastName;
        public string SubjectId;
        public string SubjectTitle;

        public StudentSubject()
        {
            StudentId = "";
            FirstName = "";
            LastName = "";
            SubjectId = "";
            SubjectTitle = "";
        }
        public StudentSubject(string studentId, string firstName, string lastName, string subjectId, string subjectTitle)
        {
            StudentId = studentId;
            FirstName = firstName;
            LastName = lastName;
            SubjectId = subjectId;
            SubjectTitle = subjectTitle;
        }       
    }
}
