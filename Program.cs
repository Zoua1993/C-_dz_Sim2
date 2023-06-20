/*
// Задача 1.
// Напишите программу которая на вход принимает трехзначное число
// и на выходе показывает вторую цифру этого числа (Проверка на прехзначность при вводе пользователем)

// 456 -> 5
// 782 -> 8
// 918 -> 1

int Prompt(string msg)
{
    System.Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine()!);
}

int number = Prompt("Введите трехзначное число");
if (number >= 100 && number < 1000)
{
    int mid = (number % 100 - number % 10) /10;
    System.Console.WriteLine($"Вторая цифра числа {number} является {mid}");
}
else
{
    System.Console.WriteLine("Это не трехзначное число");
}


// Задача 2.
// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int Prompt(string msg)
{
    
    Console.Write(msg);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int GetThirdRank(int number)
{
    while (number > 999)     
    {
    number /=10;
    }
return number % 10;
}
bool ValidateNumber(int number)
{
    if (number < 100)
    {
        Console.WriteLine("3ей цифры нет");
        return false;
    }
    return true;
}
int number = Prompt("Введите число >");
if (ValidateNumber(number))
{
    Console.WriteLine(GetThirdRank(number));
}

*/
// Задача 3.
//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
// 6 -> да
// 7 -> да
// 1 -> нет

int Prompt(string msg)
{
    System.Console.WriteLine($"{msg}");
    return Convert.ToInt32(Console.ReadLine());
}
int number = Prompt("Введите число");
string ss = "Это не день недели";
string check (int number)
{
    if(number > 6 && number <8) ss = "Это выходной";
    if(number > 1 && number < 7) ss = "Это будний";
    return ss;
}
System.Console.WriteLine(check(number));
