using System.ComponentModel.Design;

Console.WriteLine("Напишите первое число, затем нажмите Enter)");
bool numbercheck1 = int.TryParse(Console.ReadLine(), out int FirstValue);
if (!numbercheck1)
{
    Console.WriteLine("Введён некорректный символ!");
    return;
}

Console.WriteLine("А теперь напишите второе число и нажмите Enter");
bool numbercheck2 = int.TryParse(Console.ReadLine(), out int SecondValue);
if (!numbercheck2)
{
    Console.WriteLine("Введён некорректный символ!");
    return;
}

Console.WriteLine("Теперь введите + - / * и Enter");
bool numbercheck3 = char.TryParse(Console.ReadLine(), out char ThirdValue);
if (!numbercheck3)
{
    Console.WriteLine("Введён некорректный символ!");
    return;
}

int Plus = FirstValue + SecondValue;
int Minus = FirstValue - SecondValue;
int Multi = FirstValue * SecondValue;
int Div = FirstValue / SecondValue;


switch (ThirdValue)
{
    case '+':

        Console.WriteLine("В десятичной форме:" + Plus);
        Console.WriteLine ("В шестнадцатиричной форме:" + Convert.ToString(Plus, 16));
        Console.WriteLine("В двоичной форме:" + Convert.ToString(Plus, 2));;
        break;

    case '-':
        Console.WriteLine("В десятичной форме:" + Minus);
        Console.WriteLine("В шестнадцатиричной форме:" + Convert.ToString(Minus, 16));
        Console.WriteLine("В двоичной форме:" + Convert.ToString(Minus, 2));
        break;

    case '*':
        Console.WriteLine("В десятичной форме:" + Multi);
        Console.WriteLine("В шестнадцатиричной форме:" + Convert.ToString(Multi, 16));
        Console.WriteLine("В двоичной форме:" + Convert.ToString(Multi, 2));
        break;

    case '/':
        Console.WriteLine("В десятичной форме:" + Div);
        Console.WriteLine("В шестнадцатиричной форме:" + Convert.ToString(Div, 16));
        Console.WriteLine("В двоичной форме:" + Convert.ToString(Div, 2));
        break;
}