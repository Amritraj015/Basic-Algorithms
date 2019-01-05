using System;
using System.Collections.Generic;

//  This is an implementation of a generic Min-Heap.
namespace Dijkstra_Shortest_Path_Algorithm
{
    public class Heap<T> where T : IComparable<T>
    {
        private readonly IComparer<T> _cmp;
        private List<T> _heap = new List<T>();

        //=================================================================================================
        //  Default Constructor
        public Heap()
        {
            _cmp = Comparer<T>.Default;
        }

        public Heap(IComparer<T> cmp)
        {
            _cmp = cmp;
        }
        //=================================================================================================

        //=================================================================================================
        //  Method to check if the Heap is Empty
        //  returns True if the Heap is Empty
        //  returns False if the Heap is not Empty
        public bool IsEmpty()
        {
            return _heap.Count == 0;
        }
        //=================================================================================================

        //=================================================================================================
        //  Returns the Size of the Heap.
        public int Size()
        {
            return _heap.Count;
        }
        //=================================================================================================

        //=================================================================================================
        //  Returns the first element of the Heap WITHOUT popping (removing) it from the Heap.
        public T Peek()
        {
            if (_heap.Count == 0) throw new InvalidOperationException("Heap is Empty!");

            return _heap[0];
        }
        //=================================================================================================

        //=================================================================================================
        //  Function to return the First index of an element.
        //  Returns -1 if the element does not exits in the Heap.
        public int IndexOf(T findIndex)
        {
            for (var i = 0; i < _heap.Count; i++)
            {
                if (_cmp.Compare(_heap[i], findIndex) == 0)
                {
                    return i;
                }
            }

            return -1;
        }
        //=================================================================================================

        //=================================================================================================
        //  Returns parent index of a given child index
        public int GetParent(int index)
        {
            return (index - 1) / 2;
        }
        //=================================================================================================

        //=================================================================================================
        //  Get left or right child index for a given Parent index
        //  left = true => return left child
        //  left = false => returns right child
        public int GetChild(int index, bool left)
        {
            return 2 * index + (left ? 1 : 2);
        }
        //=================================================================================================

        //=================================================================================================
        //  Inserts new element into the Heap with the help of the HeapUp helper method
        public void Insert(T value)
        {
            _heap.Add(value);
            HeapUp(_heap.Count - 1);
        }

        //  Helper method to Re=Heapify the Heap after insertion of new element. 
        private void HeapUp(int index)
        {
            var newValue = _heap[index];
            while (index > 0 && _cmp.Compare(newValue, _heap[GetParent(index)]) < 0)
            {
                _heap[index] = _heap[GetParent(index)];
                index = GetParent(index);
            }

            _heap[index] = newValue;
        }
        //=================================================================================================

        //=================================================================================================
        //  Removes a first specific element from the heap and returns true if the element is present in the Heap.
        //  Returns false if the Heap is either empty or the element does not exist in the Heap.
        public bool RemoveElement(T removeElement)
        {
            var index = IndexOf(removeElement);

            if (IsEmpty() || index == -1) return false;

            Pop(index);
            return true;
        }

        //  Removes an element from the Heap with the help of HeapDown helper method
        public T Pop(int index = 0)
        {
            if (IsEmpty()) throw new InvalidOperationException("Heap is Empty. There is nothing to Pop!");

            var parent = GetParent(index);
            var deletedValue = _heap[index];

            if (index == 0 || _cmp.Compare(_heap[index], _heap[parent]) > 0)
            {
                HeapDown(index);
            }
            else
            {
                HeapUp(index);
            }

            _heap.RemoveAt(index);
            return deletedValue;
        }

        //  Helper method to Re=Heapify the Heap after a deletion (popping) of element.
        private void HeapDown(int index)
        {
            while (index < _heap.Count)
            {
                var leftChild = GetChild(index, true);
                var rightChild = GetChild(index, false);

                if (leftChild < _heap.Count)
                {
                    int swapIndex;
                    if (rightChild >= _heap.Count)
                    {
                        swapIndex = leftChild;
                    }
                    else
                    {
                        swapIndex = _cmp.Compare(_heap[leftChild], _heap[rightChild]) < 0 ? leftChild : rightChild;
                    }

                    if (_cmp.Compare(_heap[index], _heap[swapIndex]) > 0)
                    {
                        _heap = Swap(_heap, index, swapIndex);
                    }
                    else
                    {
                        break;
                    }

                    index = swapIndex;
                }
                else
                {
                    break;
                }
            }
        }
        //=================================================================================================

        //=================================================================================================
        //  Helper method to swap the contents of the Heap.
        private static List<T> Swap(List<T> heap, int index, int parent)
        {
            var temp = heap[index];
            heap[index] = heap[parent];
            heap[parent] = temp;

            return heap;
        }
        //=================================================================================================

        //=================================================================================================
        //  Prints the contents of the Heap on console.
        public void PrintHeap()
        {
            foreach (var t in _heap)
            {
                Console.Write(t);
                Console.Write(", ");
            }
        }
    }
}
