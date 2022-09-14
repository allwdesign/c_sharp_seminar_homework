//Задайте двумерный массив размером m×n, заполненный случайными вещественными 
//числами. m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] FillArrayRandomDoubleNumbers(int row, int col)
{ 
    Random random = new Random();
    double randomDoubleNumber = 0.0;
    
    double[,] array = new double [row,col];
    for (int i=0;i<row;i++)
    { 
        for (int j=0;j<col;j++) 
        {
            //Generate random double number: 3.8
            randomDoubleNumber = Math.Round(
                random.Next(-100, 100) + random.NextDouble(),
                1);
            
            array[i,j] = randomDoubleNumber;
        } 
    } 
    return array; 
} 

void PrintArray(double[,] table) 
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
    double[,] testNumsArray2D = new double[3, 4] {
                                                    { 0.5, 7, -2, -0.2 },
                                                    { 1, -3.3, 8, -9.9 },
                                                    { 8, 7.8, -7.1, 9 } };
    PrintArray(testNumsArray2D);
    
    Console.WriteLine("\n---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();

try
{
    Console.Write("Enter the number of rows in the array: ");
    int m = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the number of columns in the array: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[,] array = FillArrayRandomDoubleNumbers(m,n); 
    Console.WriteLine();
    PrintArray(array);
}
catch
{
    Console.WriteLine(
        "You entered the wrong value! The value must be a integer number");
}