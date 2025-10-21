using System;
using System.Collections.Generic;

namespace MinHeap
{
class MinHeap
{
    private List<int> heap = new List<int>();

    public void Insert(int val)
    {
        heap.Add(val);
        int i = heap.Count - 1;
        while (i > 0)
        {
            int parent = (i - 1) / 2;
            if (heap[parent] <= heap[i]) break;
            Swap(i, parent);
            i = parent;
        }
    }

    public int ExtractMin()
    {
        if (heap.Count == 0) throw new InvalidOperationException("Heap is empty");
        int min = heap[0];
        heap[0] = heap[heap.Count - 1];
        heap.RemoveAt(heap.Count - 1);
        Heapify(0);
        return min;
    }

    private void Heapify(int i)
    {
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        int smallest = i;

        if (left < heap.Count && heap[left] < heap[smallest]) smallest = left;
        if (right < heap.Count && heap[right] < heap[smallest]) smallest = right;

        if (smallest != i)
        {
            Swap(i, smallest);
            Heapify(smallest);
        }
    }

    private void Swap(int i, int j)
    {
        int temp = heap[i];
        heap[i] = heap[j];
        heap[j] = temp;
    }

    public void PrintHeap() => Console.WriteLine(string.Join(", ", heap));
}
}