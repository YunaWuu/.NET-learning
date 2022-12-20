using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisconnectedMode.Models
{
    public class Subject
    {
        public string Id;
        public string Title;

        public Subject()
        {
            Id = "";
            Title = "";
        }

        public Subject(string id, string title)
        {
            Id = id;
            Title = title;
        }
    }
}
