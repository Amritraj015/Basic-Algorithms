using System;

namespace HashTable
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var hashTable = new EmployeeHashTable();
            var e1 = new Employee("Employee 1");
            var e2 = new Employee("Employee 2");
            var e5 = new Employee("Employee 5");
            var e6 = new Employee("Employee 6");
            var e7 = new Employee("Employee 7");
            var e8 = new Employee("Employee 8");
            var e9 = new Employee("Employee 9");
            var e10 = new Employee("Employee 10");

            hashTable.AddToHashTable(0,e1);
            hashTable.AddToHashTable(1, e2);
            hashTable.AddToHashTable(0, e5);
            hashTable.AddToHashTable(5, e6);
            hashTable.AddToHashTable(6, e7);
            hashTable.AddToHashTable(7, e8);
            hashTable.AddToHashTable(8, e9);
            hashTable.AddToHashTable(9, e10);
            hashTable.PrintHashTable();
            Console.WriteLine("Employee at key {0} is: " + hashTable.GetEmployee(0), 0);

            Console.WriteLine();

            hashTable.RemoveEmployee(0);
            hashTable.RemoveEmployee(9);
            hashTable.PrintHashTable();
            Console.WriteLine("Employee at key {0} is: " + hashTable.GetEmployee(0), 0);

            Console.ReadKey();
        }
    }
}
