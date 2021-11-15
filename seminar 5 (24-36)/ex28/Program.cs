// Подсчитать сумму цифр в числе
System.Console.WriteLine();
System.Console.Write("Введите число (не более 9 символов): ");
int num = Convert.ToInt32(System.Console.ReadLine());
int GetSum(int x)
{
    string u = x.ToString();
    int sum = 0;
    for (int i = u.Length; i > 0; i--)
    {
        if (i > 0)
        {
            sum += x % 10;
            x = x / 10;
        }
    }
    return sum;
}
System.Console.WriteLine($"Сумма цифр числа {num} = {GetSum(num)}");