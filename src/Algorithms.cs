using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenamiento_anton.src
{
    public static class Algorithms
    {
        public static void BubbleSort(List<int> arr)
        {
            int size = arr.Count(); 
            for(int i = size - 1; i > 0; i--)
            {
                for(int j = 0; j < i; j++)
                {
                    if (arr[j] > arr[j+1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        //Shaker

        // Insertion

        // Selection

        // Shell

        // Quick Sort

        // Heap Sort
    }
}
