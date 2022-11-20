Console.Clear();

int x1 = userinput("Введите координату Х точки А: ");
int y1 = userinput("Введите координату Y точки А: ");
int x2 = userinput("Введите координату Х точки B: ");
int y2 = userinput("Введите координату Y точки B: ");

double res = DisPoint (x1, y1, x2, y2);
Console.Write(res);
static double DisPoint (int x1, int y1, int x2, int y2)
{
    return Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2));
}
static int userinput (string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine() ?? "");
}