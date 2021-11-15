// Задать массив из 8 элементов и вывести их на экран
int[] array = new int[8];
int num1 = 0;
int num2 = 10;
int[] FillArr(int[] x, int y, int z)
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = new Random().Next(y, z);
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
array = FillArr(array, num1, num2);
Print(array);