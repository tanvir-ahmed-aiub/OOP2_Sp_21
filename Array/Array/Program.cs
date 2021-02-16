using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Single Dimensional Array
            int[] arr = new int[5];
            arr[0] = 10;
            arr[1] = 12;
            for(int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 100;
            }
            int[] arr2 = new int[] {1,2,100,105,106 };
            int[] arr3 = { 10, 12, 14 };
            //2D Array (Multidimensional Array)
            int[,] arr4 = new int[4, 2];
            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 2; j++) {
                    arr4[i, j] = i + 101;
                }
            }
            int[,] arr5 = { { 1, 2 }, { 23, 3 }, { 4, 5 }, { 6, 7 } };
            Console.WriteLine(arr5[1, 0]);
            for (int i = 0; i < 4; i++) {
                for (int j = 0; j < 2; j++) {
                    Console.Write(arr5[i,j]+" ");
                }
                Console.WriteLine();
            }
            //Jagged Array
            int[][] jagged = new int[3][];
            jagged[0] = new int[5];
            jagged[1] = new int[3];
            jagged[2] = new int[2];
            int[][] jagged2 = new int[][] {
                new int[5],
                new int[3],
                new int[2]
            };
            int[][] jagged3 = new int[][] {
                new int[] { 1,3,5,7,9},
                new int[] { 0,2,4},
                new int[] { 11,22}
            };
            //accessing 22
            Console.WriteLine(jagged3[2][1]);
            Console.WriteLine(jagged3[0][3]);

            Console.WriteLine(jagged3[2].Length);

            for (int i = 0; i < jagged3.Length; i++) {
                for (int j = 0; j < jagged3[i].Length; j++) {
                    Console.Write(jagged3[i][j] + " ");
                }
                Console.WriteLine();
            }

            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine(arr[i]);
            }
            
            var ij=89;
            ij = 13;

            foreach (int i in arr) {
                Console.WriteLine(i);
            }

        }
        
    }   
        
}
