using HolmesglenSqlite.BusinessLogicLayer;
using HolmesglenSqlite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenSqlite.PresentationLayer
{
    public class GetAllStudents
    {
        private StudentBLL StudentBLLInstance;
        public GetAllStudents(StudentBLL studentBLLInstance)
        {
            StudentBLLInstance = studentBLLInstance;
        }
        public void Run()
        {
            List<Student> students =
            StudentBLLInstance.GetAll();
            foreach (Student student in students)
            {
                Console.WriteLine(student.Id + " - " +
                student.Name);
            }
        }
    }
}
