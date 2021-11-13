// Определить, присутствует ли в заданном массиве, некоторое число
bool Get(int[] x, int y)
{
    bool a = false;
    for (int i = 0; i < x.Length; i++)
    {
        if (x[i] == y) 
        {
         a =  true;
        }

    }
    return a;
}
int[] arrey = new int[10];
int[] FillArrey(int[] x)
{
    for (int i = 0; i < x.Length; i++)
    {
        x[i] = new Random().Next(0, 20);
    }
    return x;
}
FillArrey(arrey);
for (int i = 0; i < arrey.Length; i++)
{
    System.Console.Write(arrey[i] + " ");
}
System.Console.WriteLine();
int num = 7;
System.Console.WriteLine();
if(Get(arrey, num)==true)
{
    System.Console.WriteLine($"Число {num} есть в массиве");
}
else
{
    System.Console.WriteLine($"Число {num} отсутствует в массиве");
}