// Определить номер четверти плоскости, 
//в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

string Get(int x, int y)
{

    if (x > 0 & y > 0)
    {
        return "Первая четверть";
    }
    else if (x < 0 & y > 0)
    {
        return "Вторая четверть";
    }
    else if (x < 0 & y < 0)
    {
        return "Третья четверть";
    }
    else if (x == 0 | y == 0)
    {
        return "Введите числа не равные 0";
    }
    else 
    {
        return "Четвертая четверть";
    }
}

System.Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Get(x, y));