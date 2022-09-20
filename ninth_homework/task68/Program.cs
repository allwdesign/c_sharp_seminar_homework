//Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 3, n = 2 -> A(m,n) = 29

double AckermannFunctions(double m, double n)
{
    if (m == 0) return n + 1;
    else if (m > 0 && n == 0) return AckermannFunctions(m - 1, 1);
        
    return AckermannFunctions(m-1, AckermannFunctions(m, n-1));
}

void PrintResultAckermannFunctions(double m, double n)
{
    double result = AckermannFunctions(m, n);
    Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {result}\n");
}

void ProgramCheck()
{
    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    double[,] numArray = { { 3, 2 }, { 1, 2 } };

    PrintResultAckermannFunctions(numArray[0,0], numArray[0,1]);
    PrintResultAckermannFunctions(numArray[1,0], numArray[1,1]);
        
    Console.WriteLine("\n---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();


try
{
    Console.WriteLine(
        "This program will print the result of calculating the " +
        "Ackermann function for non-negative integers m and n.\n");

    Console.Write("Enter a natural number non-negative integer (m): ");
    double m = Convert.ToDouble(Console.ReadLine());
    
    Console.Write("Enter a natural number non-negative integer (n): ");
    double n = Convert.ToDouble(Console.ReadLine());

    if (m < 0 || n < 0) 
    {
        throw new ArgumentException();
    }
    
    PrintResultAckermannFunctions(m, n);
}
catch (ArgumentException)
{
    Console.WriteLine("The number must be greater than or equal to zero.");
}
catch (StackOverflowException)
{
    Console.WriteLine("Function call stack overflow.");
}
catch
{
    Console.WriteLine("Something went wrong");
}