using System;

namespace Heap
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var heap = new Heap<string>();

//            heap.Insert(978);
//            heap.Insert(12);
//            heap.Insert(154);
//            heap.Insert(-1000);
//            heap.Insert(-457);
//            heap.Insert(0);
//            heap.Insert(15);
//            heap.Insert(-1);

            heap.Insert("Lion");
            heap.Insert("Ape");
            heap.Insert("Zebra");
            heap.Insert("Bear");
            heap.Insert("Cat");
            heap.Insert("Puppy");
            heap.Insert("Human");
            heap.Insert("Zebra");

            heap.PrintHeap();
            Console.WriteLine();

            Console.WriteLine(heap.Pop());
            heap.PrintHeap();
            Console.WriteLine();

            Console.WriteLine(heap.Pop());
            heap.PrintHeap();
            Console.WriteLine();

            Console.WriteLine(heap.Pop());
            heap.PrintHeap();
            Console.WriteLine();

            Console.WriteLine(heap.IsEmpty());
            Console.WriteLine(heap.Peek());
            Console.WriteLine(heap.Size());


            Console.WriteLine(heap.Pop());
            heap.PrintHeap();
            Console.WriteLine();

            Console.WriteLine(heap.Pop());
            heap.PrintHeap();
            Console.WriteLine();

            Console.WriteLine(heap.Pop());
            heap.PrintHeap();
            Console.WriteLine();

            Console.WriteLine(heap.Pop());
            heap.PrintHeap();
            Console.WriteLine();

            Console.WriteLine(heap.Pop());
            heap.PrintHeap();
            Console.WriteLine();

            Console.Read();
        }
    }
}
