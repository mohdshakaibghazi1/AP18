using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConAppInsertionSort
{
    internal class Program
    {
        public static void insertionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        public static void Print(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "  "); // Changed WriteLine to Write to print on the same line.
            }
            Console.WriteLine("\n");
        }
        static void Main(string[] args)
        {
            int[] arr = { 8, 9, 2, 5, 4, 7, 6 };
            Console.WriteLine("array without  sort");
            Print(arr);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            insertionSort(arr);
            stopwatch.Stop();

            Console.WriteLine("array with insertion sort");
            Print(arr);
            Console.WriteLine($"ArraySize {arr.Length} Time TAken {stopwatch.Elapsed.TotalMilliseconds} milliseconds");

            Console.ReadLine();
        }
    }
}