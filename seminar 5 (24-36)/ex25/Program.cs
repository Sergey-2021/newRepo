// Найти сумму чисел от 1 до А
int num = int.Parse(Console.ReadLine());
int Get(int x)
{
    int sum = 0;
    for (int i = 1; i <= x; i++)
    {
        sum = sum + i;
    }
    return sum;
}
System.Console.WriteLine(Get(num));