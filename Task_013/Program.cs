// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write ("Введите целое число: ");
int num = Convert.ToInt32 (Console.ReadLine());
string thirdnum (int n)
{
    if (n < 100)
        return "Третьей цифры нет";
    else
    {
        int third = n;
        while (third > 999)
        third = third / 10;
        third = third % 10;
        return $"Третья цифра числа {n} -> {third}";
    }
}
Console.Write (thirdnum(num));