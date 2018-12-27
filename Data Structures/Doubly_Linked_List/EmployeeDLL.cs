using System;

namespace DoublyLinkedList
{
    class EmployeeDLL
    {
        private EmployeeNode _head;
        private EmployeeNode _tail;
        private int _size;

        public void AddToFront(Employee employee)
        {
            var node = new EmployeeNode(employee);

            if (IsEmpty())
            {
                _tail = node;
            }
            else
            {
                _head.SetPrevious(node);
                node.SetNext(_head);
            }

            _head = node;
            _size++;
        }

        public EmployeeNode RemoveFromFront()
        {
            if (IsEmpty()) return null;
            var removedNode = _head;

            if (_head.GetNext() == null)
            {
                _tail = null;
            }
            else
            {
                _head.GetNext().SetPrevious(null);
            }

            _head = _head.GetNext();
            removedNode.SetNext(null);
            _size--;

            return removedNode;
        }

        public void AddToEnd(Employee employee)
        {
            var node = new EmployeeNode(employee);
            if (IsEmpty())
            {
                _head = node;
            }
            else
            {
                _tail.SetNext(node);
                node.SetPrevious(_tail);
            }

            _tail = node;
            _size++;
        }

        public EmployeeNode RemoveFromEnd()
        {
            if (IsEmpty()) return null;
            var removeNode = _tail;

            if (_tail.GetPrevious() == null)
            {
                _head = null;
            }
            else
            {
                _tail.GetPrevious().SetNext(null);
            }

            _tail = _tail.GetPrevious();
            _size--;
            removeNode.SetPrevious(null);
            return removeNode;
        }

        public bool AddBefore(Employee toBeAdded, Employee before)
        {
            if (IsEmpty()) return false;

            var current = _head;
            while (current != null && !current.GetEmployee().Equals(before))
                current = current.GetNext();
            if (current == null) return false;

            var newNode = new EmployeeNode(toBeAdded);
            newNode.SetPrevious(current.GetPrevious());
            newNode.SetNext(current);
            current.SetPrevious(newNode);
            if(current == _head)
                _head = newNode;
            else
                newNode.GetPrevious().SetNext(newNode);

            _size++;
            return true;
        }

        public int GetSize()
        {
            return _size;
        }

        public bool IsEmpty()
        {
            return _head == null;
        }

        public void PrintList()
        {
            var current = _head;
            Console.Write("HEAD => ");
            while (current != null)
            {
                Console.Write(current.ToString());
                Console.Write(" <=> ");
                current = current.GetNext();
            }
            Console.WriteLine("null");
        }
    }
}
