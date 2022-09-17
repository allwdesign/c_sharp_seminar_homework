//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18
//
//Result: { { A00*B00 + A01*B10, A00*B01 + A01*B11 },
//          { A10*B00 + A11*B10, A10*B01 + A11*B11 } }

int[,] MultiplyMatrices(int[,] matrixA, int[,] matrixB)
{
    //Matrix multiplication is possible only if the number of columns of 
    //matrix A is equal to the number of rows of matrix B.
    if (matrixA.GetLength(1) != matrixB.GetLength(0))
    {
        Console.WriteLine(
            "Matrix multiplication is possible only if " +
            "the number of columns of matrix A is equal " +
            "to the number of rows of matrix B."); 
    }

    //A - [4, 3], B - [3, 2], C(result) dimension is [4, 2].
    int[,] multiplicationResult = new int[
                                            matrixA.GetLength(0), 
                                            matrixB.GetLength(1)];
    
    for (int i = 0; i < matrixA.GetLength(0); i++)
    {
        for (int j = 0; j < matrixB.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {    
                sum += matrixA[i,k] * matrixB[k,j];
            }
            multiplicationResult[i,j] = sum;
        }
    }
    return multiplicationResult;
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

void ProgramCheck()
{
    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    
    // Two-dimensional array
    int[,] testMatrixA = { { 2, 4}, { 3, 2 } };
    int[,] testMatrixB = { { 3, 4}, { 3, 3 } };

    Console.WriteLine("Matrix A:\n");
    PrintArray(testMatrixA);

    Console.WriteLine("Matrix B:\n");
    PrintArray(testMatrixB);

    Console.WriteLine("Result:\n");
    int[,] testMatrixC = MultiplyMatrices(testMatrixA, testMatrixB);
    PrintArray(testMatrixC);
    
    Console.WriteLine("\n---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();

try
{
    // Two-dimensional array
    int[,] matrixA = { { 1, 0, 3 }, { 5, -2, 1 }, { 5, 0, 2 }, { -4, -1, 7 } };
    int[,] matrixB = { { 3, 5 }, { -1, 6 }, { 0, 7 } };

    Console.WriteLine("Matrix A:\n");
    PrintArray(matrixA);

    Console.WriteLine("Matrix B:\n");
    PrintArray(matrixB);

    Console.WriteLine("Result:\n");
    int[,] matrixC = MultiplyMatrices(matrixA, matrixB);
    PrintArray(matrixC);
}
catch
{
    Console.WriteLine("Something went wrong!");
}