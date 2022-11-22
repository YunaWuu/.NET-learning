using EFExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFExample.BusinessLogicLayer
{
    public class StudentsBLL
    {
        private AppDBContext db;
        public StudentsBLL(AppDBContext appDBContext)
        {
            this.db = appDBContext;
        }

        // Method: ReadAll
        public List<Student> ReadAll()
        {
            var students = db.Students.ToList();
            return students;
        }

        // method: Read one by ID
        public Student Read(string id)
        {
            Student student = db.Students.Find(id);
            return student;
        }

        // method: Create a student
        public bool Create(Student student)
        {
            if (db.Students.Find(student.Id) == null)
            {
                db.Students.Add(student);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        // method: Update a student by ID
        public bool Update(Student student)
        {
            var studentToUpdate = db.Students.Find(student.Id);
            if (studentToUpdate == null)
            {
                return false;
            }
            studentToUpdate.Name = student.Name;
            db.SaveChanges();
            return true;
        }

        // method: Delete a student by ID
        public bool Delete(string id)
        {
            var student = db.Students.Find(id);
            if (student == null)
            {
                return false;
            }
            db.Students.Remove(student);
            db.SaveChanges();
            return true;
        }

        public void SeedStudentTable()
        {
            Console.WriteLine($"*** Seed 10 student ***");
            for (int i = 0; i < 10; i++)
            {
                db.Students.Add(new Student()
                {
                    Id = $"St000{i}",
                    Name = $"John Doe{i}"
                });
            }
            db.SaveChanges();
        }

        public void EmptyStudentTable()
        {
            Console.WriteLine($"*** Empty table Student ***");
            db.Students.RemoveRange(db.Students);
            db.SaveChanges();
        }

        public void DumpStudentTable()
        {
            Console.WriteLine($"*** Dump table Student ***");
            Console.WriteLine($"ID\t\tName");
            foreach (var student in db.Students.ToList())
            {
                Console.WriteLine($"{student.Id}\t\t{student.Name}");
            }
        }
    }
}
