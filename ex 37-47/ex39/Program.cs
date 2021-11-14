//Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.
int[] a = new int[10];
int[] FillArrey(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = new Random().Next(1, 10);
    }
    return x;
}
int[] Get(int[] x)
{
    int[] d = new int[5];
    for (int i = 0; i < d.Length; i++)
        d[i] = x[i] * x[x.Length - i - 1];
    return d;
}

void Print(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        System.Console.Write(x[i] + " ");
    }

}
FillArrey(a);
System.Console.Write("Выводим массив a: ");
Print(a);
System.Console.WriteLine();
System.Console.Write("Произведение пар чисел в одномерном массиве массив a: ");
Print(Get(a));
System.Console.WriteLine();



