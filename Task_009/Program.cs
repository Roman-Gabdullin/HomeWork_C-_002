// Дополнительная Задача 9
// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
string multiplicity (int n, int m1, int m2)
{
    if (n % m1 ==0 && n % m2 ==0)
    {return $"Число {n} кратно {m1} и {m2}";}
    else
    {return $"Число {n} не кратно {m1} и {m2}";}
}
int mp1 =7;
int mp2 = 23;
Console.Write(multiplicity(num, mp1, mp2));