// Дано число. Проверить кратно ли оно 7 и 23
Console.WriteLine(" ");
Console.Write($"Введите число кратное 7 и 23: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num%7==0 && num%23==0)
{
    Console.WriteLine($"Число {num} кратно 7 и 23.");
}
else
{
    Console.WriteLine("Попробуй еще.");
}
Console.WriteLine(" ");