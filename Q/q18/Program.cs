// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y
bool T(bool x, bool y)
{
   bool r = (!(x || y)) == (!x && !y);
        return r;
}
bool x = false;
bool y = true;


Console.WriteLine("Функция" + " " + T(x, y));

