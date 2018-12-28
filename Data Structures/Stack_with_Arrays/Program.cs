using System;

namespace Stack
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var stack = new EmployeeStack(10);
            var e1 = new Employee("Employee 1");
            var e2 = new Employee("Employee 2");
            var e3 = new Employee("Employee 3");
            var e4 = new Employee("Employee 4");
            var e5 = new Employee("Employee 5");
            var e6 = new Employee("Employee 6");

            stack.Push(e1);
            stack.Push(e2);
            stack.Push(e3);
            stack.Push(e4);
            stack.Push(e5);
            stack.Push(e6);
            stack.PrintStack();
            Console.WriteLine("The Size of the Stack is: {0}", stack.Size());

            stack.Pop();
            stack.Pop();
            stack.PrintStack();
            Console.WriteLine("The Element at the Top of the Stack is: {0}",stack.Peek());

            Console.ReadKey();
        }
    }
}
