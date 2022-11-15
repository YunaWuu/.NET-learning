using System;
using System.Collections.Generic;

namespace OOP2
{
    public class program
    {

        public class Person
        {
            public string FirstName;
            public string LastName;
            public string Email;

            public string GetFullName()
            {
                return $"{FirstName} {LastName}";
            }
        }

        public class Teacher : Person
        {
            public string TypeOfEmployment;
        }

        public class Student : Person
        {
            public string Qualification;
            public List<string> SubjectList = new List<string>();

            public void EnrolASubject(string subjectTitle)
            {
                SubjectList.Add(subjectTitle);
            }
        }

        public class InternationalStudent : Student
        {
            public string VisaStatus;
        }

        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Select a command");
                Console.WriteLine("1. Add teacher");
                Console.WriteLine("2. Add student");
                Console.WriteLine("3. Enrol stuent to subject");
                Console.WriteLine("Generate report");
                string command = Console.ReadLine();

                switch (command)
                {
                    case "1":

                        break;
                }
            }

            //test

            /*InternationalStudent student1 = new InternationalStudent();
            student1.FirstName = "Yuna";
            student1.LastName = "Wu";
            Console.WriteLine(student1.GetFullName());*/




        }


        /* public class CircleCalculator
         {

                public double Radius;
                private double Pi;

             public CircleCalculator()
             {
                 Pi = 3.1415926;
             }

            public double Circumference()
             {
                 double perimeter = 2 * Pi * Radius;
                 return perimeter;
             }

            public bool SetRadius(double r)
             {
                 if  (r < 0)
                 {
                     return false;
                 }
                 Radius = r;
                 return true;
             }

            public double GetRadius()
             {
                 return Radius;
             }

         }   */

    }
}
