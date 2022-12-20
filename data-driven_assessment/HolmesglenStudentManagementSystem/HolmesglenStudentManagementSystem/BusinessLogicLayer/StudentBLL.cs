using HolmesglenStudentManagementSystem.DataAccessLayer;
using HolmesglenStudentManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.BusinessLogicLayer
{
    public class StudentBLL
    {
        AppDAL appDAL;
        private StudentDAL StudentDALInstance;
        private SubjectDAL SubjectDALInstance;
        private EnrollmentDAL EnrollmentDALInstance;
        public StudentBLL()
        {
            appDAL = new AppDAL();
            StudentDALInstance = appDAL.StudentDALInstance;
            SubjectDALInstance = appDAL.SubjectDALInstance;
            EnrollmentDALInstance = appDAL.EnrollmentDALInstance;
        }
        public List<Student> GetAll()
        {
            return appDAL.StudentDALInstance.ReadAll();
        }

        public Student GetOne(string id)
        {
            return appDAL.StudentDALInstance.Read(id);
        }

        public bool Create(Student student)
        {
            if(GetOne(student.StudentId) != null)
            {
                // if student id exists, return false
                return false;
            }
            else
            {
                // if student id does not exist, create it
                appDAL.StudentDALInstance.Create(student);
            }

            return true;
        }

        public bool Update(Student student)
        {
            if (GetOne(student.StudentId) == null)
            {
                // if student id does not exist, return false
                return false;
            }
            else
            {
                // if student id exists, update it
                appDAL.StudentDALInstance.Update(student);
            }

            return true;
        }

        public bool Delete(string id)
        {
            if (GetOne(id) == null)
            {
                // if student id does not exist, return false
                return false;
            }
            else
            {
                // if student id exists, delete it
                appDAL.StudentDALInstance.Delete(id);
            }

            return true;
        }

        public List<StudentSubject> GetAllStudentSubjects()
        {
            var studentSubjects = new List<StudentSubject>();

            // step 1: get all enrollments
            var enrollments = EnrollmentDALInstance.ReadAll();
            // step 2: loop through enrollments for each enrollment,
            // look up for student name and subject title
            foreach (var enrollment in enrollments)
            {
                // step 3: get the student
                var student = StudentDALInstance.Read(enrollment.StudentIdFK);
                // step 4: get the subject
                var subject = SubjectDALInstance.Read(enrollment.SubjectIdFK);

                studentSubjects.Add(new StudentSubject(student.StudentId, student.FirstName,
                    student.LastName, subject.SubjectId, subject.Title));
            }

            return studentSubjects;
        }

        public List<StudentSubject> GetEnrolledSubjects(string StudentId)
        {
            var enrollments = EnrollmentDALInstance.ReadAll();
            var results = new List<StudentSubject>();
            foreach (var enrollment in enrollments)
            {
                if (enrollment.StudentIdFK == StudentId)
                {
                   var subject = SubjectDALInstance.Read(enrollment.SubjectIdFK);
                    var student = StudentDALInstance.Read(enrollment.StudentIdFK);
                   results.Add(new StudentSubject(student.StudentId, student.FirstName,
                    student.LastName, subject.SubjectId, subject.Title));
                }
            }
            return results;
        }
    }
}
