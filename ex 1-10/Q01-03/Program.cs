﻿//           

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
Console.WriteLine();
