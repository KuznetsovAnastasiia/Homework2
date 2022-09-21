/* Напишите программу, которая принимает на вход цифру, 
обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет*/

int InterDayNumber()
{
    Console.WriteLine("Введите номер дня недели: ");
    int DayNumber = Convert.ToInt32(Console.ReadLine());
    return DayNumber;
}

int DayNumber = InterDayNumber();

void FindDayName()
{
    if (DayNumber < 1 ^ DayNumber > 7)
    {
        Console.WriteLine("Введённый номер дня недели не является корректным.");
    }

    if (DayNumber > 0 & DayNumber < 6)
    {
        Console.WriteLine("День недели не является выходным.");
    }

    if (DayNumber == 6 ^ DayNumber == 7)
    {
        Console.WriteLine("День недели является выходным.");
    }
}

FindDayName();
