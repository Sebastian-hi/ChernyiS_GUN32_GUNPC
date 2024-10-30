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

            Console.WriteLine(g + " " + j);

        }

        static void GreetUser(string name, int age)                                                             // #2 задание
        {
            Console.WriteLine($"Hello, {name}!\nYou are {age} years old.");
        }

        static void GetString(string a)                                                             //#3 задание
        {
            Console.WriteLine($"\nКоличество символов в строке: {a.Length}.");
            Console.WriteLine($"В верхнем регистре: {a.ToUpper()}");
            Console.WriteLine($"В нижнем регистре: {a.ToLower()}");
        }


        static void Substr(string b)                                                                //#4 задание
        {
            string text = b.Substring(0, 5);

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
                string result = inputString.Replace(wordToReplace, replacementWord);
                return result;
            }
            else return inputString;
        }

        static void Main(string[] args)                                                         
        {

            //Хотел сказать большое спасибо за такие подробные объяснения!
            // прям небо и земля с тем, что было раньше.
            // Ещё бы уроки нормально записывали и вообще обучение было бы бесценное)
            // Книги, которые вы посоветовали супер,
            // но их что-то нет в продаже...поищу электронные варианты


        }


    }
}