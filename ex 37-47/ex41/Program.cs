// Выяснить являются ли три числа сторонами треугольника
Console.Clear();
System.Console.WriteLine();
System.Console.WriteLine("Выяснить являются ли три числа сторонами треугольника.");
Thread.Sleep(1000);
System.Console.WriteLine("Start");

bool TriangleOrNo(int a, int b, int c)      // метод проверяте являются ли числа сторонами треугольника
{
    return a + b > c && a + c > b && b + c > a ? true : false;
}
Thread.Sleep(1000);
System.Console.Write("Введите первое число: ");
Thread.Sleep(800);
int num01 = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(800);
System.Console.Write("Введите второе число: ");
int num02 = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(800);
System.Console.Write("Введите третье число: ");
int num03 = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Подождите мы выясняем.");
for (int i = 0; i < 22; i++)
{
    System.Console.Write(".");
    Thread.Sleep(200);
}
System.Console.WriteLine();
System.Console.WriteLine("Ура! Мы выяснили.");
Thread.Sleep(1000);

if (TriangleOrNo(num01, num02, num03))
{
    System.Console.Write($"Числа: {num01}, {num02}, {num03}" );
    Thread.Sleep(3500);
    System.Console.Write(" являются сторонами треугольника");
}
else
{
    System.Console.Write($"Числа: {num01}, {num02}, {num03}");
     Thread.Sleep(3500);
    System.Console.Write(" не являются сторонами треугольника");
}

System.Console.WriteLine();
Thread.Sleep(700);
System.Console.WriteLine("End");
System.Console.WriteLine();

