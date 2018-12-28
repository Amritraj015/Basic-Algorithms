using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var empl = new EmployeeStack(10);
            var e1 = new Employee("Employee 1");
            var e2 = new Employee("Employee 2");
            var e3 = new Employee("Employee 3");
            var e4 = new Employee("Employee 4");
            var e5 = new Employee("Employee 5");
            var e6 = new Employee("Employee 6");

            empl.Push(e1);
            empl.Push(e2);
            empl.Push(e3);
            empl.Push(e4);
            empl.Push(e5);
            empl.Push(e6);
            empl.PrintStack();
            Console.WriteLine("The Size of the Stack is: {0}", empl.Size());

            empl.Pop();
            empl.Pop();
            empl.PrintStack();
            Console.WriteLine("The Element at the Top of the Stack is: {0}",empl.Peek());

            Console.ReadKey();
        }
    }
}
