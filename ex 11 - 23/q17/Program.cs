// По двум заданным числам проверять является ли одно квадратом другого
System.Console.WriteLine();
System.Console.Write("Введите первое число: ");
int one =Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число: ");
int two = Convert.ToInt32(Console.ReadLine());
string Get(int x, int y)
{ 
    if(x*x==y)
    return ($"{y} является квадратом {x}");
    else if(y*y==x)
    {
        return ($"{x} является квадратом {y}");
    }
    else
    {
        return "Ни одно число не является квадратом другого";
    }
}  
System.Console.WriteLine();
System.Console.WriteLine(Get(one, two));