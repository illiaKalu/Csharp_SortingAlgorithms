using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {

        static void printArray(int[] arr)
        {
            int n = arr.Length;

            for (int i = 0; i < n; ++i)
                Console.Write(arr[i] + " ");

            Console.Write("\n");
        }

        static void Main(string[] args)
        {
            int size = 20000;
            int range = 10000;

            BubbleSort bubbleSort = new BubbleSort();
            int[] unsortedArray1 = Utils.generateArray(size, range);

            var watch = System.Diagnostics.Stopwatch.StartNew();
            bubbleSort.bubbleSort(unsortedArray1);
            watch.Stop();
            var elapsedMs = watch.Elapsed.TotalMilliseconds;

            Console.WriteLine("bubble took time: " + elapsedMs);
  
            CountSort countSort = new CountSort();
            int[] unsortedArray2 = Utils.generateArray(size, range);

            watch = System.Diagnostics.Stopwatch.StartNew();
            countSort.countSort(unsortedArray2);
            watch.Stop();
            elapsedMs = watch.Elapsed.TotalMilliseconds;

            Console.WriteLine("count took time: " + elapsedMs);

            MergeSort mergeSort = new MergeSort();
            int[] unsortedArray3 = Utils.generateArray(size, range);

            watch = System.Diagnostics.Stopwatch.StartNew();
            MergeSort.sort(unsortedArray3, 0, unsortedArray3.Length - 1);
            watch.Stop();
            elapsedMs = watch.Elapsed.TotalMilliseconds;

            Console.WriteLine("merge took time: " + elapsedMs);

            InsertionSort insertionSort = new InsertionSort();
            int[] unsortedArray4 = Utils.generateArray(size, range);

            watch = System.Diagnostics.Stopwatch.StartNew();
            insertionSort.insertionSort(unsortedArray4);
            watch.Stop();
            elapsedMs = watch.Elapsed.TotalMilliseconds;

            Console.WriteLine("insertion took time: " + elapsedMs);

            QuickSort quickSort = new QuickSort();
            int[] unsortedArray5 = Utils.generateArray(size, range);

            watch = System.Diagnostics.Stopwatch.StartNew();
            quickSort.quickSort(unsortedArray5);
            watch.Stop();
            elapsedMs = watch.Elapsed.TotalMilliseconds;

            Console.WriteLine("quick took time: " + elapsedMs);


            HeapSort heapSort = new HeapSort();
            int[] unsortedArray6 = Utils.generateArray(size, range);

            watch = System.Diagnostics.Stopwatch.StartNew();
            heapSort.heapSort(unsortedArray6);
            watch.Stop();
            elapsedMs = watch.Elapsed.TotalMilliseconds;

            Console.WriteLine("heap took time: " + elapsedMs);

            SelectionSort selectionSort = new SelectionSort();
            int[] unsortedArray7 = Utils.generateArray(size, range);

            watch = System.Diagnostics.Stopwatch.StartNew();
            selectionSort.selectionSort(unsortedArray7);
            watch.Stop();
            elapsedMs = watch.Elapsed.TotalMilliseconds;

            Console.WriteLine("selection took time: " + elapsedMs);

            Console.ReadKey();

            
        }
    }
}
