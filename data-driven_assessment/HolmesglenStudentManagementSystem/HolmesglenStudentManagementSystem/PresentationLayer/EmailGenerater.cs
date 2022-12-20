using HolmesglenStudentManagementSystem.BusinessLogicLayer;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.PresentationLayer
{
    public class EmailGenerater
    {
        private StudentBLL StudentBLLInstance;
        private Student student;
        public EmailGenerater(Student student)
        {
            StudentBLLInstance = new StudentBLL();
            this.student = student;
        }
        public void Run()
        {
            var studentSubjects = StudentBLLInstance.GetEnrolledSubjects(student.StudentId);
            Console.WriteLine($"Dear {student.FirstName},\n\n\nYou have been enrolled in the following subject\n\n");
            foreach (var item in studentSubjects)
            {
                Console.WriteLine($"> {item.SubjectTitle} ({item.SubjectId})\n");
            }
            Console.WriteLine("\nPlease login to your account and confirm the above enrolments.\n\nRegards,\n\nCAIT Department");
        }
    }
}
