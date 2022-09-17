//Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
//находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
//наименьшей суммой элементов: 1 строка

int FindMinElement(int[] numbers)
{
    int min = numbers[0];
    int minPos = 0;

    for (int i = 1; i < numbers.Length; i++)
    {
        if (min > numbers[i]) 
        {
            min = numbers[i];
            minPos = i;
        }
    }
    return minPos;
}

int[] FindSumOfElementsInRow(int[,] array)
{
    int[] arrayOfSums = new int[array.GetLength(0)];

    for (int i = 0; i < array.GetLength(0); i++)
    { 
        int sumOfElementsInRow = 0;
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfElementsInRow += array[i,j]; 
        } 
        arrayOfSums[i] = sumOfElementsInRow; 
    }
    
    return arrayOfSums;
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
    Console.WriteLine();
}

int[,] FillArray(int m, int n)
{ 
    int[,] array = new int [m,n];
    for (int i = 0;i < m; i++)
    { 
        for (int j = 0;j < n; j++) array[i,j] = new Random().Next(-10, 21);  
    } 
    return array; 
}

void ProgramCheck()
{
    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    
    // Two-dimensional array
    int[,] test2DArray = { { 1, 4, 7, 2}, { 5, 9, 2, 3 },
                            { 8, 4, 2, 4 }, { 5, 2, 6, 7} };
    
    Console.WriteLine("2D Array:\n");
    PrintArray(test2DArray);

    int[] testArray = FindSumOfElementsInRow(test2DArray);

    int stringWithMinSum = FindMinElement(testArray);
    Console.WriteLine(
        $"The smallest sum of the items in a {stringWithMinSum} row.");
    
    Console.WriteLine("\n---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();

try
{
    Console.Write("Enter the number of row: ");
    int row = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter the number of column: ");
    int col = Convert.ToInt32(Console.ReadLine());

    int[,] num2DArray = FillArray(row, col);
    
    Console.WriteLine("\n2D Array:\n");
    PrintArray(num2DArray);

    int[] sumsArray = FindSumOfElementsInRow(num2DArray);

    int stringWithMinSum = FindMinElement(sumsArray);
    Console.WriteLine(
        $"The smallest sum of the items in a {stringWithMinSum} row.");
}
catch
{
    Console.WriteLine("Something went wrong!");
}