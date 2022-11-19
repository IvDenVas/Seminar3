// Console.Clear();
// Console.Write ("Введите номер четверти: ");
// int x = int.Parse(Console.ReadLine() ?? "");

Console.Clear();
int x = 0;
InitCoordinatesByUser(ref x); 
PrintQuarterByCoords(x);

static void InitCoordinatesByUser(ref int x)
{
    try
    {
        Console.Write("Введите номер четверти: ");
        x = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}
static void PrintQuarterByCoords(int x)
{
    if(x == 1)
        Console.WriteLine("X > 0, Y > 0");
    else if(x == 2)
        Console.WriteLine("X < 0, Y > 0");
    else if(x == 3)
        Console.WriteLine("X < 0, Y < 0");
    else if(x == 4)
        Console.WriteLine("X > 0, Y < 0");
    else
        Console.WriteLine("Ошибка! Такой четверти не существует!");
}
