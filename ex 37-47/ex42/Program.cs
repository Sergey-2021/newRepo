//Определить сколько чисел больше 0 введено с клавиатуры
string number = Console.ReadLine();
int GetCount(string x)
{
    int count = 0;
    int a = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (a == 0 & Char.IsDigit(x[i]))
        {
            a = 1;
            count++;
        }
        else if (a >= 0 & !Char.IsDigit(x[i]))
        {
            a = 0;
        }
    }
    return count;
}

System.Console.WriteLine($"Чисел больше 0 введено с клавиатуры: {GetCount(number)}");
