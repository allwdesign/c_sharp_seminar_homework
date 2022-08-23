Console.Write("Enter the integer number ");
int numberA = Convert.ToInt32(Console.ReadLine());
string msg = "Is " + numberA + " an even number?";

Console.WriteLine(msg);

if (numberA % 2 == 0)
{
    Console.WriteLine("Yes. This is an even number.");
}
else
{
   Console.WriteLine("No."); 
}

