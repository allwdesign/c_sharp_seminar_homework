﻿//Напишите программу, которая принимает на вход
//трёхзначное число и на выходе показывает вторую
//цифру этого числа.

Console.WriteLine("Введите трехзначное число ");

int n = Convert.ToInt32(Console.ReadLine());

//n / 10 % 10 результат этого выражения
//даст 2ю цифру трехзначного числа.
Console.WriteLine(n / 10 % 10);