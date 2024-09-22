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

            //Задание #1.

            Console.WriteLine("Задание #1");
            int a = 0;
            int b = 1;
            int c;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a + ", ");
                c = a + b;
                a = b;
                b = c;
            }

            //Задание #2.

            Console.WriteLine("Задание #2");

            for (int i = 2; i <= 20; i += 2)
            {
                Console.WriteLine(i + ",");

            }

            // Задание #3.
            Console.WriteLine("Задание #3");


            for (int i = 1; i <= 5; i++) {
                for (int s = 1; s <= 10; s++)
                {
                    Console.WriteLine($"{i} * {s} = {i * s}");
                }
                Console.WriteLine();
            }

            // Задание #4. 
            Console.WriteLine("Задание #4");

            string password = "qwerty";
            string userparce;

            do
            {
                userparce = Console.ReadLine();
                if (userparce != password)
                {
                    Console.WriteLine("Incorrent \n");
                }
            }
            while (password != userparce);
            {
                Console.WriteLine("Correct");
            }

        }   
    }
}