// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
int[] FillArr(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = new Random().Next(-9, 10);
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
string GetSum(int[] x)
{
    int sum_01 = 0;
    int sum_02 = 0;
    for (int i = 0; i < x.Length; i++)

        if (x[i] > 0)
        {
            sum_01 += x[i];
        }
        else
        {
            sum_02 += x[i];
        }

    return $"Сумма положительных чисел массива = {sum_01}, отрицательных = {sum_02}";
}
array = FillArr(array);
Print(array);
System.Console.WriteLine();
System.Console.WriteLine(GetSum(array));