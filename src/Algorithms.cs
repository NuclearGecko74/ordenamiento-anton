using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ordenamiento_anton.src
{
    public static class Algorithms
    {
        // Public Methods
        // -----------------------------------------
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
        public static void Shaker(List<int> A)
        {
            int N = A.Count;
            int IZQ = 1;
            int DER = N - 1;
            int K = N - 1;
            int AUX;

            while (DER >= IZQ)
            {
                for (int I = DER; I >= IZQ; I--)
                {
                    if (A[I - 1] > A[I])
                    {
                        AUX = A[I - 1];
                        A[I - 1] = A[I];
                        A[I] = AUX;
                        K = I;
                    }
                }
                IZQ = K + 1;

                for (int I = IZQ; I <= DER; I++)
                {
                    if (A[I - 1] > A[I])
                    {
                        AUX = A[I - 1];
                        A[I - 1] = A[I];
                        A[I] = AUX;
                        K = I;
                    }
                }
                DER = K - 1;
            }
        }

        // Insertion
        public static void InsertionSort(List<int> arr)
        {
            int size = arr.Count();
            for (int i = 1; i < size; i++)
            {
                int temp = arr[i];
                int j = i - 1;
                while(j > -1 && temp < arr[j])
                {
                    arr[j + 1] = arr[j];
                    arr[j] = temp;
                    j--;
                }
            }
        }

        // Selection
        public static void SelectionSort(List<int> arr)
        {
            int size = arr.Count();
            for (int i = 0; i < size; i++)
            {
                int minIndex = i;
                for(int j = i + 1; j < size; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if(i != minIndex)
                {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                }
            }
        }

        // Shell
        public static void ShellSort(List<int> A)
        {
            int N = A.Count;
            int INT = N;
            int AUX;
            bool BAND;
            int I;

            while (INT > 1)
            {
                INT = INT / 2;
                BAND = true;

                while (BAND)
                {
                    BAND = false;
                    I = 0;

                    while ((I + INT) < N)
                    {
                        if (A[I] > A[I + INT])
                        {
                            AUX = A[I];
                            A[I] = A[I + INT];
                            A[I + INT] = AUX;
                            BAND = true;
                        }
                        I++;
                    }
                }
            }
        }

        // Quick Sort
        public static void QuickSort(List<int> arr)
        {
            QuickSort(arr, 0, arr.Count - 1);
        }

        // Heap Sort
        public static void HeapSort(List<int> arr)
        {
            int n = arr.Count;

            for (int i = n / 2 - 1; i >= 0; i--)
                SiftDown(arr, n, i);

            // extraer elementos
            for (int i = n - 1; i > 0; i--)
            {
                Swap(arr, 0, i);
                SiftDown(arr, i, 0);
            }
        }

        // Private Methods
        // -----------------------------------------
        private static void QuickSort(List<int> arr, int leftIndex, int rightIndex)
        {
            if (leftIndex >= rightIndex) return;

            int pivotIndex = Pivot(arr, leftIndex, rightIndex);
            QuickSort(arr, leftIndex, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, rightIndex);
        }

        private static int Pivot(List<int> arr, int pivotIndex, int endIndex)
        {
            int swapIndex = pivotIndex;
            for (int i = pivotIndex + 1; i <= endIndex; i++)
            {
                if (arr[i] > arr[pivotIndex])
                {
                    swapIndex++;
                    Swap(arr, swapIndex, i);
                }
            }
            Swap(arr, pivotIndex, swapIndex);
            return swapIndex;
        }

        private static void Swap(List<int> arr, int firstIndex, int SecondIndex)
        {
            int temp = arr[firstIndex];
            arr[firstIndex] = arr[SecondIndex];
            arr[SecondIndex] = temp;
        }

        private static void SiftDown(List<int> arr, int heapSize, int root)
        {
            int largest = root;
            int left = 2 * root + 1;
            int right = 2 * root + 2;

            if (left < heapSize && arr[left] > arr[largest]) largest = left;
            if (right < heapSize && arr[right] > arr[largest]) largest = right;

            if (largest != root)
            {
                Swap(arr, root, largest);
                SiftDown(arr, heapSize, largest);
            }
        }
    }
}
