// Найти сумму чисел одномерного массива стоящих на нечетной позиции
int[] FillArray(int[] x, int a, int b)   // метод заполняет массив
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = new Random().Next(a, b);
    }
    return x;
}
void PrintArrey(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        System.Console.Write(x[i] + " ");
    }
}
int GetSumNegativElement(int[] x)
{
    int sum = 0;
    for (int i = 1; i<x.Length; i+=2)
    {
        sum+=x[i];
    }
    return sum;
}
int[] array = new int[10];
int from = -9;
int before = 10;
array = FillArray(array, from, before);
PrintArrey(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сумму чисел одномерного массива стоящих на нечетной позиции: {GetSumNegativElement(array)}");
