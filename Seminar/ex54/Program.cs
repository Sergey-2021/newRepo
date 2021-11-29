// 54. В матрице чисел найти сумму элементов главной диагонали

int[,] GetFillArray(int[,] array, int from, int before)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(from, before);
        }
    }
    return array;
}

void PrintArray2D(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int GetSumElementsDiagonal(int[,] array)
{
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        result += array[i, i];
    }
    return result;
}

int[,] myArray = new int[4, 4];
int leftEdge = 1;
int rightEdge = 10;
myArray = GetFillArray(myArray, leftEdge, rightEdge);
PrintArray2D(myArray);
System.Console.WriteLine();
int sumElementDiagonal = GetSumElementsDiagonal(myArray);

//56. Написать программу, которая обменивает элементы первой строки и последней строки
int[,] GetExchangeRow(int[,] array)
{
    int[] boxStart = new int[array.GetLength(1)];
    int[] boxEnd = new int[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            boxStart[j] = array[0, j];
            boxEnd[j] = array[array.GetLength(0) - 1, j];
        }
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[0, j] = boxEnd[j];
            array[array.GetLength(0) - 1, j] = boxStart[j];
        }
    }

    return array;
}

myArray = GetExchangeRow(myArray);

//57. Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.

// Не понял условие 57 задачи.

// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить
int[,] ReplaceRowColumn(int[,] array)
{
    int[,] newArray = new int[array.GetLength(1), array.GetLength(0)];
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            newArray[i, j] = array[j, i];
        }
    }
    return newArray;
}
int[,] array01 = new int[8, 5];

array01 = ReplaceRowColumn(array01);

// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.