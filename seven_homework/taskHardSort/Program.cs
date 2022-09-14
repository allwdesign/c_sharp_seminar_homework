//Задайте двумерный массив из целых чисел. Количество строк и столбцов задается
//с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху 
//вниз.
//Например, задан массив:
//1 4 7 2
//5 9 10 3
//После сортировки
//1 2 3 4
//5 7 9 10

void SortArray(int[] numbers)
{
    //Insertion sort
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int minPosition = i;
        int min = numbers[i];
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (min > numbers[j]) 
            {
                //New min
                minPosition = j;
                min = numbers[j];
            }
        }
        //Exchange the value of the old max and the current max
        int temp = numbers[i];
        numbers[i] = min;
        numbers[minPosition] = temp;
    }
}

int[,] Pack2dArray(int[] array, int m, int n)
{
    int k=0;
    int[,] array2D = new int[m, n];
    for (int i = 0; i < m; i++)
    {   
        for (int j = 0; j < n; j++)
        {
            if (k < array.Length)
            {
                array2D[i,j] = array[k];
                k += 1;
            }       
        }         
    }
    return array2D;
}

int[] Unpack2dArray(int[,] array)
{
    int size1DArray = array.GetLength(0) * array.GetLength(1);
    int[] array1D = new int[size1DArray];
    int k=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {   
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (k < size1DArray)
            {
                array1D[k]  = array[i,j];
                k += 1;
            }
        }         
    }
    return array1D;
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
    int[,] testNumsArray2D = new int[2, 4] {
                                            { 1, 4, 7, 2 },
                                            { 5, 9, 10, 3 }};
    PrintArray(testNumsArray2D);

    Console.WriteLine();
    int[] testArr = Unpack2dArray(testNumsArray2D);

    SortArray(testArr);
    
    PrintArray(Pack2dArray(
        testArr, 
        testNumsArray2D.GetLength(0),
        testNumsArray2D.GetLength(1)));
    
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

    Console.WriteLine();
    int[] arr = Unpack2dArray(num2DArray);

    SortArray(arr);
    
    PrintArray(Pack2dArray(
        arr, 
        num2DArray.GetLength(0),
        num2DArray.GetLength(1)));
}
catch
{
    Console.WriteLine("You entered an invalid number!");
}