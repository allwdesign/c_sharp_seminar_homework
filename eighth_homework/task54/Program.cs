//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//элементы каждой строки двумерного массива.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//В итоге получается вот такой массив:
//7 4 2 1
//9 5 3 2
//8 4 4 2

void SortArrayRowAscendingOrder(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            int maxPosition = j;
            int max = numbers[i,j]; //Old max
            
            for (int k = j + 1; k < numbers.GetLength(1); k++)
            {
                //Select the max element and rearrange it with the previous max
                if (numbers[i,k] > max) 
                {
                    maxPosition = k; //New max
                    max = numbers[i, k];
                }
            }
            //Exchange the value of the old max and the current max
            numbers[i, maxPosition] = numbers[i,j];
            numbers[i,j] = max;
        }
    }
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
    int[,] testNumsArray2D = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };

    PrintArray(testNumsArray2D);
  
    SortArrayRowAscendingOrder(testNumsArray2D);
    
    PrintArray(testNumsArray2D);
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
    
    PrintArray(num2DArray);

    SortArrayRowAscendingOrder(num2DArray);
    
    PrintArray(num2DArray);
}
catch
{
    Console.WriteLine("You entered an invalid number!");
}
