// Выяснить является ли число чётным
void EvenNumber(int x)
{
    
    if(x%2==0) Console.WriteLine($"Число {x} четное.");
    else
    {
        Console.WriteLine("Вы ввели не четное число.");
    }
}
Console.WriteLine(" ");
Console.WriteLine("Выяснить является ли число чётным: ");
Console.Write("Ведите число: ");
int number = Convert.ToInt32(Console.ReadLine());
EvenNumber(number);
Console.WriteLine(" ");
