// Задать массив, заполнить случайными положительными трёхзначными числами.
// Показать количество нечетныхчетных чисел.
int[] arrey = new int[10];
int[] FillArrey(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = new Random().Next(-999, 1000);
    }
    return x;
}
FillArrey(arrey);
int count = 0;
for (int i = 0; i < arrey.Length; i++)
{
    if (arrey[i] < 0)
        count++;
    System.Console.Write(arrey[i] + " ");
}
System.Console.WriteLine();
System.Console.WriteLine("Hечетныхчетных чисел в массиве - " + count);