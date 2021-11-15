// Найти максимальное из трех чисел
int[] array = new int[3];
void FillArray(int[] x)
{
    for (int i = 0; i < x.Length; i++)
        x[i] = new Random().Next(0, 100);

}
void PrintArray(int[] x)
{
    Console.WriteLine("Найти максимальное из трех чисел: ");
    for (int i = 0; i < x.Length; i++)
    {
        Console.Write(x[i] + " ");
    }
}
void Max(int[] x)
{
    int max = x[0];
    if (max < x[1]) max = x[1];
    if (max < x[2]) max = x[2];
    Console.WriteLine($"Максимальное число из трех чисел - {max}");
}
FillArray(array);
PrintArray(array);
Console.WriteLine(" ");
Max(array);

