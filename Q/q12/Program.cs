// Удалить вторую цифру трёхзначного числа
int number = new Random().Next(100, 1000);
int D (int x)
{
int a = number%10;
int b = number/100*10+a;
return b;
}
Console.WriteLine();
Console.WriteLine($"Удалить вторую цифру трёхзначного числа: {number}");
Console.WriteLine($"Результат удаления второй цифры трехзначного числа - {D(number)}");
Console.WriteLine();