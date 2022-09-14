//Напишите программу, которая на вход принимает позиции элемента в двумерном
//массиве, и возвращает значение этого элемента или же указание, что такого 
//элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

void CheckIfElementExists(int[,] numbers, int[] indexes)
{
    string msg = string.Empty;
    int row = indexes[0];
    int col = indexes[1];
    try
    {
        Console.WriteLine(
            $"Elements of the array[{row}, {col}]: {numbers[row, col]}");
    }
    catch (IndexOutOfRangeException)
    {
        Console.WriteLine(
            $"IndexOutOfRange array[{row}, {col}]: There is no such number in the array!");
    }
}

int[,] FillArrayRandomNumbers()
{ 
    Random random = new Random();
    
    //Set the number of rows in the array
    int row = random.Next(2, 6);
    //Set the number of columns in the array
    int col = random.Next(2, 6);
        
    int[,] array = new int [row,col];
    
    for (int i=0;i<row;i++)
    { 
        for (int j=0;j<col;j++) array[i,j] = random.Next(-10, 11);
    } 
    return array; 
} 

void PrintArray(int[,] table) 
{ 
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i,j] + "\t" ); 
        } 
        Console.WriteLine(); 
    } 
}

int[] ConvertStringsToNumbers(string[] stringNumbers)
{
    int[] numbers = new int[stringNumbers.Length];
        
    for (int i = 0; i < stringNumbers.Length; i++)
    {
        try
        {
            numbers[i] = Convert.ToInt32(stringNumbers[i]);       
        }
        catch
        {
            throw new InvalidCastException("Invalid type conversions. You entered an invalid number!");
        }
    }
    return numbers;
}

string[] ParseUserInput()
{
    string[] stringNumbersArray = new string[2];
    // string stringWithNumbers = string.Empty;
    
    Console.Write(
            "Enter the position of an element in a 2D " +
            "array separated by a space: ");
        
    string? stringWithNumbers = Console.ReadLine();
    
    if (stringWithNumbers is null) throw new ArgumentNullException();
    
    else stringNumbersArray = stringWithNumbers.Split(' ');
        
    return stringNumbersArray;
}

void ProgramCheck()
{
    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    
    // Two-dimensional array
    int[,] testNumsArray2D = new int[3, 4] {
                                                    { 1, 4, 7, 2 },
                                                    { 5, 9, 2, 3 },
                                                    { 8, 4, 2, 4 } };
    PrintArray(testNumsArray2D);

    int[] testIndexes =  new int[2] {1, 7};

    Console.WriteLine();

    CheckIfElementExists(testNumsArray2D, testIndexes);
    
    Console.WriteLine("\n---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();

try
{
    int[,] array = FillArrayRandomNumbers(); 
    Console.WriteLine();
    PrintArray(array);
 
    //Input: the indexes of the desired element of the 2D array. Example: 1 7
    int[] indexes = ConvertStringsToNumbers(ParseUserInput());

    CheckIfElementExists(array, indexes);

}
catch (ArgumentNullException e)
{
    Console.WriteLine(e);
}
catch (InvalidCastException e)
{
    Console.WriteLine(e);
}
catch
{
    Console.WriteLine(
        "You entered the wrong value! The value must be a integer number");
}