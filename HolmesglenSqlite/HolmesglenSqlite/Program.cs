using HolmesglenSqlite.BusinessLogicLayer;
using HolmesglenSqlite.DataAccessLayer;
using HolmesglenSqlite.Models;
using HolmesglenSqlite.PresentationLayer;
using Microsoft.Data.Sqlite;
using System;

namespace HolmesglenSqlite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*var studentDAL = new StudentDAL();
            var result = studentDAL.Read("St0010");
            if (result == null)
            {
                Console.WriteLine("no record found");
            }
            else
            {
                Console.WriteLine(result.Id + " - " + result.Name);
            }*/





            /*// To test if can create a student
            var studentDAL = new StudentDAL();
            studentDAL.Create(new Student("St0020", "Loki"));*/





            // Convert to three-layer architecture
             var studentDAL = new StudentDAL();
             var studentBLL = new StudentBLL(studentDAL);
             var getAllStudents = new
             GetAllStudents(studentBLL);
             getAllStudents.Run();




            /* // Connect C# application to the database
             // Define the connection string for the target database
             string connectionString = @"Data Source = C:\Users\yanan\HolmesglenInstitute.db";

             // Connect to the target database
             var connection = new SqliteConnection(connectionString);
             connection.Open();

             // Build the query command
             var command = connection.CreateCommand();
             command.CommandText = @"
                 SELECT * 
                 FROM Student
             ";

             // Execute the query
             var reader = command.ExecuteReader();

            // Get result and display
            while (reader.Read())
            {
                var studentId = reader.GetString(0);
                var studentName = reader.GetString(1);
                Console.WriteLine(studentId + " - " + studentName);
            }*/
        }
    }
}
