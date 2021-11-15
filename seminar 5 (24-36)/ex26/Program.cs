//Возведите число А в натуральную степень B используя цикл
System.Console.WriteLine();
System.Console.WriteLine("Возведите число А в натуральную степень B:");
System.Console.Write("Введите число А: ");
int num = int.Parse(Console.ReadLine());
System.Console.Write("Введите число В: ");
int degree = int.Parse(Console.ReadLine());
int GetDegree(int x, int y)
{
    int r = x;
    for(int i =1; i<y; i++)
    {
        r*=x;
    }
    return r;
}
System.Console.WriteLine($"Число {num} в степени {degree} = {GetDegree(num, degree)}");