bool IsPalindrome(int number)
{
    bool palindrom = true;
    number = Math.Abs(number);
    int[] array = number.ToString().ToCharArray().Select(Convert.ToInt32).ToArray();
    int forward = 0;
    int back = array.Length - 1;
    while (forward <= back)
    {
        if ((array[forward] == array[back]))
        {
            palindrom = true;
        }
        else
        {
            palindrom = false;
            break;
        }
        forward++;
        back--;
    }
    return palindrom;
}

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
if (IsPalindrome(number))
{
    Console.WriteLine("Является палиндромом");
}
else Console.WriteLine("Не является палиндромом");