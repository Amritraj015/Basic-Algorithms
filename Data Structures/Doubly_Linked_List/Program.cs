using System;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Employee("Employee 1");
            var e2 = new Employee("Employee 2");
            var e3 = new Employee("Employee 3");
            var e4 = new Employee("Employee 4");
            var e5 = new Employee("Employee 5");
            var e6 = new Employee("Employee 6");

            var list = new EmployeeDLL();

            list.AddToFront(e1);
            list.AddToFront(e2);
            list.AddToFront(e3);
            list.AddToFront(e4);
            list.AddToFront(e5);
            list.AddToFront(e6);

            list.AddBefore(new Employee("new Employee"), e3);
            list.PrintList();

            list.AddToEnd(new Employee("Last Employee"));
            list.RemoveFromFront();
            list.PrintList();

            list.RemoveFromEnd();
            list.PrintList();

            Console.WriteLine("{0}", list.GetSize());
            Console.ReadKey();
        }
    }
}
