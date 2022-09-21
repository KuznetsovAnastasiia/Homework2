/*Напишите программу, которая выводит третью цифру 
заданного числа или сообщает, что третьей цифры нет.

645 -> 5
78 -> третьей цифры нет
32679 -> 6*/

string CreatNumber()
{
    Console.WriteLine("Введите число: ");
    string number = Console.ReadLine();
    return number;
}

string number = CreatNumber();

void FindThirdDigit()
{
    int length = number.Length;
    if (length > 2)
    {
        char ThirdDigit = number[2];
        Console.WriteLine("Третья цифра заданного числа: " + ThirdDigit);
    }
    
    if (length < 3)
    {
    Console.WriteLine("В заданном числе отсутствует третья цифра.");
    }
}

FindThirdDigit();