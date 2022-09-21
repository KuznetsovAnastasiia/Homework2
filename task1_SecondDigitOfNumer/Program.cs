/*Напишите программу, которая принимает
на вход трёхзначное число и на выходе
показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1*/

int InterNumber()
{
    Console.WriteLine("Введите трёхзначное число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = InterNumber();

void FindSecondDigitOfNumber()
{
    if (number < 100 ^ number > 999)
    {
        Console.WriteLine("Введённое число не является трёхзначным.");
    }

    if (number > 99 & number < 1000)
    {
       int digit = (number % 100) / 10;
       Console.WriteLine("Вторая цифра введённого трёхзначного числа: " + digit + ".");    
    }
}

FindSecondDigitOfNumber();