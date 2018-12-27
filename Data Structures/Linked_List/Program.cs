using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new EmployeeLinkedList();
            var employee0 = new Employee("Employee 0",0);
            var employee1 = new Employee("Employee 1", 1);
            var employee2 = new Employee("Employee 2", 2);
            var employee3 = new Employee("Employee 3", 3);
            var employee4 = new Employee("Employee 4", 4);
            var employee5 = new Employee("Employee 5", 5);

            Console.WriteLine(employee5.Equals(new Employee("Employee 5", 5)));

            list.AddToFront(employee0);
            list.AddToFront(employee1);
            list.AddToFront(employee2);
            list.AddToFront(employee3);
            list.AddToFront(employee4);
            list.AddToFront(employee5);

            list.PrintList();

            list.RemoveFromFront();

            list.PrintList();

            Console.WriteLine();
            Console.WriteLine("size of the list = {0}",list.GetSize());

            Console.ReadKey();
        }
    }
}
