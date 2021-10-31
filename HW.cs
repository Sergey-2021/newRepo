// Cформировать случайным образом целочисленный массив A из натуральных двузначных чисел. 

//  Создать на его основе масcив B, отбрасывая те, которые:
//  a) нарушают порядок возрастания
//  b) больше среднего арифметического элементов A
//  c) чётные

void FillArray(int[] collection, int x, int y)

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(x, y);

        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int Count(int[] arr)
{
    int j = 1;
    int index = 1;
    int c = arr[0];
    while (index < arr.Length)
    {
        if (arr[index] > c)
        {
            c = arr[index];

            //Console.WriteLine(c);

            j++;


        }

        index++;

    }
    return j;
}
void FillArr(int[] listB, int[] listA)
{
    int i = 1;
    int index = 1;
    int c = listA[0];
    listB[0] = listA[0];
    while (index < listA.Length)
    {
        if (listA[index] > c)
        {
            c = listA[index];
            listB[i] = listA[index];
            i++;

        }

        index++;
    }
}
int SA(int[] x)
{
    int i = 0;
    int sum = 0;
    while (i < x.Length)
    {
        sum = sum + x[i];
        i++;
    }
    return sum / x.Length;
}
int Count2(int[] x)
{
    int i = 0;
    int c = 0;
    int a = SA(x);
    while (i < x.Length)
    {
        if (a < x[i])
        {
            c++;
        }
        i++;
    }
    return c;
}
void FillB(int[] x, int[] y)
{
    int i = 0;
    int j = 0;
    int a = SA(x);
    while (i < x.Length)
    {

        if (x[i] > a)
        {
            y[j] = x[i];
            j++;
        }
        i++;
    }
}
int Count3(int[] x)
{
    int i = 0;
    int j = 0;
    while (i < x.Length)
    {
        if(x[i]%2!=0)
        {
            j++;
        }
        i++;
    }
    return j;
}
void FillD(int[] x, int[] y)
{
    int i=0;
    int j =0;
    while(i<x.Length)
    {
        if(x[i]%2!=0)
        {
            y[j]=x[i];
            j++;
        }
        i++;
    }
}
int[] array = new int[15];

FillArray(array, 10, 100);

Console.WriteLine();
Console.WriteLine("Массив А");

PrintArray(array);

int j = Count(array);
int[] B = new int[j];

FillArr(B, array);
Console.WriteLine();
Console.WriteLine("Создан массив B из массива А, отбрасывая элементы, которые нарушают порядок возрастания.");

PrintArray(B);

Console.WriteLine();
int[] C = new int[Count2(array)];

Console.WriteLine("Среднее арифметическое элементов A = " + SA(array));
Console.WriteLine();
FillB(array, C);
Console.WriteLine("Массив С больше среднего арифметического элементов массива A");
PrintArray(C);
int[] D = new int[Count3(array)];
FillD(array, D);
Console.WriteLine();
Console.WriteLine("Массив D из массива А, отбрасывая четные элементы.");
PrintArray(D);