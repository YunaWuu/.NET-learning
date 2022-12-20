using CsvHelper;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer
{
    public class CSVWriteHelper
    {
        public CSVWriteHelper() { }

        public void Run(List<Student> students)
        {
            var records = new List<StudentRecord>();
            foreach (var student in students)
            {
                records.Add(new StudentRecord(student.StudentId, student.FirstName, student.LastName, student.Email));
            }

            using (var writer = new StreamWriter(@"C:\Users\yanan\Desktop\data-driven\Students2.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(records);
            }
        }
    }
}
