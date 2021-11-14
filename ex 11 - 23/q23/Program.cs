//Показать таблицу квадратов чисел от 1 до N
int Get(int x)
{
    x=x*x;
    return x;
}
int num = Convert.ToInt32(Console.ReadLine());
for(int i = 1; i<=num; i++)
{
    System.Console.WriteLine($"Квадрат числа {i} = {Get(i)}");
}