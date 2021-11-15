// Написать программу замену элементов массива на противоположные

int[] array = new int[8];
int[] FillArr(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = new Random().Next(0, 10);
    }
    return x;
}
void Print(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        System.Console.Write(x[i] + " ");
    }
}
int[] GetReplace(int[] x)
{
    int[] y =new int[x.Length];
    for (int i = 0; i < x.Length; i++)
    {
        y[i]=x[x.Length-i-1];
    }
    return y;
}
array = FillArr(array);
System.Console.WriteLine();
System.Console.Write("Исходный массив: ");
Print(array);
System.Console.WriteLine();
System.Console.Write("Измененный массив: ");
Print(GetReplace(array));
