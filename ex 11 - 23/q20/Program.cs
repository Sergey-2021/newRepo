// Задать номер четверти, показать диапазоны для возможных координат

string Get(int x, int y)
{

    if (x > 0 & y > 0)
    {
        return "Первая четверть. X(от 0 до n) и Y(от 0 до n)";
    }
    else if (x < 0 & y > 0)
    {
        return "Вторая четверть. X(-n до 0) и Y(от 0 до n)";
    }
    else if (x < 0 & y < 0)
    {
        return "Третья четверть. X(-n до 0) и Y(-n до 0)";
    }
    else if (x == 0 | y == 0)
    {
        return "Введите числа не равные 0";
    }
    else 
    {
        return "Четвертая четверть. X(от 0 до n) и Y(-n до 0)";
    }
}

System.Console.Write("Введите координату X: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите координату Y: ");
int y = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Get(x, y));
