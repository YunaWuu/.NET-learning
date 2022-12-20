using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.DataAccessLayer
{
    public class StudentDALDisconnected
    {
            private SQLiteConnection Connection;
            // the adapter
            private SQLiteDataAdapter DataAdapter;
            // the data set
            private DataSet DBDataSet;
            private string DBQueryString = @"
            SELECT *
            FROM Student;
        ";
            public StudentDALDisconnected(string connectionString)
            {
                // create a new connection
                Connection = new SQLiteConnection(connectionString);
                // create the data adapter
                DataAdapter = new SQLiteDataAdapter(DBQueryString, Connection);
                // populate the DataSet
                DBDataSet = new DataSet();
                DataAdapter.Fill(DBDataSet);
                // give the table a name to access it easily later
                DBDataSet.Tables[0].TableName = "Student";
            }
            public List<Student> StudentReadAll()
            {
                var students = new List<Student>();
                foreach (DataRow row in DBDataSet.Tables["Student"].Rows)
                {
                    var studentId = row["StudentID"].ToString();
                    var firstName = row["FirstName"].ToString();
                    var lastName = row["LastName"].ToString();
                    var email = row["Email"].ToString();
                    students.Add(new Student(studentId, firstName, lastName, email));
                }
                return students;
            }
    }
}
