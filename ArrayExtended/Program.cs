using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExtended
{
    class Program
    {
        enum Day {
            Sat = 123,
            Sun = 121,
            Mon,
            Tue,
            Wed = 43,
            Thurs,
            Fri
        };
        static void Print1DArray(int[] arr) {
            foreach (int num in arr) {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
        static void Print2DArray(int[,] arr)
        {
            int r = arr.GetLength(0);
            int c = arr.GetLength(1);
            for (int i = 0; i < r; i++) {
                for (int j = 0; j < c; j++) {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static void PrintJaggedArray(int[][] arr) {
            /*for (int i = 0; i < arr.Length; i++) {
                for (int j = 0; j < arr[i].Length; j++) {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }*/
            foreach (int[] innerArr in arr) {
                foreach (int num in innerArr) {
                    Console.Write(num+" ");
                }
                Console.WriteLine();
            }
        }
        static int Add(params int[] numbers) {
            int sum = 0;
            foreach (int n in numbers) {
                sum += n;
            }
            return sum;
        }
        
        static void Main(string[] args)
        {
            //single dimensional array
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            Print1DArray(arr);
            int[,] arr2 = { { 1, 2 }, { 3, 4 } };
            Print2DArray(arr2);
            int[][] jagged = {
                new int[] {1,2,3},
                new int[] {1,2,3,4,5},
                new int[] {1,2,3,4},
            };
            PrintJaggedArray(jagged);
            Console.WriteLine("***********---------************");
            Console.WriteLine((int)Day.Mon);
            Console.WriteLine("***********---------************");
            int sum = Add(10,25,15,45,798,158,78,89);
            int sum2 = Add(arr);
            Console.WriteLine("Summation is: " + sum2);
        }
    }
}
