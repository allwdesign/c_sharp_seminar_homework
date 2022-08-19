Console.WriteLine("Введите число ");
int n = Convert.ToInt32(Console.ReadLine());

int a = n % 100;

int c = n % 10;

Console.WriteLine(c);


Console.WriteLine("Введите первое целое число ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе целое число ");
int y = Convert.ToInt32(Console.ReadLine());


if (y == x * x)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}

﻿Console.WriteLine("Введите номер дня недели ");
int x = Convert.ToInt32(Console.ReadLine());

if (x == 1)
{
    Console.WriteLine("Понедельник");
}
else if (x == 2)
{
    Console.WriteLine("Вторник");
}
else if (x == 3)
{
    Console.WriteLine("Среда");
}
else if (x == 4)
{
    Console.WriteLine("Четверг");
}
else if (x == 5)
{
    Console.WriteLine("Пятница");
}
else if (x == 6)
{
    Console.WriteLine("Суббота");
}
else if (x == 7)
{
    Console.WriteLine("Воскресенье");
}
else Console.WriteLine("Введите корректное число");

