

Console.WriteLine("Input 1 number");
bool numbercheck1 = int.TryParse(Console.ReadLine(), out int numberOne);
if (!numbercheck1)
{
    Console.WriteLine("Error");
    return;
}

Console.WriteLine("Input 2 number");
bool numbercheck2 = int.TryParse(Console.ReadLine(), out int numberTwo);
if (!numbercheck2)
{
    Console.WriteLine("Error");
    return;
}

Console.WriteLine("Input action");
bool numbercheck3 = char.TryParse(Console.ReadLine(), out char numberThree);
if (!numbercheck3)
{
    Console.WriteLine("Error");
    return;
}