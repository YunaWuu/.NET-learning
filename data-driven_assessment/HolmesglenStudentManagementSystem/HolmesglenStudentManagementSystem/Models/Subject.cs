using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models
{
    public class Subject
    {
        public string SubjectId;
        public string Title;
        public int NumOfSession;
        public int HourPerSession;

        public Subject()
        {
            SubjectId = "";
            Title = "";
            NumOfSession = 0;
            HourPerSession = 0;
        }

        public Subject(string subjectId, string title, int numOfSession, int hourPerSession)
        {
            SubjectId = subjectId;
            Title = title;
            NumOfSession = numOfSession;
            HourPerSession = hourPerSession;
        }
    }
}
