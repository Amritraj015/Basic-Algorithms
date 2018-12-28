using System;

namespace Stack
{
    internal class EmployeeStack
    {
        private Employee[] _stackEmployees;
        private int _top;

        public EmployeeStack(int capacity)
        {
            _stackEmployees = new Employee[capacity];
        }

        public void Push(Employee emp)
        {
            if (_top == _stackEmployees.Length)
            {
                Employee[] newArray = new Employee[2 * _stackEmployees.Length];
                Array.Copy(_stackEmployees,newArray,_stackEmployees.Length);
                _stackEmployees = newArray;
            }

            _stackEmployees[_top++] = emp;
        }

        public Employee Pop()
        {
            if(IsEmpty())
                throw new Exception("Stack is Empty. Please Push in Employees First.");

            var emp = _stackEmployees[--_top];
            _stackEmployees[_top] = null;
            return emp;
        }

        public bool IsEmpty()
        {
            return _top == 0;
        }

        public Employee Peek()
        {
            if (IsEmpty())
                throw new Exception("Stack is Empty. Please Push in Employees First.");
            return _stackEmployees[_top - 1];
        }

        public int Size()
        {
            return _top;
        }

        public void PrintStack()
        {
            for (var i = _top - 1; i >= 0; i--)
            {
                Console.WriteLine("{0}", _stackEmployees[i]);
            }
        }
    }
}
