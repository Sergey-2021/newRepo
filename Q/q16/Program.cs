// Дано число обозначающее день недели. Выяснить является номер дня недели выходным


bool DayNum(int x)
{
    return (x == 6 | x == 7);
}
int day = int.Parse(Console.ReadLine());
if (day >= 1 & day <= 7)
{
    Console.WriteLine(DayNum(day));
}
else
{
    Console.WriteLine("Увы.");
}