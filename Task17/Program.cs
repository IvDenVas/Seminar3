// Напишите программу, которая принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.Clear();
Console.Write("Введите X: ");
int X = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите Y: ");
int Y = int.Parse(Console.ReadLine());
if (X > 0 && Y > 0)
{
    Console.Write("1");
}
else if (X < 0 && Y > 0)
{
    Console.Write("2");
}
else if (X < 0 && Y < 0)
{
    Console.Write("3");
}
else if (X > 0 && Y < 0)
{
    Console.Write("4");
}
else 
{
    Console.Write("Ошибка! Точка попадает на оси координат!");
}