// Возведите число А в натуральную степень B используя цикл

// int toPower(int number, int degree)
// {

// }
//Найти кубы чисел от 1 до N
int t = 5;

int T(int a)
{
     int r = 1;
    for (int i = 1; i <= a; i++)
    {
       
        r =i*i*i;
       
    }
   
     return r;
}
for (int i = 1; i<=t; i++)
{
    Console.WriteLine(T(i));
}

if (T(3)==27) System.Console.WriteLine("Yes");
else System.Console.WriteLine("No");