// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write ("Введите трехзначное целое число: ");
int num_3th = Convert.ToInt32 (Console.ReadLine());
string secnum (int num)
{
    if (num >= 100 && num <=999)
    {
    int sm = num / 10 % 10;
    return $"Вторая цифра числа {num} = {sm}";
    }
    else
    {return "Ошибка ввода - число не трехзначное";}
}
Console.Write (secnum(num_3th));