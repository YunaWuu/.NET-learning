using DisconnectedModeExample.Models;
using System;

namespace DisconnectedModeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string connectionString = @"Data Source=D:\tmp\HolmesglenInstitute.db";
            var dalDisconnected = new DALDisconnected(connectionString);
            Console.WriteLine("Before deletion");
            foreach (var student in dalDisconnected.StudentReadAll())
            {
                Console.WriteLine($"{student.Id} - {student.Name}");
            }

            Console.WriteLine("\nStudent batch operation");
            dalDisconnected.StudentBatchOperation();

            Console.WriteLine("\nAfter batch operation");
            foreach (var student in dalDisconnected.StudentReadAll())
            {
                Console.WriteLine($"{student.Id} - {student.Name}");
            }

        }
        //Console.WriteLine("\nupdating student - St0020");
        //dalDisconnected.StudentUpdate(new Student("St0020", "Name Updated"));
        //Console.WriteLine("\nadding student - St0021");
        //dalDisconnected.StudentCreate(new Student("St0021", "lala"));
        //Console.WriteLine("\ndeleting student - St0020");
        //dalDisconnected.StudentDelete("St0020");

        //var dalConnected = new DALConnected(connectionString);
        //Console.WriteLine("Reading all students using connected mode");
        //foreach (var student in dalConnected.StudentReadAll())
        //{
        //    Console.WriteLine($"{student.Id} - {student.Name}");
        //}



        //Console.WriteLine("\nReading all subjects using disconnected mode");
        //foreach (var subject in dalDisconnected.SubjectReadAll())
        //{
        //    Console.WriteLine($"{subject.Id} - {subject.Title}");
        //}

        //Console.WriteLine("\nReading all enrollments using disconnected mode");
        //foreach (var enrollment in dalDisconnected.EnrollmentReadAll())
        //{
        //    Console.WriteLine($"{enrollment.Id} - {enrollment.StudentId} - {enrollment.SubjectId}");
        //}

        //}
    }
}
