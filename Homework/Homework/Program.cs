using System.Reflection.Metadata.Ecma335;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // Задание #1. Числа Фибоначчи.
            int[] fibonacci = new int[8];

            fibonacci[0] = 0;
            fibonacci[1] = 1;
            fibonacci[2] = fibonacci[0] + fibonacci[1];
            fibonacci[3] = fibonacci[1] + fibonacci[2];
            fibonacci[4] = fibonacci[2] + fibonacci[3];
            fibonacci[5] = fibonacci[3] + fibonacci[4];
            fibonacci[6] = fibonacci[4] + fibonacci[5];
            fibonacci[7] = fibonacci[5] + fibonacci[6];

            for (int i = 0; i < fibonacci.Length; i++)

                Console.WriteLine("Numbers Fibonacchi:" + fibonacci[i]);


            // Задание #2. Времена года. 
            string[] seasons = new string[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            foreach (string m in seasons)
                Console.WriteLine(m);


            // Задание #3. Степени внутри массива

            int[,] seb =
            {
            {2, 3, 4},
            {2, 3, 4}, //степень 2
            {2, 3, 4}  // степень 3
            };

            for (int x = 0; x < seb.GetLength(0); x++)
            {
                int A = 2;
                int B = 3;
                int C = 4;

                for (int y = 0; y < x; y++)
                {
                    A *= 2;
                    B *= 3;
                    C *= 4;
                }

                seb[x, 0] = A;
                seb[x, 1] = B;
                seb[x, 2] = C;
                Console.WriteLine($"{seb[x, 0]}, {seb[x, 1]}, {seb[x, 2]}");
            }

            
             
            // Задание #4. Различные числа в массиве.
           
            double[][] jag = new double[3][];
            jag[0] = new double[5]; //1,2,3,4,5
            jag[1] = new double[2]; // е и pi
            jag[2] = new double[4]; // логарифмы: 1, 10, 100, 1000 по основанию 10
            int num = 1;

            for (int u = 0; u < jag[0].GetLength(0); u++)
            {
                jag[0][u] = num; num++;
                Console.WriteLine(jag[0][u]);
            }
            
            jag[1][0] = Math.PI;
            jag[1][1] = Math.E;
            Console.WriteLine($"Число E = {jag[1][1]} Число PI = {jag [1][0]}");

            jag[2][0] = Math.Log10(1);
            jag[2][1] = Math.Log10(10);
            jag[2][2] = Math.Log10(100);
            jag[2][3] = Math.Log10(1000);

            for (int u = 0; u < jag[2].GetLength(0); u++)
            {
                Console.WriteLine(jag[2][u]);
            }
            

            // Задание #5. Копировать элементы в другой массив.

            int[] array = {1, 2, 3, 4, 5};
            int[] array2 = {7, 8, 9, 10, 11, 12, 13};

            Array.Copy(array, array2, 3);

            for (int i = 0; i < array2.Length; i++)
            {
                Console.WriteLine(array2[i]);
            }

            // Задание #6. Увеличить размер массива. 

            Array.Resize(ref array, 10);
            for (int i = 0;i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
    }
} 