using Microsoft.Data.Sqlite;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.DataAccessLayer
{
    public class SubjectDAL
    {        
        private SqliteConnection Connection;
        public SubjectDAL(SqliteConnection connection)
        {
            // connect to the target database
            Connection = connection;
        }

        // create
        public void Create(Subject subject)
        {
            Connection.Open();
            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                INSERT INTO Subject 
                (SubjectID, Title, NumberOfSession, HourPerSession)
                VALUES(@a, @b, @c, @d)
            ";
            command.Parameters.AddWithValue("a", subject.SubjectId);
            command.Parameters.AddWithValue("b", subject.Title);
            command.Parameters.AddWithValue("c", subject.NumOfSession);
            command.Parameters.AddWithValue("d", subject.HourPerSession);

            // execute the query
            command.ExecuteReader();

            Connection.Close();
        }

        public Subject Read(string subjectID)
        {
            Subject subject = null;
            Connection.Open();
            // build the query command
            var command = Connection.CreateCommand();
            command.CommandText = @"
                SELECT *
                FROM Subject
                WHERE SubjectId = @a
            ";
            command.Parameters.AddWithValue("a", subjectID);

            // execute the query
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                var subjectId = reader.GetString(0);
                var subjectTitle = reader.GetString(1);
                var subjectNumOfSession = reader.GetInt32(2);
                var subjectHourPerSession = reader.GetInt32(3);
                subject = new Subject(subjectId, subjectTitle, subjectNumOfSession, subjectHourPerSession);
            } // else subject = null

            Connection.Close();    
            return subject;
        }

        // read all
        public List<Subject> ReadAll()
        {
            var subjects = new List<Subject>();
            
            Connection.Open();

            var command = Connection.CreateCommand();
            command.CommandText = @"
                SELECT *
                FROM Subject
            ";

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                var subjectId = reader.GetString(0);
                var subjectTitle = reader.GetString(1);
                var subjectNumOfSession = reader.GetInt32(2);
                var subjectHourPerSession = reader.GetInt32(3);
                subjects.Add(new Subject(subjectId, subjectTitle, subjectNumOfSession,subjectHourPerSession));
            }
            Connection.Close();
            return subjects;
        }

        public void Update(Subject subject)
        {
            Connection.Open();

            var command = Connection.CreateCommand();
            command.CommandText = @"
                UPDATE Subject
                SET Title = @a,
                    NumberOfSession = @b,
                    HourPerSession = @c
                WHERE SubjectID = @d
            ";
            command.Parameters.AddWithValue("a", subject.Title);
            command.Parameters.AddWithValue("b", subject.NumOfSession);
            command.Parameters.AddWithValue("c", subject.HourPerSession);
            command.Parameters.AddWithValue("d", subject.SubjectId);

            command.ExecuteReader();

            Connection.Close();
        }

        public void Delete(string subjectID)
        {
            Connection.Open();

            var command = Connection.CreateCommand();
            command.CommandText = @"
                DELETE FROM Subject
                WHERE SubjectID = @a
            ";
            command.Parameters.AddWithValue("a", subjectID);
            command.ExecuteReader();

            Connection.Close();
        }
    }
}
