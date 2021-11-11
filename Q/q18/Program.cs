// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool T(bool x, bool y)
{
   bool r = (!(x || y)) == (!x && !y);
        return r;
}
bool x = false;
bool y = true;
// bool x = false;
// bool y = false;
// bool x = true;
// bool y = true;
// bool x = true;
// bool y = false;
bool a = !(x | y);
bool b = !x & !y;
bool t = a == b;
Console.WriteLine("¬(X | Y)" + " " + "=" + " " + a);
Console.WriteLine("¬X & ¬Y" + " " + "=" + " " + b);
Console.WriteLine("Функция" + " " + T(x, y));
Console.WriteLine("Сравнение в переменной t" + " " + t);
