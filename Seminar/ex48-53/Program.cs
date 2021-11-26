
// // 48. Показать двумерный массив размером m×n заполненный целыми числами
int[,] GetArray(int a, int b)  // Метод создает двухмерный массив
{
    int[,] arr = new int[a, b];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(5, 10);
        }
    }
    return arr;
}
void PrintArray2(double[,] x)
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
// //  49. Показать двумерный массив размером m×n заполненный вещественными числами
double[,] GetArrayDouble(double[,] x)
{
    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < x.GetLength(1); j++)
        {
            x[i, j] = new Random().NextDouble();
        }
    }
    return x;
}
double[,] arrayFilled2 = new double[3, 4];
PrintArray2(GetArrayDouble(arrayFilled2));
// // 52. В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
int[,] arrayFilled = new int[3, 4];
arrayFilled = GetArray(6, 6);
PrintArray(arrayFilled);
System.Console.WriteLine();
int[,] GetArraySquareEvenIndex(int[,] x)
{
    for (int i = 0; i < x.GetLength(0); i++)
    {
        for (int j = 0; j < x.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                x[i, j] *= x[i, j];

            }
        }
    }
    return x;
}

PrintArray(GetArraySquareEvenIndex(arrayFilled));

// // 53. В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

void PrintArray(int[,] x)
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
// void Pozicia(int[,] x, int a)
// {
//     System.Console.WriteLine($"Позиция числа {a} в массиве: строка столбец");
//     for (int i = 0; i < x.GetLength(0); i++)
//     {
//         for (int j = 0; j < x.GetLength(1); j++)
//         {
//             if (x[i, j] == a)
//             {
//                 System.Console.WriteLine($"                             {i}       {j} ");
//             }

//         }
//     }
// }
// int[,] b = new int[2, 4];
// b = GetArray(3, 6);
// PrintArray(b);
// System.Console.WriteLine();
// Pozicia(b, 6);

