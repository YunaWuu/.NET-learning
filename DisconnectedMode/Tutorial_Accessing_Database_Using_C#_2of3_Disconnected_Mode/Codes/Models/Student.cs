using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedModeExample.Models
{
    public class Student
    {
        public string Id;
        public string Name;

        public Student()
        {
            Id = "";
            Name = "";
        }

        public Student(string id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
