//Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
//элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

double[] AvgInColumn(int[,] table) 
{ 
    double[] result = new double [table.GetLength(1)];

    for (int j = 0; j < table.GetLength(1); j++)
    {
        int sum = 0;
        double avgInColumn = 0.0;
        
        for (int i = 0; i < table.GetLength(0); i++)
        {
            sum += table[i,j]; 
        }
        avgInColumn = (double)sum / table.GetLength(0);
        avgInColumn = Math.Round(avgInColumn, 1, MidpointRounding.ToZero);
        
        result[j] = avgInColumn;
    }
    return result; 
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

void ProgramCheck()
{
    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    
    // Two-dimensional array
    int[,] testNumsArray2D = new int[3, 4] {
                                            { 1, 4, 7, 2 },
                                            { 5, 9, 2, 3 },
                                            { 8, 4, 2, 4 } };
    PrintArray(testNumsArray2D);

    Console.WriteLine();
    
    Console.WriteLine(
        "Average for every columns: " + 
        string.Join("; ", AvgInColumn(testNumsArray2D)));
    
    Console.WriteLine("\n---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();

try
{
    int[,] array = FillArrayRandomNumbers(); 
    
    PrintArray(array);
    Console.WriteLine(
        "\nAverage for every columns: " + 
        string.Join("; ", AvgInColumn(array)));
}
catch
{
    Console.WriteLine("Something went wrong");
}