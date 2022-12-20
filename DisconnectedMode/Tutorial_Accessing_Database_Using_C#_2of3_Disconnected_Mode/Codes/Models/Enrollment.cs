using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedModeExample.Models
{
    public class Enrollment
    {
        public int Id;
        public string StudentId;
        public string SubjectId;

        public Enrollment()
        {
            Id = 0;
            StudentId = "";
            SubjectId = "";
        }

        public Enrollment(int id, string studentId, string subjectId)
        {
            Id = id;
            StudentId = studentId;
            SubjectId = subjectId;
        }
    }
}
