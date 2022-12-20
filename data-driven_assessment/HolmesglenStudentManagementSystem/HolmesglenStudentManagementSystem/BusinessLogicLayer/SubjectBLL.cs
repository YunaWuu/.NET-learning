using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.BusinessLogicLayer
{
    public class SubjectBLL
    {
        private AppDBContext db;
        public SubjectBLL(AppDBContext appDBContext)
        {
            this.db = appDBContext;
        }

        // Method: ReadAll
        public List<SubjectRecord> ReadAll()
        {
            var subjects = db.Subject.ToList();
            return subjects;
        }

        // method: Read one by ID
        public SubjectRecord Read(string id)
        {
            SubjectRecord subject = db.Subject.Find(id);
            return subject;
        }

        // method: Create a student
        public bool Create(SubjectRecord subject)
        {
            if (db.Subject.Find(subject.SubjectId) == null)
            {
                db.Subject.Add(subject);
                db.SaveChanges();
                return true;
            }
            return false;
        }

        // method: Update a student by ID
        public bool Update(SubjectRecord subject)
        {
            var subjectToUpdate = db.Subject.Find(subject.SubjectId);
            if (subjectToUpdate == null)
            {
                return false;
            }
            subjectToUpdate.Title = subject.Title;
            db.SaveChanges();
            return true;
        }

        // method: Delete a student by ID
        public bool Delete(string id)
        {
            var subject = db.Subject.Find(id);
            if (subject == null)
            {
                return false;
            }
            db.Subject.Remove(subject);
            db.SaveChanges();
            return true;
        }
    }
}
