using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class PhoneRecord
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public PhoneRecord() { }

        public PhoneRecord(string name, string email, string mobile)
        {
            Name = name;
            Email = email;
            Mobile = mobile;
        }
    }
}
