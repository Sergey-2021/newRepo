// Найти кубы чисел от 1 до N
int num = int.Parse(Console.ReadLine());
int Get(int a)
{
    return a*a*a;
}
for (int i = 1; i <= num; i++)
{
    System.Console.WriteLine(Get(i));
}