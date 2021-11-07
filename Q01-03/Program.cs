// 1. По двум введённым числам проверять является ли первое квадратом второго

Console.WriteLine(" ");
Console.WriteLine(" ");
Console.WriteLine(" 1. По двум введённым числам проверять является ли первое квадратом второго:");
Console.Write("Первое число - ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Второе число - ");
int b = Convert.ToInt32(Console.ReadLine());
int c = b * b;

if (c == a) Console.WriteLine($"    Число {a} является квадратом числа {b}.");
else
    Console.WriteLine($"    Число {a} не является квадратом числа {b}.");
Console.WriteLine(" ");

// 2.Даны два числа. Показать большее и меньшее число
Console.WriteLine(" 2. Даны два числа. Показать большее и меньшее число:");

if (a > b) Console.WriteLine($"    {a} - большее число; {b} - меньшее число.");
else
{
    Console.WriteLine($"     {b} - большее число; {a} - меньшее число");
}
Console.WriteLine("");

//3.По введенному номеру дня недели вывести его название
Console.WriteLine(" 3. По введенному номеру дня недели вывести его название:");

Console.WriteLine("     Введите номер дня недели от 1 до 7 ");
Console.Write($"     Ваш выбор - ");
int day = Convert.ToInt32(Console.ReadLine());

string[] week = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскреснье" };
if(day > 7 || day <1) Console.WriteLine("Введите число от 1 до 7.");
else
{
Console.WriteLine("     Это " + week[day - 1] + "!");
}
Console.WriteLine(" ");
