// // Определить количество цифр в числе
System.Console.WriteLine();
System.Console.Write("Введите любое число: ");
int num = int.Parse(Console.ReadLine());
int GetNum(int x)
{
    string a = x.ToString();
    return (x < 0) ? a.Length - 1 : a.Length;
}

System.Console.WriteLine();
System.Console.WriteLine($"Количество цифр в числе {num} = {GetNum(num)}");