using System;
using System.Collections.Generic;

namespace Tutorial6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***** Create the todo list app *****");
            TodoManager todoMgr = new TodoManager();

            Console.WriteLine("\n***** Create the 1st item *****");
            todoMgr.Add();

            Console.WriteLine("\n***** Create the 2nd item *****");
            todoMgr.Add();

            Console.WriteLine("\n***** Create the 3rd item *****");
            todoMgr.Add();

            Console.WriteLine("\n***** Display the list *****");
            todoMgr.Display();

            Console.WriteLine("\n***** Set the statues of an item *****");
            todoMgr.SetStatus();

            Console.WriteLine("\n***** Display the list again *****");
            todoMgr.Display();








            /* List<TodoItem> todoList = new List<TodoItem>();

             todoList.Add(new TodoItem("Buy food", "2022-08-11", 0));
             todoList.Add(new TodoItem("See GP", "2022-08-13", 2));
             todoList.Add(new TodoItem("Finish assessment", "2022-08-23", 1));

             foreach(TodoItem item in todoList)
             {
                 Console.WriteLine($"{item.Title} | {item.Dueday} | {item.Status}");
             }*/






            /*car Ford = new car();
             Ford.model = "Mustang";
             Ford.color = "Red";
             Ford.year = 1991;

             car Opel = new car();
             Opel.model = "Astra";
             Opel.color = "Black";
             Opel.year = 2022;

             Console.WriteLine(Opel.model);
             Console.WriteLine(Ford.color);*/
        }
    }
}
