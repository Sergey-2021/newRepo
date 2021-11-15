// Написать программу вычисления произведения чисел от 1 до N

System.Console.WriteLine();
System.Console.WriteLine("Программа вычисления произведения чисел от 1 до N");
System.Console.Write("Введите число N: ");
int num = Convert.ToInt32(System.Console.ReadLine());
int GetProd(int x)
{
    int s = 1;
    for (int i = 1; i <= x; i++)
    {
        s *= i;
    }
    return s;
}
System.Console.WriteLine($"Произведение чисел от 1 до {num} = {GetProd(num)}");
