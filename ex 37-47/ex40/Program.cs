// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом



double[] FillArray(double[] arr, double x)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().NextDouble() * x;
    }
    return arr;
}
void PrintArray(double[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        System.Console.Write($"{x[i]}  ");
    }
}
double GetDifferenceElementMaxMin(double[] x, double max, double min)
{
    double diff = max - min;
    return diff;
}
double GetElemetMax(double[] x)
{
    double max = x[0];
    for (int i = 1; i < x.Length; i++)
    {
        if (x[i] > max)
        {
            max = x[i];
        }
    }
    return max;
}
double GetElemetMin(double[] x)
{
    double min = x[0];
    for (int i = 1; i < x.Length; i++)
    {
        if (x[i] < min)
        {
            min = x[i];
        }
    }
    return min;
}

double[] array = new double[5];
double b = Math.PI;       //Число пи
System.Console.WriteLine();
array = FillArray(array, b);
System.Console.Write("Числа массива: ");
PrintArray(array);
System.Console.WriteLine();
double max = GetElemetMax(array);
double min = GetElemetMin(array);
double num = GetDifferenceElementMaxMin(array, max, min);
System.Console.WriteLine();
System.Console.WriteLine($"Максимальный элемент массива = {max}; минимальный = {min}");
System.Console.WriteLine();
System.Console.WriteLine($"Разница между максимальным и минимальным элементом массива: {num}");
System.Console.WriteLine();