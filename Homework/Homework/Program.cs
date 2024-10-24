using System.ComponentModel.Design;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Net.Http.Headers;
using static System.Net.Mime.MediaTypeNames;
using Homework;
using System.Runtime.InteropServices;
using System.Linq.Expressions;
using System;
using System.Runtime.Intrinsics.Arm;
using System.Xml.Linq;
using System.Runtime.CompilerServices;
using System.Collections;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Привет! Давай выберем одну из трёх задач. ");
            Console.WriteLine("Напишите цифру от 1 до 3.");

            int task = int.Parse(Console.ReadLine());

            switch (task)                              // Выполнение задания в отдельном методе
            {
                case 1:

                    CheckTaskFirst();
                    break;

                case 2:

                    CheckTaskSecond();
                    break;

                case 3:
                    CheckTaskThird();
                    break;

            }
        }

        internal class Class1
        {
            public void TaskLoop()
            {

                Console.WriteLine();
                Console.WriteLine("И так, первая задача. У нас есть список рандомных слов, сейчас мы напишим новую строку и добавим в него. ");
                Console.WriteLine();
                Console.WriteLine("Если что, мы можем выйти из этой программы, если вы напишите '-exit'.");
                Console.WriteLine("Если продолжаем - напишите любое слово.");

                string exit = Console.ReadLine();

                if (exit != "-exit")
                {
                    Console.WriteLine("Хорошо. Продолжаем. Напишите новую строку в наш список. ");
                    List<string> assignment = new List<string>() { "Кто хозяин болота?", "Черничный пирог", "Тыковки" };

                    string text = Console.ReadLine();
                    assignment.Add(text);

                    Console.WriteLine();
                    Console.WriteLine("Супер. А вот и наш список: ");

                    foreach (string text1 in assignment)
                    {
                        Console.WriteLine(text1);
                    }

                    Console.WriteLine();
                    Console.WriteLine("А теперь давайте вставим новую строку в середину нашего списка. Напишите её. ");

                    string text2 = Console.ReadLine();
                    assignment.Insert(2, text2);

                    Console.WriteLine();
                    Console.WriteLine("Отлично, теперь наш список выглядит так: ");

                    foreach (string text1 in assignment)
                    {
                        Console.WriteLine(text1);
                    }
                }
                else
                {
                    Console.WriteLine("Всё понятно, выходим из программы \n");
                }
            }
        }
        internal class Class2
        {
            public void TaskLoop()
            {

                Console.WriteLine();
                Console.WriteLine("Окей, вторая задача. В ней мы попробуем связать имя студента с его средней оценкой.");
                Console.WriteLine();
                Console.WriteLine("Если что, мы можем выйти из этой программы, если вы напишите '-exit'.");
                Console.WriteLine("Если продолжаем - напишите любое слово.");

                string exit = Console.ReadLine();

                if (exit != "-exit")

                {
                    Console.WriteLine("Отлично. Продолжаем");
                    Console.WriteLine();
                    Console.WriteLine("Введите имя студента: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Так. И оценку от 2 до 5 баллов: ");
                    int assessment;

                    do
                    {
                        assessment = int.Parse(Console.ReadLine());

                    }
                    while (assessment < 1 || assessment > 6);


                    Console.WriteLine("Отлично. Теперь введите имя студента и мы посмотрим его оценку");

                    var students = new Dictionary<string, int>()
                    {

                        [name] = assessment

                    };

                    string name1 = Console.ReadLine();

                    Console.WriteLine();

                    if (name1 == name)
                    {
                        Console.WriteLine($"Студент: {name} и оценка {assessment}! ");
                    }

                    else
                    {
                        Console.WriteLine("Такого студента в нашей базе нет. Попробуйте ввести недавнего студента. ");
                        name1 = Console.ReadLine();
                        Console.WriteLine($"Студент: {name} и его оценка {assessment}! ");
                    }
                }

                else
                {
                    Console.WriteLine("Всё понятно, выходим из программы \n");
                }
            }
        }

        internal class Class3
        {

            public class Node<T>
            {
                public Node(T data) // Узел списка
                {

                    Data = data;

                }
                public T Data { get; set; }
                public Node<T> Previous { get; set; }
                public Node<T> Next { get; set; }

            }

            public class DoubleLinkedList<T> : IEnumerable<T>
            {

                Node<T> head; // головной/первый элемент
                Node<T> tail; // последний/хвостовой элемент
                int count;  // количество элементов в списке

                public void Add(T data)
                {
                    Node<T> node = new Node<T>(data);

                    if (head == null)
                        head = node;
                    else
                    {
                        tail.Next = node;
                        node.Previous = tail;
                    }
                    tail = node;
                    count++;
                }
                IEnumerator IEnumerable.GetEnumerator()
                {
                    return ((IEnumerable)this).GetEnumerator();
                }

                IEnumerator<T> IEnumerable<T>.GetEnumerator()
                {
                    Node<T> current = head;
                    while (current != null)
                    {
                        yield return current.Data;
                        current = current.Next;
                    }
                }

                public IEnumerable<T> BackEnumerator()
                {
                    Node<T> current = tail;
                    while (current != null)
                    {
                        yield return current.Data;
                        current = current.Previous;
                    }
                }
            }

            public void TaskLoop()
            {  
                Console.WriteLine();
                Console.WriteLine("Третья задача. Сейчас будем вводить от 3 до 6 элементов. А далее выведем его! ");
                Console.WriteLine();
                Console.WriteLine("Если что, мы можем выйти из этой программы, если вы напишите '-exit'.");
                Console.WriteLine("Если продолжаем - напишите любое слово.");

                string exit = Console.ReadLine();

                if (exit != "-exit")
                {

                    Console.WriteLine();
                    Console.WriteLine("Отлично, продолжаем.");
                    Console.WriteLine("И так. Введите от 3 до 6 'элементов'. ");
                    Console.WriteLine("Это могут быть как слова, так и цифры. ");

                    DoubleLinkedList<object> Elements = new DoubleLinkedList<object>();


                    for (int i = 0; i < 3; i++)
                    {


                        Console.WriteLine("Напишите элемент нашего списка:  ");
                        object text = Console.ReadLine();
                        Elements.Add(text);
                    }

                    Console.WriteLine("И так. Мы добавили 3 элемента.");

                    Console.WriteLine("Хотите добавить ещё 3 элемента? Напишите: Yes/No");

                    string answer = Console.ReadLine();

                    if (answer == "Yes" )
                    {
                        for (int i = 0; i < 3; i++)
                        {


                            Console.WriteLine("Напишите элемент нашего списка:  ");
                            object text = Console.ReadLine();
                            Elements.Add(text);
                        }
                    }

                    else { }

                    Console.WriteLine();
                    Console.WriteLine("Теперь посмотрим на наш список в прямом порядке: ");
                    foreach (object element in Elements)
                    {
                        Console.WriteLine(element);
                    }

                    Console.WriteLine();
                    Console.WriteLine("А Теперь обратном порядке: ");

                    foreach (object element in Elements.BackEnumerator())
                    {
                        Console.WriteLine(element);
                    }

                }

                else
                {
                    Console.WriteLine("Всё понятно, выходим из программы \n");
                }
            }
        }
        internal static void CheckTaskFirst()
    {
        var listTask = new Class1();
        listTask.TaskLoop();
    }

        internal static void CheckTaskSecond()
    {
        var listTask = new Class2();
        listTask.TaskLoop();
    }

        internal static void CheckTaskThird()
        {
            var listTask = new Class3();
            listTask.TaskLoop();
        }
    }
}