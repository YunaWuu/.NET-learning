using DisconnectedMode.Models;
using System;

namespace DisconnectedMode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=C:\Users\yanan\source\repos\.NET-learning\DisconnectedMode\Tutorial_Accessing_Database_Using_C#_2of3_Disconnected_Mode\Database_File\HolmesglenInstitute.db";
            var dalDisconnected = new DALDisconnected(connectionString);
            Console.WriteLine("Before deletion");
            foreach (var student in dalDisconnected.StudentReadAll())
            {
                Console.WriteLine($"{student.Id} - {student.Name}");
            }

            // delete a new student
            Console.WriteLine("\nStudent batch operation");
            dalDisconnected.StudentBatchOperation();

            Console.WriteLine("\nAfter batch operation");
            foreach (var student in dalDisconnected.StudentReadAll())
            {
                Console.WriteLine($"{student.Id} - {student.Name}");
            }



            /*var dalDisconnected = new DALDisconnected(connectionString);
            Console.WriteLine("Before deletion");
            foreach (var student in dalDisconnected.StudentReadAll())
            {
                Console.WriteLine($"{student.Id} - {student.Name}");
            }

            // delete a new student
            Console.WriteLine("\nDeleting student - St0020");
            dalDisconnected.StudentDelete("St0020");

            Console.WriteLine("After deletion");
            foreach (var student in dalDisconnected.StudentReadAll())
            {
                Console.WriteLine($"{student.Id} - {student.Name}");
            }*/





            /*var dalDisconnected = new DALDisconnected(connectionString);
            Console.WriteLine("Before deletion");
            foreach (var student in dalDisconnected.StudentReadAll())
            {
                Console.WriteLine($"{student.Id} - {student.Name}");
            }

            Console.WriteLine("\nUpdating student - St0020");
            dalDisconnected.studentUpdate(new Student("St0020", "Name Updated"));

            Console.WriteLine("After deletion");
            foreach (var student in dalDisconnected.StudentReadAll())
            {
                Console.WriteLine($"{student.Id} - {student.Name}");
            }*/





            /*var dalDisconnected = new DALDisconnected(connectionString);
            // create a new student
            var s = new Student("St0020", "New Student");
            dalDisconnected.StudentCreate(s);
            Console.WriteLine("Reading all students using disconnected mode");
            foreach (var student in dalDisconnected.StudentReadAll())
            {
                Console.WriteLine($"{student.Id} - {student.Name}");
            }*/




            /*var dalDisconnected = new DALDisconnected(connectionString);
            Console.WriteLine("Reading all students using disconnected mode");
            foreach (var student in dalDisconnected.StudentReadAll())
            {
                Console.WriteLine($"{student.Id} - {student.Name}");
            }*/




            /* var dalConnected = new DALConnected(connectionString);
             Console.WriteLine("Reading all students using connected mode");
             foreach (var student in dalConnected.StudentReadAll())
             {
                 Console.WriteLine($"{student.Id} - {student.Name}");
             }*/
        }
    }
}
