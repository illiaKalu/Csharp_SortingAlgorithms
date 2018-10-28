using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class CountSort
    {
        public int[] countSort(int[] arr)
        {
            int[] numsArray = new int[10000];

            for (int write = 0; write < arr.Length; write++)
            {
                numsArray[arr[write]] += 1; 
            }

            int k = 0;

            for (int write = 0; write < numsArray.Length; write++)
            {
                if (numsArray[write] != 0)
                {
                    for (int i = 0; i < numsArray[write]; i++)
                    {
                        arr[k] = write;
                        k++;
                    }
                }
            }

            return arr;
        }


   
    }
}
