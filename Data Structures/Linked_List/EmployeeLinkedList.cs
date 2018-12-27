using System;

namespace Linked_List
{
    class EmployeeLinkedList
    {
        private EmployeeNode _head;
        private int _size;

        public int GetSize()
        {
            return _size;
        }

        public void AddToFront(Employee employee)
        {
            EmployeeNode node = new EmployeeNode(employee);
            node.SetNext(_head);
            _head = node;
            _size++;
        }

        public EmployeeNode RemoveFromFront()
        {
            if (IsEmpty()) return null;
            EmployeeNode removedNode = _head;
            _head = _head.GetNext();
            _size--;
            
            return removedNode;
        }

        public void PrintList()
        {
            EmployeeNode current = _head;
            Console.Write("HEAD -> ");

            while (current != null)
            {
                Console.Write(current.ToString());
                Console.Write(" -> ");
                current = current.GetNext();
            }
            Console.WriteLine("null");
        }

        public bool IsEmpty()
        {
            return _head == null;
        }
    }
}
