using System;
using System.Collections.Generic;
using HolmesglenStudentManagementSystem.Models;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CsvHelper;
using System.Globalization;

namespace HolmesglenStudentManagementSystem.PresentationLayer
{
    public class CSVReadHelper
    {
        public CSVReadHelper() { }

        public List<Student> Run()
        {
            var result = new List<Student>();

            using (var reader = new StreamReader(@"C:\Users\yanan\Desktop\data-driven\Students.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csv.GetRecords<StudentRecord>();
                foreach (var record in records) 
                {
                    result.Add(new Student(record.StudentID, record.FirstName, record.LastName, record.Email));
                }
            }
            return result;
        }
    }
}
