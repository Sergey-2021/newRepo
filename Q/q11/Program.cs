// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
int num = new Random().Next(10, 100);
int a = num % 10;
int b = num / 10;
Console.WriteLine(" ");
Console.WriteLine("Дано число из отрезка [10, 99]. Показать наибольшую цифру числа:");
Console.WriteLine(" ");
Console.WriteLine($"Число из отрезка [10, 99] - {num}");
Console.WriteLine(" ");
if (a > b)
{
    Console.WriteLine($"Наибольшуая цифра числа: {a}");
}
else
{
    Console.WriteLine($"Наибольшуая цифра числа: {b}");
}