//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите 
//программу, которая будет построчно выводить массив, добавляя индексы каждого
//элемента.
//Массив размером 2 x 2 x 2
//66(0,0,0) 25(0,1,0)
//34(1,0,0) 41(1,1,0)
//27(0,0,1) 90(0,1,1)
//26(1,0,1) 55(1,1,1)
using System;
using System.Collections.Generic;

int[,,] FillArray(int m, int n, int l)
{ 
    Random random = new Random();
    HashSet<int> uniqueTwoDigitNumbers = new HashSet<int>();

    int[,,] array = new int [m,n,l];
    int index = 0;   
    
    while (uniqueTwoDigitNumbers.Count != array.Length)
    {
        uniqueTwoDigitNumbers.Add(random.Next(10, 100));
    }
    int[] twoDigitNumbers = uniqueTwoDigitNumbers.ToArray() ;
    
    for (int i = 0;i < m; i++)
    { 
        for (int j = 0;j < n; j++) 
        {
            for(int k=0; k < l; k++)
            {
                if (index < twoDigitNumbers.Length)
                {
                    array[i,j,k] = twoDigitNumbers[index];
                    index += 1;
                }
            }
        }  
    } 
    return array; 
}

void PrintArray(int[,,] table) 
{ 
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            for(int k=0; k < table.GetLength(2); k++) 
            {
                Console.Write($"{table[i,j,k]}({i},{j},{k})" + "\t" ); 
            }
        } 
        Console.WriteLine(); 
    }
}

void ProgramCheck()
{
    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    
    int[,,] testNumsArray3D = new int[2, 2, 2]{
                                                    { {66, 27}, {25, 90} },
                                                    { {34, 26}, {41, 55} } };

    PrintArray(testNumsArray3D);
    
    Console.WriteLine("\n---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();

try
{
    Console.Write("Enter the number of row: ");
    int row = Convert.ToInt32(Console.ReadLine());
    
    Console.Write("Enter the number of column: ");
    int col = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter the number of 3d: ");
    int el = Convert.ToInt32(Console.ReadLine());

    int[,,] numsArray3D = FillArray(row, col, el);
        
    PrintArray(numsArray3D);
}
catch
{
    Console.WriteLine("You entered an invalid number!");
}
