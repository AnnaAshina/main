Console.Write("Введите число  ");
int numberA = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите число  ");
int numberB = int.Parse(Console.ReadLine()??"0");

if (numberA /numberB  == numberB)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}