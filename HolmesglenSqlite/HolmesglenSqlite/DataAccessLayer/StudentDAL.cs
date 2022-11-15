using HolmesglenSqlite.Models;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenSqlite.DataAccessLayer
{
    public class StudentDAL
    {
        private SqliteConnection Connection;
        public StudentDAL()
        {
            // connect to the target database
            Connection = new
            SqliteConnection(HolmesglenDB.ConnectionString);
        }
        public List<Student> ReadAll()
        {
            var students = new List<Student>();
            Connection.Open();
            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                SELECT *
                FROM Student
            ";
            // execute the query
            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var studentId = reader.GetString(0);
                var studentName = reader.GetString(1);
                students.Add(new Student(studentId,
                studentName));
            }
            Connection.Close();
            return students;
        }

        // Create a student
        public void Create(Student student)
        {
            Connection.Open();
            // Build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Student
                (StudentID, Name)
                VALUES(@a, @b);
            ";

            command.Parameters.AddWithValue("a", student.Id);
            command.Parameters.AddWithValue("b", student.Name);

            // Execute the query
            command.ExecuteReader();

            Connection.Close();

        }

        // Read one student by ID
        public Student Read(string id)
        {
            Student student = null;
            try
            {
                Connection.Open();
            }
            catch(SqliteException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            // Build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                SELECT *
                FROM Student
                WHERE StudentId = @a
            ";
            command.Parameters.AddWithValue("a", id);

            // Execute the query
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                var studentId = reader.GetString(0);
                var studentName = reader.GetString (1);
                student = new Student(studentId, studentName);
            }  // else student = null

            Connection.Close ();

            return student;
        }
    }

}
