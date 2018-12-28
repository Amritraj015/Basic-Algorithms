using System;
using Stack;

namespace Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new ArrayQueue(10);
            var e1 = new Employee("Employee 1");
            var e2 = new Employee("Employee 2");
            var e3 = new Employee("Employee 3");
            var e4 = new Employee("Employee 4");
            var e5 = new Employee("Employee 5");
            var e6 = new Employee("Employee 6");
            var e7 = new Employee("Employee 7");
            var e8 = new Employee("Employee 8");
            var e9 = new Employee("Employee 9");
            var e10 = new Employee("Employee 10");
            var e11 = new Employee("Employee 11");


            queue.Add(e1);
            queue.Add(e2);
            queue.Add(e3);
            queue.Add(e4);
            queue.Add(e5);
            queue.Add(e6);
            queue.Add(e7);
            queue.Add(e8);
            queue.Add(e9);
            queue.Add(e10);
            queue.Add(e11);
            queue.Remove();
            queue.Remove();
            queue.Remove();
            queue.Remove();
            queue.Remove();
            queue.Remove();

            queue.PrintQueue();

            Console.ReadKey();


        }
    }
}
