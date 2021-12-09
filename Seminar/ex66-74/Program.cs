// 66. Показать натуральные числа от 1 до N, N задано
void T(int x)
{
    if (x < 1) return;
    T(x - 1);
    System.Console.Write(x + " ");
}


void B(int x)
{
    if (x > 1)
    {
        T(x - 1);
        System.Console.Write(x + " ");
    }
}
System.Console.WriteLine();


//68.Показать натуральные числа от M до N, N и M заданы

void G(int m, int n)
{
    if (m < n)
    {
        if (n == m) System.Console.Write(n);

        else
        {
            G(m, n - 1);
            System.Console.Write(" " + n);
        }
    }
    else if (m >= n)
    {
        if (m == n) System.Console.Write(m);

        else
        {
            System.Console.Write(m + " ");
            G(m - 1, n);
        }
    }
}
G(10, 5);
