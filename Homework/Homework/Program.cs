using System.Collections;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace Homework
{
    internal class Program
    {
        static void ConcatenateStrings(string g, string j)                                                    // #1 задание
        {
            string? text1 = Console.ReadLine();
            string? text2 = Console.ReadLine();

            var builder = new StringBuilder();
            builder.Append(text1 + text2);

           Console.WriteLine(builder.ToString());
        }

        static void GreetUser(string c, int q)                                                             // #2 задание
        {
            string? name = Console.ReadLine();
            byte.TryParse(Console.ReadLine(), out byte age);

            Console.WriteLine($"Hello, {name}!\nYou are {age} years old.");
        }

        static void GetString(string a)                                                             //#3 задание
        {
            var text = Console.ReadLine();

            Console.WriteLine($"\nКоличество символов в строке: {text.Length}.");
            
            Console.WriteLine($"В верхнем регистре: {text.ToUpper()}");
            Console.WriteLine($"В нижнем регистре: {text.ToLower()}");
        }


        static void Substr(string b)                                                                //#4 задание
        {
            string? texts = Console.ReadLine();

            string text = texts.Substring(0, 5);

            Console.WriteLine(text);
        }



        static string ReturnString(string[] str)                                                          //#5 задание
        {

            var builder = new StringBuilder();


            for ( int i = 0; i < str.Length; i++ )
            {
                builder.Append($"{str[i]} ");
            }

            return builder.ToString();
        }

        static string ReplaceWords(string inputString, string wordToReplace, string replacementWord)                    //#6 задание
        {
            if (inputString.Contains(wordToReplace))
            {
                inputString.Replace(wordToReplace, replacementWord);
            }
            return inputString;
        }

        static void Main(string[] args)
        {


        }


    }
}