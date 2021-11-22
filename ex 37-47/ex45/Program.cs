// Показать числа Фибоначчи
int a = 0;
int b = 1;
int n = 15;
System.Console.Write(a + " ");
System.Console.Write(b + " ");
for (int i = 0; i < n; i++)
{
    System.Console.Write(a + b + " ");
    b = a + b;
    a = b - a;
}
