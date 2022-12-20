using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models
{
    public class Enrollment
    {
        public int EnrollmentId;
        public string StudentIdFK;
        public string SubjectIdFK;

        public Enrollment()
        {
            EnrollmentId = 0;
            StudentIdFK = "";
            SubjectIdFK = "";
        }

        public Enrollment(int enrollmentId, string studentIdFK, string subjectIdFK)
        {
            EnrollmentId = enrollmentId;
            StudentIdFK = studentIdFK;
            SubjectIdFK = subjectIdFK;
        } 
    }
}
