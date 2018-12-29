using System;

namespace HashTable
{
    internal class EmployeeHashTable
    {
        private StoreEmployee[] _hashTable;

        public EmployeeHashTable()
        {
            _hashTable = new StoreEmployee[10];
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
                if (hashedKey == _hashTable.Length - 1)
                    hashedKey = 0;
                else
                    hashedKey++;

                while (IsOccupied(hashedKey) && hashedKey != stopIndex)
                    hashedKey = (hashedKey + 1) % _hashTable.Length;
            }

            if (IsOccupied(hashedKey))
                Console.WriteLine("Position already Taken");
            else
                _hashTable[hashedKey] = new StoreEmployee(key, emp);
        }

        public Employee RemoveEmployee(int key)
        {
            var hashedKey = FindKey(key);
            if (hashedKey == -1)
                return null;

            var emp = _hashTable[hashedKey].Employee;
            _hashTable[hashedKey] = null;

            var oldHashTable = _hashTable;
            _hashTable = new StoreEmployee[oldHashTable.Length];

            foreach (var t in oldHashTable)
                if(t != null)
                    AddToHashTable(t.Key, t.Employee);

            return emp;
        }

        public Employee GetEmployee(int key)
        {
            var hashedKey = FindKey(key);
            return hashedKey == -1 ? null : _hashTable[hashedKey].Employee;
        }

        private int FindKey(int key)
        {
            var hashedKey = HashKey(key);
            if (_hashTable[hashedKey] != null && _hashTable[hashedKey].Key.Equals(key))
                return hashedKey;
            
            var stopIndex = hashedKey;
            if (hashedKey == _hashTable.Length - 1)
                hashedKey = 0;
            else
                hashedKey++;

            while (hashedKey != stopIndex && _hashTable[hashedKey] != null && !_hashTable[hashedKey].Key.Equals(key))
                hashedKey = (hashedKey + 1) % _hashTable.Length;

            if (_hashTable[hashedKey] != null && _hashTable[hashedKey].Key.Equals(key))
                return hashedKey;
            return -1;
        }

        public bool IsOccupied(int index)
        {
            return _hashTable[index] != null;
        }

        public void PrintHashTable()
        {
            for (var i =0; i < _hashTable.Length; i++)
            {
                if (_hashTable[i] == null)
                    Console.WriteLine("Empty");
                else
                    Console.WriteLine("Position " + i + ": " + "{0}", _hashTable[i].Employee);
            }
        }
    }
}
