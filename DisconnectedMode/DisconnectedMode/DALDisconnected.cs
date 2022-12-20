using DisconnectedMode.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedMode
{
    public class DALDisconnected
    {
        private SQLiteConnection Connection;
        // the adapter
        private SQLiteDataAdapter DataAdapter;
        // the data set
        private DataSet DBDataSet;
        // query string is used to define a subset pf the whole database.
        // in the example below, the who;e database with three tables are selected.
        private string DBQueryString = @"
            SELECT StudentID, Name
            FROM Student;

            SELECT SubjectID, Title
            FROM Subject;

            SELECT EnrollmentID, StudentID_FK, SubjectID_FK
            FROM Enrollment;
        ";

        public DALDisconnected(string connectionString)
        {
            // create a new connection
            Connection = new SQLiteConnection(connectionString);
            // create the data adapter
            DataAdapter = new SQLiteDataAdapter(DBQueryString, Connection);
            // populate the DataSet
            DBDataSet = new DataSet();
            DataAdapter.Fill(DBDataSet);
            // give each table a name to access them easily later
            DBDataSet.Tables[0].TableName = "Student";
            DBDataSet.Tables[1].TableName = "Subject";
            DBDataSet.Tables[2].TableName = "Enrollment";
        }

        public List<Student> StudentReadAll()
        {
            var students = new List<Student>();
            foreach (DataRow row in DBDataSet.Tables["Student"].Rows)
            {
                var id = row["StudentID"].ToString();
                var name = row["Name"].ToString();
                students.Add(new Student(id, name));
            }
            return students;
        }

        public void StudentCreate(Student student)
        {
            var studentTable = DBDataSet.Tables["Student"];
            // create a row object
            DataRow row = studentTable.NewRow();
            // set the values for the new row
            row["StudentID"] = student.Id;
            row["Name"] = student.Name;
            // add the new row in student table
            studentTable.Rows.Add(row);
            // automatically build required insert/update/delete command
            new SQLiteCommandBuilder(DataAdapter);
            // update the database
            DataAdapter.Update(studentTable);
        }

        public void studentUpdate(Student student)
        {
            var studentTable = DBDataSet.Tables["Student"];
            foreach (DataRow row in studentTable.Rows)
            {
                if (String.Equals(row["StudentID"].ToString(), student.Id))
                {
                    // update the row
                    row["Name"] = student.Name;
                    // automatically build required insert / update / delete command
                    new SQLiteCommandBuilder(DataAdapter);
                    // update the database
                    DataAdapter.Update(studentTable);
                    break;
                }
            }
        }

        public void StudentDelete(string id)
        {
            var studentTable = DBDataSet.Tables["Student"];
            foreach (DataRow row in studentTable.Rows)
            {
                if (String.Equals(row["StudentID"].ToString(), id))
                {
                    // delete the row
                    row.Delete();
                    // automatically build required insert / update / delete command
                    new SQLiteCommandBuilder(DataAdapter);
                    // update the database
                    DataAdapter.Update(studentTable);
                    break;
                }
            }
        }

        public void StudentBatchOperation()
        {
            var studentTable = DBDataSet.Tables["Student"];

            Console.WriteLine("Add a student - St1000");
            // create a row object
            DataRow row1 = studentTable.NewRow();
            // set the values for the new row
            row1["StudentID"] = "St1000";
            row1["Name"] = "Batch 1";
            // add the new row in student table
            studentTable.Rows.Add(row1);

            Console.WriteLine("Add another student - St1000");
            DataRow row2 = studentTable.NewRow();
            // set the values for the new row
            row2["StudentID"] = "St2000";
            row2["Name"] = "Batch 2";
            // add the new row in student table
            studentTable.Rows.Add(row2);

            Console.WriteLine("Update a student - St3000");
            foreach (DataRow row in studentTable.Rows)
            {
                if (String.Equals(row["StudentID"].ToString(), "St3000"))
                {
                    // update the row
                    row["Name"] = "Jane updated";
                    break;
                }
            }

            Console.WriteLine("Delete a student - St4000");
            foreach (DataRow row in studentTable.Rows)
            {
                if (String.Equals(row["StudentID"].ToString(), "St4000"))
                {
                    // update the row
                    row.Delete();
                    break;
                }
            }

            // automatically build required insert/update/delete command
            new SQLiteCommandBuilder(DataAdapter);
            // update the database
            DataAdapter.Update(studentTable);
        }
    }

}
