//Показать кубы чисел, заканчивающихся на четную цифру
int num = 7;
int UU(int x)
{
    int r = 1;
    for (int i = 1; i <= x; i++) 
    {
        r = i * i * i;
    }
    return r;
}
for (int i = 1; i < +num; i++)
{
   System.Console.WriteLine(UU(i));
}
System.Console.WriteLine();
for (int i = 1; i < +num; i++)
{
    int t = UU(i);
    if (t % 2 == 0) System.Console.WriteLine(t);
}

