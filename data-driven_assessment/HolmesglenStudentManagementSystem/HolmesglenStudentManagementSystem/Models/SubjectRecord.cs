using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models
{
    public class SubjectRecord
    {
        [Key]
        public string SubjectId { get; set; }
        public string Title { get; set; }
        public int NumberOfSession { get; set; }
        public int HourPerSession { get; set; }

        public SubjectRecord(string subjectId, string title, int numberOfSession, int hourPerSession)
        {
            SubjectId = subjectId;
            Title = title;
            NumberOfSession = numberOfSession;
            HourPerSession = hourPerSession;
        }
    }
}
