using System;

namespace HashTable_LL
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var e1 = new Employee("Employee 1");
            var e2 = new Employee("Employee 2");
            var e3 = new Employee("Employee 3");
            var e4 = new Employee("Employee 4");
            var e5 = new Employee("Employee 5");
            var e6 = new Employee("Employee 6");

            var hashTable = new ChainedHashTable();
            hashTable.AddToHashTable(0,e1);
            hashTable.AddToHashTable(0,e2);
            hashTable.AddToHashTable(0,e3);
            hashTable.AddToHashTable(4,e4);
            hashTable.AddToHashTable(4,e5);
            hashTable.AddToHashTable(5,e6);
            hashTable.PrintHashTable();

            Console.WriteLine();
            hashTable.Remove(0);
            hashTable.PrintHashTable();

            Console.WriteLine(hashTable.GetEmployee(1));

            Console.ReadKey();

        }
    }
}
