int[] AddPoint()
{
    int[] array = new int[3];
    Console.WriteLine("Введите координаты точки (x,y,z)");

    for (int i = 0; i < 3; i++)
    {
        Console.Write("Введите координату #" + Convert.ToInt32(i + 1) + " = ");
        if (!int.TryParse(Console.ReadLine(), out array[i]))
        {
            i--;
            Console.WriteLine("Некорректный ввод");
        }
    }
    return array;
}

void PrintPoint(int[] point)
{
    Console.WriteLine("Точка: " + "x=" + point[0] + "; y=" + point[1] + "; z=" + point[2]);
}

double Distance(int[] point1, int[] point2)
{
    return Math.Sqrt(Math.Pow(point2[0] - point1[0], 2) + Math.Pow(point2[1] - point1[1], 2) + Math.Pow(point2[2] - point1[2], 2));
}

Console.Clear();
int[] point1 = AddPoint();
int[] point2 = AddPoint();
Console.Clear();
PrintPoint(point1);
PrintPoint(point2);
Console.WriteLine("Расстояние равно: " + Distance(point1, point2));
