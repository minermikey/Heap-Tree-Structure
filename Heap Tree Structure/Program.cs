/*

    A heap is a special tree-based data structure in which the tree is a complete binary tree.
    in memory a heap is an array, with a first in last out (FIFO) order.

*/


namespace MinHeap
{
    class Program
    {
        static void Main()
        {
            MinHeap heap = new MinHeap();
            heap.Insert(10);
            heap.Insert(5);
            heap.Insert(20);
            heap.Insert(3);

            heap.PrintHeap(); // Heap structure in array form
            Console.WriteLine("Min value: " + heap.ExtractMin());
            heap.PrintHeap();
        }
    }
}

