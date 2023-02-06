Console.Write("Введите пятизнаяное число: ");
int number = int.Parse(Console.ReadLine());
 
int IsPalindrom(int number, int a)
{
    while (number > 0)
    {
        a = a * 10 + number % 10;
        number /= 10;
    }
    return a;
}

string Proverka(int number)
{
    if (IsPalindrom(number, 0) == number)
        return "Это число является полиндромом";
    else
        return "Это число не является полиндромом";
}

Console.Write(Proverka(number));
