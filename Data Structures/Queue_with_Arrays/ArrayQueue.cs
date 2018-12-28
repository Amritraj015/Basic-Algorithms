using System;
using Stack;

namespace Queue
{
    internal class ArrayQueue
    {
        private Employee[] _queue;
        private int _front;
        private int _back;

        public ArrayQueue(int capacity)
        {
            _queue = new Employee[capacity];
        }

        public void Add(Employee emp)
        {
            if (Size() == _queue.Length - 1)
            {
                var numItems = Size();
                var newArray = new Employee[2 * _queue.Length];
                Array.Copy(_queue,_front,newArray,0,_queue.Length-_front);
                Array.Copy(_queue,0, newArray,_queue.Length-_front,_back);
                _queue = newArray;

                _front = 0;
                _back = numItems;
            }

            _queue[_back] = emp;

            if (_back < _queue.Length - 1)
                _back++;
            else
                _back = 0;
        }

        public Employee Remove()
        {
            if(Size() == 0)
                throw new Exception("The Queue is Empty");

            var emp = _queue[_front];
            _queue[_front++] = null;

            if (Size() == 0)
            {
                _front = 0;
                _back = 0;
            }
            else if (_front == _queue.Length)
                _front = 0;

            return emp;
        }

        public int Size()
        {
            return _front <= _back ? _back - _front : _back - _front + _queue.Length; 
        }

        public Employee Peek()
        {
            if(Size() == 0)
                throw new Exception("The Queue is Empty");

            return _queue[_front];
        }

        public void PrintQueue()
        {
            if (_front <= _back)
            {
                for (var i = _front; i < _back; i++)
                {
                    Console.WriteLine(_queue[i].ToString());
                }
            }
            else
            {
                for (var i = _front; i < _queue.Length; i++)
                {
                    Console.WriteLine(_queue[i].ToString());
                }
                for (var i = 0; i < _back; i++)
                {
                    Console.WriteLine(_queue[i].ToString());
                }
            }
        }
    }
}
