using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial6
{
    public class TodoManager
    {
        // To achieve "Encapsulation", let's make the todo list private.
        // So that users have to call the member methods to operate the todo items.
        private List<TodoItem> TodoList;

        // This is the constructor, in which the TodoList is initialized.
        public TodoManager()
        {
            TodoList = new List<TodoItem>();
        }

        // Add: create a new todo item and append it to the end of the todo list
        public void Add()
        {
            // take user input for title and due day
            Console.WriteLine("Creating a new todo item:");
            Console.Write("Enter the title > ");
            string title = Console.ReadLine();
            Console.Write("Enter the due day (yyyy-mm-dd) > ");
            string dueDay = Console.ReadLine();

            // create a new item to the end of the todo list with a initial status 0 (todo)
            TodoList.Add(new TodoItem(title, dueDay, 0));
        }

        // SetStatus: set the status of item by index
        public void SetStatus()
        {
            // take user input for title and due day
            Console.WriteLine("Set the status of an item:");
            Console.Write("Enter the index > ");
            int index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the new status (0 - todo, 1 - in progress, 2 - done) > ");
            int newStatus = Convert.ToInt32(Console.ReadLine());


            if (index < 0 || index >= TodoList.Count)
            {
                Console.WriteLine("index entered does not exist.");
                return;
            }

            // update the status
            TodoList[index].Status = newStatus;

            // display the updated item
            Console.WriteLine("Status updated for item");
            Console.WriteLine($"Index:   {index}");
            Console.WriteLine($"Title:   {TodoList[index].Title}");
            Console.WriteLine($"Due day: {TodoList[index].Dueday}");
            Console.WriteLine($"Status:  {TodoList[index].Status}");
        }

        // Display: print the whole list to the console
        public void Display()
        {
            Console.WriteLine("The todo list");
            foreach (TodoItem item in TodoList)
            {
                Console.WriteLine($"{TodoList.IndexOf(item)} | {item.Title} | {item.Dueday} | {item.Status}");
            }
        }

    }
    }
