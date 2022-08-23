Console.Write("Enter the first integer number ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second integer number ");
int numberB = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third integer number ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = 0;


if (numberA > numberB)
{
    max = numberA;
}
else
{
    max = numberB;
}

if (numberC > max)
{
    max = numberC;
}

Console.Write("max = " + max);