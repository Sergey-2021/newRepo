// Показать числа от -N до N
// Показать четные числа от 1 до N
void PrintOrder(int y, int x)
{
    for (int i = x; i < y + 1; i++)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine(" ");
}
void PrintEven(int x)
{
    for (int i = 1; i < x + 1; i++)
    {
        if(i%2==0)
        {
        Console.Write(i + " ");
        }
    }

}
int Negativ = new Random().Next(-10, -1);
int Pozitiv = new Random().Next(1, 11);
Console.WriteLine(" ");
Console.WriteLine("Показать числа от -N до N: ");
Console.WriteLine($"-N = {Negativ} ");
Console.WriteLine($" N = {Pozitiv} ");
PrintOrder(Pozitiv, Negativ);

int number = new Random().Next(1, 15);
Console.WriteLine(" ");
Console.WriteLine("Показать четные числа от 1 до N:");
Console.WriteLine($"N = {number}");
PrintEven(number);
Console.WriteLine(" ");