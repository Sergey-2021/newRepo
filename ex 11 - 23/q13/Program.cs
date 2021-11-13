//Выяснить, кратно ли число заданному, если нет, вывести остаток.
int num = new Random().Next(100, 1000);
int number = new Random().Next(1, 10);
Console.WriteLine(" ");
Console.WriteLine($"Выяснить, кратно ли число - {num} числу - {number}: ");
if (num % number == 0)
{
    Console.WriteLine($"Число {num} кратно числу {number}");
}
else
{
    Console.WriteLine("Остаток от деления" + " " + num % number);
}
Console.WriteLine(" ");