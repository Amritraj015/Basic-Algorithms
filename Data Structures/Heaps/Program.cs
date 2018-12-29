using System;

namespace Heaps
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Heap heap = new Heap(10);
            heap.Insert(80);
            heap.Insert(75);
            heap.Insert(60);
            heap.Insert(68);
            heap.Insert(55);
            heap.Insert(40);
            heap.Insert(52);
            heap.Insert(67);

            heap.PrintHeap();

            Console.WriteLine(heap.Peek());

            heap.Delete(0);
            Console.WriteLine(heap.Peek());
            heap.PrintHeap();

            heap.HeapSort();
            heap.PrintHeap();

            Console.ReadKey();

        }
    }
}
