// Выяснить являются ли три числа сторонами треугольника
Console.WriteLine($"Введите число 1 ");
int number1 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine($"Введите число 2 ");
int number2 = int.Parse(Console.ReadLine()??"0");
Console.WriteLine($"Введите число 3 ");
int number3 = int.Parse(Console.ReadLine()??"0");
if((number1 + number2 > number3) && (number1 + number3 > number2) && (number2 + number3 > number1))
    Console.WriteLine("да");
else Console.WriteLine("нет");   



