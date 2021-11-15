// // Определить количество цифр в числе
System.Console.WriteLine();
System.Console.Write("Введите любое число: ");
string num = Console.ReadLine();
int GetNum(string x)
{
    int d = x.Length;
    return d;
}

System.Console.WriteLine($"Количество цифр в числе {num} = {GetNum(num)}");