int AreaInteger(int radius)
{
    return Convert.ToInt32(Math.Round(Math.PI * Math.Pow(radius, 2)));
}
int MaxDigit(int number)
{
    int[] array = number.ToString().ToCharArray().Select(x => int.Parse(x.ToString())).ToArray();
    int max = array[0];
    for (int i = 0; i < number.ToString().Length; i++)
    {
        max = Math.Max(max, array[i]);
    }
    return max;
}

Console.Clear();
int radius = 0;
while (true)
{
    Console.WriteLine("Введите радиус круга");
    if (!int.TryParse(Console.ReadLine(), out radius) || radius < 0)
    {
        Console.WriteLine("Некорректный ввод");
    }
    else break;
}

Console.WriteLine(MaxDigit(AreaInteger(radius)));