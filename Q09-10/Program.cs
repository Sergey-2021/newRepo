// Показать последнюю цифру трёхзначного числа


int number = new Random().Next(100, 1000);
Console.WriteLine(" ");
Console.WriteLine("Показать последнюю цифру трёхзначного числа: ");
Console.WriteLine($"Трёхзначное число - {number}");
Console.WriteLine(" ");
Console.WriteLine($"Последняя цифра трёхзначного числа - {number%10}");
Console.WriteLine(" ");
// Показать вторую цифру трёхзначного числа
Console.WriteLine("Показать вторую цифру трёхзначного числа: ");
Console.WriteLine($"Вторая цифра трёхзначного числа - {number/10%10}");
Console.WriteLine(" ");