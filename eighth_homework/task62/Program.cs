//Напишите программу, которая заполнит спирально массив 4 на 4. 
//Например, на выходе получается вот такой массив:
//01 02 03 04
//12 13 14 05
//11 16 15 06
//10 09 08 07

void PrintArray(int[,] table) 
{ 
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(String.Format("{0:00}", table[i,j]) + "\t" ); 
        } 
        Console.WriteLine(); 
    }
    Console.WriteLine();  
}

int[,] SpiralFillArray(int n)
{ 
    int[,] array = new int [n,n];
    int number = 1;
    
    for (int shift = 0; shift < n-2; shift++)
    {
        for (int col = shift; col < n - shift; col++) 
        {   
            array[shift,col] = number ++;  
        } 
        
        for (int row = 1 + shift; row < n - shift; row++)
        {
            array[row,n-1-shift] = number ++; 
        }
        
        for (int col = n-2-shift; col >= shift; col--) 
        {   
            array[n-1-shift, col] = number ++;  
        }
        
        for (int row = n-2-shift; row >= 1+shift; row--)
        {
            array[row,shift] = number ++;
            //Console.WriteLine($"array[{row},0]: array[row,0] \n number: {number}"); 
        } 
    }
    
    return array; 
}

void ProgramCheck()
{
    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    
    int sizeArray = 5;
    int[,] testNumsArray2D = SpiralFillArray(sizeArray);
    

    PrintArray(testNumsArray2D);
  

    Console.WriteLine("\n---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();

try
{
    int sizeArray = 4;
    int[,] numsArray2D = SpiralFillArray(sizeArray);

    PrintArray(numsArray2D);
}
catch
{
    Console.WriteLine("Something went wrong");
}

