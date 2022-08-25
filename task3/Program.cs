Console.Clear();
int number = 0;
while (true)
{
    Console.WriteLine("Введите число");
    if (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("Некорректный ввод");
    }
    else break;
}
if (number >= 0)
{
    for (int i = 1; i <= number; i++)
    {
        Console.Write(Math.Pow(i, 3) + " * ");
    }
}
else
{
    for (int i = 1; i >= number; i--)
    {
        Console.Write(Math.Pow(i, 3) + " * ");
    }
}