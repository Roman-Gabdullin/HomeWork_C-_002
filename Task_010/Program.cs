Console.Write ("Введите трехзначное целое число:");
int num_3th = Convert.ToInt32 (Console.ReadLine());
int second = num_3th / 10 % 10;
Console.Write ($"вторая цифра числа: {second}");