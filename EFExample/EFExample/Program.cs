using EFExample.BusinessLogicLayer;
using EFExample.Models;
using System;

namespace EFExample
{
    internal class Program
    {
        static private AppDBContext db;
        static void Main(string[] args)
        {
            db = new AppDBContext();
            var studentBll = new StudentsBLL(db);

            studentBll.EmptyStudentTable();
            studentBll.SeedStudentTable();

            // run a test to create a new row
            studentBll.Create(new Student()
            {
                Id = "St0030",
                Name = "sbbbdv"
            });

            studentBll.DumpStudentTable();
        }
    }
}
