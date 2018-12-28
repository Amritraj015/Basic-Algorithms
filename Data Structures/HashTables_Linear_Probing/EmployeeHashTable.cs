using System;

namespace HashTable
{
    internal class EmployeeHashTable
    {
        private StoreEmployee[] hashTable;

        public EmployeeHashTable()
        {
            hashTable = new StoreEmployee[10];
        }

        private static int HashKey(int key)
        {
            return key.GetHashCode();
        }

        public void AddToHashTable(int key, Employee emp)
        {
            var hashedKey = HashKey(key);
            if (IsOccupied(hashedKey))
            {
                var stopIndex = hashedKey;
                if (hashedKey == hashTable.Length - 1)
                    hashedKey = 0;
                else
                    hashedKey++;

                while (IsOccupied(hashedKey) && hashedKey != stopIndex)
                    hashedKey = (hashedKey + 1) % hashTable.Length;
            }

            if (IsOccupied(hashedKey))
                Console.WriteLine("Position already Taken");
            else
                hashTable[hashedKey] = new StoreEmployee(key, emp);
        }

        public Employee RemoveEmployee(int key)
        {
            var hashedKey = FindKey(key);
            if (hashedKey == -1)
                return null;

            var emp = hashTable[hashedKey].employee;
            hashTable[hashedKey] = null;

            var oldHashTable = hashTable;
            hashTable = new StoreEmployee[oldHashTable.Length];

            foreach (var t in oldHashTable)
                if(t != null)
                    AddToHashTable(t.key, t.employee);


            return emp;
        }

        public Employee GetEmployee(int key)
        {
            var hashedKey = FindKey(key);
            return hashedKey == -1 ? null : hashTable[hashedKey].employee;
        }

        private int FindKey(int key)
        {
            var hashedKey = HashKey(key);
            if (hashTable[hashedKey] != null && hashTable[hashedKey].key.Equals(key))
                return hashedKey;
            
            var stopIndex = hashedKey;
            if (hashedKey == hashTable.Length - 1)
                hashedKey = 0;
            else
                hashedKey++;

            while (hashedKey != stopIndex && hashTable[hashedKey] != null && !hashTable[hashedKey].key.Equals(key))
                hashedKey = (hashedKey + 1) % hashTable.Length;

            if (hashTable[hashedKey] != null && hashTable[hashedKey].key.Equals(key))
                return hashedKey;
            return -1;
        }

        public bool IsOccupied(int index)
        {
            return hashTable[index] != null;
        }

        public void PrintHashTable()
        {
            for (var i =0; i < hashTable.Length; i++)
            {
                if (hashTable[i] == null)
                    Console.WriteLine("Empty");
                else
                    Console.WriteLine("Position " + i + ": " + "{0}", hashTable[i].employee);

            }
        }
    }
}
