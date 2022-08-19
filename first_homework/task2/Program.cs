Console.Write("Enter the first integer number ");
int numberA = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second integer number ");
int numberB = Convert.ToInt32(Console.ReadLine());


if (numberA == numberB)
{
    Console.WriteLine("Both numbers are equal");
}
else if (numberA > numberB)
{
    Console.WriteLine("max = " + numberA + ", min = " + numberB);
}
else
{
    Console.WriteLine("max = " + numberB + ", min = " + numberA);
}
