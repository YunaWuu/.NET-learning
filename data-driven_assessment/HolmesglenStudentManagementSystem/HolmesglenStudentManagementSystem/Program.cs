using HolmesglenStudentManagementSystem.PresentationLayer;
using HolmesglenStudentManagementSystem.DataAccessLayer;
using System;
using HolmesglenStudentManagementSystem.PresentationLayer.StudentPL;
using HolmesglenStudentManagementSystem.Models;
using HolmesglenStudentManagementSystem.BusinessLogicLayer;

namespace HolmesglenStudentManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                AppDAL appDAL = new AppDAL();
                var studentDAL = appDAL.StudentDALInstance;
                var subjectDAL = appDAL.SubjectDALInstance;
                var enrollmentDAL = appDAL.EnrollmentDALInstance;

                // test subject table CURD
                subjectDAL.Create(new Subject("Su0111", "JavaScript", 9, 6));

                subjectDAL.Update(new Subject("Su0111", "Python", 9, 5));

                subjectDAL.Delete("Su0111");

                var subject = subjectDAL.Read("Su0001");
                Console.WriteLine($"{subject.SubjectId} - {subject.Title} - {subject.NumOfSession} - {subject.HourPerSession}");

                var result = subjectDAL.ReadAll();
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.SubjectId} - {item.Title} - {item.HourPerSession} - {item.NumOfSession}");
                }
                
                //test enrollment table CURD
                //enrollmentDAL.Create(new Enrollment(10, "St0001", "Su0003"));

                //enrollmentDAL.Update(new Enrollment(10, "St0002", "Su0001"));

                //enrollmentDAL.Delete(10);

                //var enrollment = enrollmentDAL.Read(1);
                //Console.WriteLine($"{enrollment.EnrollmentId} - {enrollment.StudentIdFK} - {enrollment.SubjectIdFK}");

                /*var result = enrollmentDAL.ReadAll();
                foreach (var item in result)
                {
                    Console.WriteLine($"{item.EnrollmentId} - {item.StudentIdFK} - {item.SubjectIdFK}");
                }*/

                //test enrollment report result
                /*DisplayAllEnrollments test = new DisplayAllEnrollments();

                test.Run();*/

                // test email generater result
                /*var student = appDAL.StudentDALInstance.Read("St0001");
                
                EmailGenerater generater = new EmailGenerater(student);
                generater.Run();*/

                // test import csv file
                /*CSVReadHelper reader = new CSVReadHelper();
                var students = reader.Run();*/

                /*foreach (var element in students) 
                {
                    studentDAL.Create(element);
                }*/

                // test export csv file
                /*var updatedStudents = studentDAL.ReadAll();

                foreach (var e in updatedStudents) 
                {
                    Console.WriteLine($"{e.StudentId}\t{e.FirstName}\t{e.LastName}\t{e.Email}");
                }

                CSVWriteHelper writer = new CSVWriteHelper();
                writer.Run(updatedStudents);*/

                // test disconnected mode
                /*StudentDALDisconnected disconnectedStudentDal = new StudentDALDisconnected(HolmesglenDB.ConnectionString);
                var students =  disconnectedStudentDal.StudentReadAll();
                foreach (var e in students)
                {
                    Console.WriteLine($"{e.StudentId}\t{e.FirstName}\t{e.LastName}\t{e.Email}");
                }*/

                // test entity framework
                /*AppDBContext context = new AppDBContext();
                SubjectBLL b = new SubjectBLL(context);
                //b.Delete("Su9999");

                //b.Update(new SubjectRecord("Su9999", "Python", 9, 5));

                //b.Create(new SubjectRecord("Su9999", "C++", 18, 6));

                *//*var subject = b.Read("Su0001");
                Console.WriteLine($"{subject.SubjectId} - {subject.Title} - {subject.NumberOfSession} - {subject.HourPerSession}");*/

                /*var result = b.ReadAll();
                foreach (var element in result) 
                {
                    Console.WriteLine($"{element.SubjectId} - {element.Title} - {element.NumberOfSession} - {element.HourPerSession}");
                }*/

                //(new GetAllStudents()).Run();
                //(new GetOneStudent()).Run();
                //(new CreateStudent()).Run();
                //(new UpdateStudent()).Run();
                //(new DeleteStudent()).Run();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }                 
        }
    }
}
