// Найти третью цифру числа или сообщить, что её нет
int num = new Random().Next(90, 111);
Console.WriteLine(" ");
if (num < 100)
{
    Console.WriteLine($"Число {num} не содержит третью цифру.");
}
else
{
    Console.WriteLine($"{num % 10} - третья цифра числа {num}");
}

Console.WriteLine(" ");
