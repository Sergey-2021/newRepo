// Дано число обозначающее день недели. Выяснить является номер дня недели выходным


bool DayNum(int x)
{
    return (x == 6 | x == 7);
}
System.Console.Write("Ведите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if (DayNum(day))
{
    Console.WriteLine($"Yes! Выходной");
}
else
{
    Console.WriteLine("Увы. Не выходной");
}