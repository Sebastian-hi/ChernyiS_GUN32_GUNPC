using System.ComponentModel.Design;

Console.WriteLine("Напишите первое число + ЭНТЕР и другое + Энтер)");
//int.TryParse(Console.ReadLine(), out int a);
//int.TryParse(Console.ReadLine(), out int b);
//char.TryParse(Console.ReadLine(), out char c);


if (int.TryParse(Console.ReadLine(), out int a))
{
   //обработка
}
else 
{     
Console.WriteLine("введён корректный символ!");

    //Ваш текст
        
return;
}

if (int.TryParse(Console.ReadLine(), out int b))
{
    //обработка
}
else
{
    Console.WriteLine("введён корректный символ!");

    //Ваш текст

    return;
}

if (char.TryParse(Console.ReadLine(), out char c))
{
    //обработка
}
else
{
    Console.WriteLine("введён корректный символ!");

    //Ваш текст

    return;
}

switch (c)
{
    case '+':
        Console.WriteLine("В десятичной форме:");
        Console.WriteLine("Result of {0} + {1} = {2}", a, b, a + b);
        Console.WriteLine ("В шестнадцатиричной форме:");
        Console.WriteLine(Convert.ToString ( a + b, 16));
        Console.WriteLine("В двоичной форме:");
        Console.WriteLine(Convert.ToString(a + b, 2));
        break;

    case '-':
        Console.WriteLine("В десятичной форме:");
        Console.WriteLine("Result of {0} - {1} = {2}", a, b, a - b);
        Console.WriteLine("В шестнадцатиричной форме:");
        Console.WriteLine(Convert.ToString(a - b, 16));
        Console.WriteLine("В двоичной форме:");
        Console.WriteLine(Convert.ToString(a - b, 2));
        break;

    case '*':
        Console.WriteLine("В десятичной форме:");
        Console.WriteLine("Result of {0} * {1} = {2}", a, b, a * b);
        Console.WriteLine("В шестнадцатиричной форме:");
        Console.WriteLine(Convert.ToString(a * b, 16));
        Console.WriteLine("В двоичной форме:");
        Console.WriteLine(Convert.ToString(a * b, 2));
        break;

    case '/':
        Console.WriteLine("В десятичной форме:");
        Console.WriteLine("Result of {0} / {1} = {2}", a, b, a / b);
        Console.WriteLine("В шестнадцатиричной форме:");
        Console.WriteLine(Convert.ToString(a / b, 16));
        Console.WriteLine("В двоичной форме:");
        Console.WriteLine(Convert.ToString(a / b, 2));
        break;
}