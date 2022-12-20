using Microsoft.Data.Sqlite;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.DataAccessLayer
{
    public class EnrollmentDAL
    {
        private SqliteConnection Connection;
        public EnrollmentDAL(SqliteConnection connection)
        {
            // connect to the target database
            Connection = connection;
        }
        // create
        public void Create(Enrollment enrollment)
        {
            Connection.Open();
            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Enrollment
                (EnrollmentID, StudentID_FK, SubjectID_FK)
                VALUES(@a, @b, @c)
            ";

            command.Parameters.AddWithValue("a", enrollment.EnrollmentId);
            command.Parameters.AddWithValue("b", enrollment.StudentIdFK);
            command.Parameters.AddWithValue("c", enrollment.SubjectIdFK);

            // execute the query
            command.ExecuteReader();

            Connection.Close();
        }

        public Enrollment Read(int enrollmentID)
        {
            Enrollment enrollment = null;
            Connection.Open();
            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                SELECT *
                FROM Enrollment
                WHERE EnrollmentId = @a
            ";
            command.Parameters.AddWithValue("a", enrollmentID);


            // execute the query
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                var enrollmentId = reader.GetInt32(0);
                var studentIdFK = reader.GetString(1);
                var subjectIdFK = reader.GetString(2);
                enrollment = new Enrollment(enrollmentId, studentIdFK, subjectIdFK);
            } // else student = null

            Connection.Close();

            return enrollment;
        }

        // read all
        public List<Enrollment> ReadAll()
        {
            var enrollments = new List<Enrollment>();

            Connection.Open();

            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                SELECT *
                FROM Enrollment
            ";

            // execute the query
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                var enrollmentId = reader.GetInt32(0);
                var studentIdFK = reader.GetString(1);
                var subjectIdFK = reader.GetString(2);
                enrollments.Add(new Enrollment(enrollmentId, studentIdFK, subjectIdFK)); ;
            }
            Connection.Close();
            return enrollments;
        }

        public void Update(Enrollment enrollment)
        {
            Connection.Open();

            var command = Connection.CreateCommand();
            command.CommandText = @"
                UPDATE Enrollment
                SET StudentID_FK = @a,
                    SubjectID_FK = @b
                WHERE EnrollmentID = @c
            ";
            command.Parameters.AddWithValue("a", enrollment.StudentIdFK);
            command.Parameters.AddWithValue("b", enrollment.SubjectIdFK);
            command.Parameters.AddWithValue("c", enrollment.EnrollmentId);

            // execute the query
            command.ExecuteReader();

            Connection.Close();
        }

        public void Delete(int enrollmentID)
        {
            Connection.Open();

            var command = Connection.CreateCommand();
            command.CommandText = @"
                DELETE FROM Enrollment
                WHERE EnrollmentID = @a
            ";
            command.Parameters.AddWithValue("a", enrollmentID);

            // execute the query
            command.ExecuteReader();

            Connection.Close();
        }
    }
}
