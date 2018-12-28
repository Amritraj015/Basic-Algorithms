using System;
using System.Collections.Generic;
using Stack;

namespace Stack_Linked_List
{
    class StackLL
    {
        private readonly LinkedList<Employee> _stack;

        public StackLL()
        {
            _stack = new LinkedList<Employee>();
        }

        public void Push(Employee emp)
        {
            _stack.AddFirst(emp);
        }

        public void Pop()
        {
            _stack.RemoveFirst();
        }

        public Employee Peek()
        {
            return _stack.First.Value;
        }

        public bool IsEmpty()
        {
            return _stack.Count == 0;
        }

        public void PrintStack()
        {
            foreach(var v in _stack)
            {
                Console.WriteLine(v.ToString());
            }
        }
    }
}
