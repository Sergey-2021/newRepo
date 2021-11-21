// Написать программу копирования массива
int[] array = new int[10];
int[] array2 = new int[array.Length];
int[] FillArray(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = new Random().Next(1, 10);
    }
    return x;
}
int[] CopyArray(int[] y)
{
    int[] arr = new int[y.Length];
    for (int i = 0; i < y.Length; i++)
    {
        arr[i] = y[i];
    }
    return arr;
}
void PrintArray(int[] d)
{
    for (int i = 0; i < d.Length; i++)
    {
        System.Console.Write(d[i] + " ");
    }
    System.Console.WriteLine();
}
array = FillArray(array);
System.Console.WriteLine();
System.Console.Write("Исходный массив А: ");
PrintArray(array);
System.Console.WriteLine();
array2 = CopyArray(array);
System.Console.Write("Массив B копированный из А: ");
PrintArray(array2);
array[0]= 9;
System.Console.WriteLine();
System.Console.Write("Измененный массив А: ");
PrintArray(array);
System.Console.WriteLine();
System.Console.Write("Массив B после изменения массива А: ");
PrintArray(array2);
