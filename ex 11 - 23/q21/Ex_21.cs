// Программа проверяет пятизначное число на палиндромом.
System.Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
bool Pal(int x)
{
    if (x % 10 == x / 10000 & x % 100 / 10 == x / 1000 % 10)
    {
        return true;
    }
    else
    {
        return false;
    }
}
if (Pal(num)) System.Console.WriteLine($"Число {num} - палиндром.");
else System.Console.WriteLine($"Число {num} - не палиндром.");