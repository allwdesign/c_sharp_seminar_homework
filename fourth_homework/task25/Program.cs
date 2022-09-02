﻿//Напишите цикл, который принимает на вход два числа
//(A и B) и возводит число A в натуральную степень B.

//baseA: int, if you name the base, error CS1001 occurs
//exp: int >= 0
//returns: int, base^exp

int Pow(int baseA, int exp)
{
    if (exp<0) throw new ArgumentException("Exponent must be greater than zero!");
    
    int result = 1;
    for (int i=1; i<=exp; i++)
    {
        result *= baseA; 
    }
    return result;
}

Console.Write("Enter the number A base of the power: ");

int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the number N exponent: ");
int n = Convert.ToInt32(Console.ReadLine());

//We can call this “a raised to the power of n,” “x to the power of n,” or simply “x to the n.” Here, x is the base and n is the exponent or the power.
try
{
    int power = Pow(a, n);
    Console.WriteLine($"The number {a} to the power of {n} is {power}");
}
catch (ArgumentException e)
{
    Console.WriteLine(e);
}