// Задать массив из 8 элементов и вывести их на экран
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
        System.Console.Write(x[i]+" ");
    }
}
array = FillArr(array);
Print(array);