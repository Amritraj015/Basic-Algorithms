using System;
using System.Collections.Generic;

namespace HashTable_LL
{
    class ChainedHashTable
    {
        private readonly LinkedList<StoreEmployee>[] hashTable;

        public ChainedHashTable()
        {
            hashTable = new LinkedList<StoreEmployee>[10];
            for(var i = 0; i < hashTable.Length; i++)
                hashTable[i] = new LinkedList<StoreEmployee>();
        }

        public void AddToHashTable(int key, Employee emp)
        {
            var hashedKey = HashedKey(key);
            hashTable[hashedKey].AddFirst(new StoreEmployee(key, emp));
        }

        public Employee GetEmployee(int key)
        {
            var hashedKey = HashedKey(key);

            var emp = hashTable[hashedKey].First;
            while(emp != null)
            {
                if (emp.Value.Key.Equals(key))
                    return emp.Value.Employee;
                emp = emp.Next;
            }

            return null;
        }

        public Employee Remove(int key)
        {
            var hashedKey = HashedKey((key));

            var emp = hashTable[hashedKey].First;
            while (emp != null)
            {
                if (emp.Value.Key.Equals(key))
                    break;
                emp = emp.Next;
            }

            if (emp == null)
                return null;
            hashTable[hashedKey].Remove(emp);
            return emp.Value.Employee;
        }

        private static int HashedKey(int key)
        {
            return key.GetHashCode();
        }

        public void PrintHashTable()
        {
            foreach (var t in hashTable)
            {
                if (t == null)
                {
                    Console.WriteLine("Empty");
                }
                else
                {
                    var emp = t.First;
                    while (emp != null)
                    {
                        Console.Write(emp.Value.Employee.ToString());
                        Console.Write(" => ");
                        emp = emp.Next;
                    }
                    Console.WriteLine("null");
                }
            }
        }
    }
}
