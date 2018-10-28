using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class QuickSort
    {
 
        public int[] quickSort(int[] arr)
        {

            QuickSort_Recursive(arr, 0, arr.Length - 1);
           
            return arr;
        }

        static public void QuickSort_Recursive(int[] arr, int left, int right)

        {

            // For Recusrion
            if (left < right)
            {
                int pivot = Partition(arr, left, right);

                QuickSort_Recursive(arr, left, pivot - 1);
                QuickSort_Recursive(arr, pivot + 1, right);
            }
        }


        static public int Partition(int[] arr, int low, int high)
        {

            int pivot = arr[high];

            // index of smaller element 
            int i = (low - 1);
            for (int j = low; j < high; j++)
            {
                // If current element is smaller  
                // than or equal to pivot 
                if (arr[j] <= pivot)
                {
                    i++;

                    // swap arr[i] and arr[j] 
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                }
            }

            // swap arr[i+1] and arr[high] (or pivot) 
            int temp1 = arr[i + 1];
            arr[i + 1] = arr[high];
            arr[high] = temp1;

            return i + 1;

        }

    }


}
