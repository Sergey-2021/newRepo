﻿// 54. В матрице чисел найти сумму элементов главной диагонали

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
    // if (array.GetLength(0) != array.GetLength(1))
    // {
    //     System.Console.WriteLine("Это не возможно.");
    // }
    // else
    // {

    for (int i = 0; i < array.GetLength(0); i++)
    {

        for (int j = 0; j < array.GetLength(1); j++)
        {

            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
    // }
}
void PrintArray(int[,] array)
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
// PrintArray2D(myArray);
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
void ReplaceRowColumn(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int tmp = 0;
            if (j > i)
            {
                tmp = array[i, j];
                array[i, j] = array[j, i];
                array[j, i] = tmp;
            }
        }
    }
}


// 59. В прямоугольной матрице найти строку с наименьшей суммой элементов.

int IndexRowMinSumElements(int[,] array)
{
    int sumRowElements = 0;
    int min = 0;
    for (int i = 0; i < 1; i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRowElements += array[i, j];
            min = sumElementDiagonal;
        }
        sumRowElements = 0;
    }
    int indexRow = 0;
    for (int i = 1; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumRowElements += array[i, j];

        }
        System.Console.WriteLine(sumRowElements);
        if (sumRowElements < min)
        {
            min = sumRowElements;
            indexRow = i;
            sumRowElements = 0;
        }
    }
    return indexRow;
}
int[,] array01 = new int[3, 3];
array01 = GetFillArray(array01, 1, 10);




//60. Составить частотный словарь элементов двумерного массива

//61. Найти произведение двух матриц
int[,] ProdMatrix(int[,] matrix, int[,] matrix1)
{
    int[,] matrix2 = new int[matrix.GetLength(1), matrix1.GetLength(0)];
    if (matrix.GetLength(1) != matrix1.GetLength(0))
    {
        throw new Exception("Умножение не возможно! Количество столбцов первой матрицы не равно количеству строк второй матрицы.");
    }
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int z = 0; z < matrix1.GetLength(1); z++)
            {
               
                matrix2[i, j] += matrix[i, z] * matrix1[z, j];
                System.Console.WriteLine(matrix2[i, z]);
            }
        }
    }
    return matrix2;
}
int[,] a = {{1,0,2},
            {0,-1,3},
            {4,0,5}};
int[,] b = {{2,7,1},
            {3,2,-4},
            {1,-3,5}};


// PrintArray2D(a.GetLength(1));
// System.Console.WriteLine();
// PrintArray2D(b.GetLength(0));
int[,] c = ProdMatrix(a, b);
System.Console.WriteLine();
PrintArray2D(c);

//62. В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

//63. Сформировать трехмерный массив не повторяющимися двузначными числами показать его построчно на экран выводя индексы соответствующего элемента

//64. Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

//65. Спирально заполнить двумерный массив:  1  2  3  4
//                                           12 13 14  5
//                                           11 16 15  6
//                                           10  9  8  7


