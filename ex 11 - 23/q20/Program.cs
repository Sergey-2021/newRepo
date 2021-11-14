// Задать номер четверти, показать диапазоны для возможных координат

string Get(int x)
{

    if (x == 1)
    {
        return "Первая четверть. X(от 0 до n) и Y(от 0 до n)";
    }
    else if (x == 2)
    {
        return "Вторая четверть. X(-n до 0) и Y(от 0 до n)";
    }
    else if (x == 3)
    {
        return "Третья четверть. X(-n до 0) и Y(-n до 0)";
    }
    else if (x == 4)
    {
        return "Четвертая четверть. X(от 0 до n) и Y(-n до 0)";
    }
    else
    {
        return "Введите число от 1 до 4";
    }
}

System.Console.Write("Введите номер четверти от 1 до 4: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(Get(x));
