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
    Console.WriteLine($"Куб числа {i} = {T(i)}");
}
System.Console.WriteLine();
if (T(3)==27) System.Console.WriteLine("Проверка метода выполнена: УСПЕХ!");
else System.Console.WriteLine("No");