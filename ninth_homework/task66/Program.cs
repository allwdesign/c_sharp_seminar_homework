//Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
//элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int GetSumNaturalNumbersInTheRange(int startNum, int endNum)
{
    if(startNum == endNum) return endNum;
    
    return startNum + GetSumNaturalNumbersInTheRange(startNum+1, endNum);
}

void ProgramCheck()
{
    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    int[,] numArray = { { 1, 15 }, { 4, 8 } };
    
    Console.WriteLine(
        $"M = {numArray[0,0]}; N = {numArray[0,1]}. -> " + 
        GetSumNaturalNumbersInTheRange(numArray[0,0], numArray[0,1]));
    
    Console.WriteLine(
        $"M = {numArray[1,0]}; N = {numArray[1,1]}. -> " + 
        GetSumNaturalNumbersInTheRange(numArray[1,0], numArray[1,1]));
    
    Console.WriteLine("\n---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();


try
{
    Console.WriteLine(
        "This program will print the sum of natural numbers in the range " +
        "from M to N");

    Console.Write("Enter a natural number start range (M): ");
    int startNumber = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter a natural number end range (N): ");
    int endNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(
        $"M = {startNumber}; N = {endNumber}. -> " +
        GetSumNaturalNumbersInTheRange(startNumber,endNumber));
}
catch
{
    Console.WriteLine(
        "You entered the wrong value! The value must be a natural number.");
}