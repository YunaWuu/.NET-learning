using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer
{
    public class DisplayAllEnrollments
    {
        private StudentBLL StudentBLLInstance;
        public DisplayAllEnrollments()
        {
            StudentBLLInstance = new StudentBLL();
        }
        public void Run()
        {
            var studentSubjects = StudentBLLInstance.GetAllStudentSubjects();
            foreach (var item in studentSubjects)
            {
                Console.WriteLine($"{item.StudentId} - {item.FirstName}  {item.LastName} - {item.SubjectId} - {item.SubjectTitle}");
            }
        }
    }
}
