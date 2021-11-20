// Написать программу преобразования десятичного числа в двоичное
System.Console.Write("Введите десятичное число: ");
int num = int.Parse(Console.ReadLine());
System.Console.Clear();
string GetBinaryNumber(int x)
{
    string b = string.Empty;
    string c = string.Empty;
    for (int i = 0; x != 0; i++)
    {
        if (x == 1)
        {
            b += $"{1}";
            x = 0;
        }
        else
        {
            b += $"{x % 2}";
            x = x / 2;
        }
    }
    for (int j = b.Length - 1; j >= 0; j--)
    {
        c += $"{b[j]}";
    }
    return c;
}
string binary = GetBinaryNumber(num);
System.Console.WriteLine($"Двоичное представление числа {num} = {binary}");