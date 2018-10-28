using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Utils
    {
 
        static public int[] generateArray(int size, int range)
        {
            Random rnd = new Random();
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(range);
            }

            return arr;
        }
   
    }
}
