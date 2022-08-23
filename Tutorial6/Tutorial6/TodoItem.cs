using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial6
{
    public class TodoItem
    {
        public string Title;
        public string Dueday;
        public int Status;
        public TodoItem()
        {
            Title = "";
            Dueday = "";
            Status = 0;
        }

        public TodoItem(string title, string dueday, int status)
        {
            Title = title;
            Dueday = dueday;
            Status = status;
        }
    }
}
