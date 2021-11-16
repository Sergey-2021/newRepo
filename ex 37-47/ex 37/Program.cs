// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int[] FillArray(int[] x)   // метод заполняет массив
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = new Random().Next(10, 1000);
    }
    return x;
}
int GetCountElement(int[] x)  // метод находит количество элементов из отрезка [10, 99]
{
    int count = 0;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] >= 10 & x[i] <= 99)
        {
            count++;
        }
    }
    return count;
}
void PrintArrey(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        System.Console.Write(x[i] + " ");
    }
}

int[] array = new int[123];
array = FillArray(array);
PrintArrey(array);
System.Console.WriteLine();
System.Console.WriteLine($"Количество элементов из отрезка в одномерном массиве из 123 чисел [10,99]: {GetCountElement(array)}");