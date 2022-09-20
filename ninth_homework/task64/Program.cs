//Задайте значения M и N. Напишите программу, которая выведет все натуральные
//числа в промежутке от M до N.
//M = 1; N = 5. -> "1, 2, 3, 4, 5"
//M = 4; N = 8. -> "4, 5,6, 7, 8"

string GetStringWithNaturalNumbersInTheRange(int startNum, int endNum)
{
    if(startNum == endNum) return Convert.ToString(endNum);
    string res = GetStringWithNaturalNumbersInTheRange(startNum+1, endNum);
    return $"{startNum}, " + res;
}

void ProgramCheck()
{
    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    int[,] numArray = { { 1, 5 }, { 4, 8 } };
    
    Console.WriteLine(
        $"M = {numArray[0,0]}; N = {numArray[0,1]}. -> " + 
        GetStringWithNaturalNumbersInTheRange(numArray[0,0], numArray[0,1]));
    
    Console.WriteLine(
        $"M = {numArray[1,0]}; N = {numArray[1,1]}. -> " + 
        GetStringWithNaturalNumbersInTheRange(numArray[1,0], numArray[1,1]));
    
    Console.WriteLine("\n---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();


try
{
    Console.WriteLine(
        "This program will print natural numbers in the range " +
        "from M to N");

    Console.Write("Enter a natural number start range (M): ");
    int startNumber = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter a natural number end range (N): ");
    int endNumber = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(
        $"M = {startNumber}; N = {endNumber}. -> " +
        GetStringWithNaturalNumbersInTheRange(startNumber,endNumber));
}
catch
{
    Console.WriteLine(
        "You entered the wrong value! The value must be a natural number.");
}