using System;

namespace Heaps
{
    internal class Heap
    {
        private int[] heap;
        private int size;

        public Heap(int capacity)
        {
            heap = new int[capacity];
        }

        public bool IsFull()
        {
            return size == heap.Length;
        }

        public int GetParent(int index)
        {
            return (index - 1) / 2;
        }

        public void Insert(int value)
        {
            if(IsFull()) throw new IndexOutOfRangeException("Heap is full");

            heap[size] = value;

            FixHeapAbove(size);
            size++;
        }

        public int Delete(int index)
        {
            if(IsEmpty())
                throw new IndexOutOfRangeException("Heap is Empty");

            var parent = GetParent(index);
            var deletedValue = heap[index];
            heap[index] = heap[size - 1];

            if (index == 0 || heap[index] < heap[parent])
            {
                FixHeapBelow(index, size - 1);
            }
            else
            {
                FixHeapAbove(index);
            }

            size--;
            return deletedValue;
        }

        public int Peek()
        {
            if (IsEmpty()) throw new IndexOutOfRangeException("Heap is Empty");

            return heap[0];
        }

        private void FixHeapBelow(int index, int lastHeapIndex)
        {
            while (index <= lastHeapIndex)
            {
                var leftChild = GetChild(index, true);
                var rightChild = GetChild(index, false);

                if (leftChild <= lastHeapIndex)
                {
                    int childSwap;
                    if (rightChild >= lastHeapIndex)
                    {
                        childSwap = leftChild;
                    }
                    else
                    {
                        childSwap = heap[leftChild] > heap[rightChild] ? leftChild : rightChild;
                    }

                    if (heap[index] < heap[childSwap])
                    {
                        var temp = heap[index];
                        heap[index] = heap[childSwap];
                        heap[childSwap] = temp;
                    }
                    else
                    {
                        break;
                    }

                    index = childSwap;
                }
                else
                {
                    break;
                }
            }
        }

        private void FixHeapAbove(int index)
        {
            var newValue = heap[index];
            while (index > 0 && newValue > heap[GetParent(index)])
            {
                heap[index] = heap[GetParent(index)];
                index = GetParent(index);
            }

            heap[index] = newValue;
        }

        public bool IsEmpty()
        {
            return size == 0;
        }

        public int GetChild(int index, bool left)
        {
            return 2 * index + (left ? 1 : 2);
        }

        public void PrintHeap()
        {
            for (var i = 0; i < size; i++)
            {
                Console.Write(heap[i]);
                Console.Write(", ");
            }
            Console.WriteLine();
        }

        public void HeapSort()
        {
            var lastHeapIndex = size - 1;
            for (var i = 0; i < lastHeapIndex; i++)
            {
                var temp = heap[0];
                heap[0] = heap[lastHeapIndex - i];
                heap[lastHeapIndex - i] = temp;

                FixHeapBelow(0, lastHeapIndex - i - 1);
            }
        }
    }
}
