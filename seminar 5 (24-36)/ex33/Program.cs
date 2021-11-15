// Задать массив из 12 элементов, заполненных числами из [0,9].
// Найти сумму положительных/отрицательных элементов массива
int[] array = new int[12];
int number_1 = -9;
int number_2 = 10;
int[] GetFillArray(int[] x, int y, int z)
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = new Random().Next(y, z);
    }
    return x;
}
void PrintArray(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        System.Console.Write(x[i] + " ");
    }
}
string GetSumNumArray(int[] x)
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
array = GetFillArray(array, number_1, number_2);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine(GetSumNumArray(array));