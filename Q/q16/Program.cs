// Дано число обозначающее день недели. Выяснить является номер дня недели выходным


bool DayNum(int x)
{
    return (x == 6 | x == 7);
}
System.Console.Write("Ведите число: ");
int day = Convert.ToInt32(Console.ReadLine());

if (day >= 1 & day <= 7)
{
    Console.WriteLine($"Yes! Выходной {DayNum(day)}");
}
else
{
    Console.WriteLine("Увы.");
}