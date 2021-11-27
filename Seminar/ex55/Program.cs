//55. Дан целочисленный массив. Найти среднее арифметическое каждого из столбцов.
int[,] Array = new int[4, 8];
int Num1 = 2;
int Num2 = 6;
int[,] GetFillArray(int[,] NewArray, int a, int b)   // Заполняем массив
{
    for (int i = 0; i < NewArray.GetLength(0); i++)
    {
        for (int j = 0; j < NewArray.GetLength(1); j++)
        {
            NewArray[i, j] = new Random().Next(a, b);
        }
    }
    return NewArray;
}
double[] GetArithMeanColumn(int[,] arr)
{
    double sum = 0;
    double[] result = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        result[i]=Convert.ToDouble(sum/arr.GetLength(0));
        sum =0;
    }
    return result;
}
void PrintArray2D(int[,] x)
{
    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < x.GetLength(1); j++)
        {
            System.Console.Write(x[i, j] + " ");

        }
        System.Console.WriteLine();

    }
}
void PrintArray(double[] x)
{
    for (int i = 0; i < x.Length; i++)
    {      
        System.Console.Write($"({x[i]}) ");
    }
}

int[,] b = GetFillArray(Array, Num1, Num2);
PrintArray2D(b);
System.Console.WriteLine();

PrintArray(GetArithMeanColumn(b));
System.Console.Write("Cреднее арифметическое каждого из столбцов.");
