//Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int FindSumOfElementsInOddPositions(int[] array)
{
    int sumOfElementsInOddPositions = 0;
    for (int i = 0; i < array.Length; i++)
    { 
        if (i % 2 != 0) sumOfElementsInOddPositions += array[i];
    }
    return sumOfElementsInOddPositions;
}

string GetAStringWithArrayElements(int[] array)
{
    //Formatted information output
    string msg = string.Empty;
    for (int i = 0; i < array.Length; i++)
    { 
        if (i!= array.Length-1) msg += $"{array[i]}, ";
        else msg += $"{array[i]}";
    }
    return msg;
}
void PrintResult(string stringWithArrayElements, int sum)
{
    Console.WriteLine(
        $"Array is: [{stringWithArrayElements}]. " +
        $"The sum of elements in odd positions is: {sum}.");
}

int[] FillArrayWithRandomNumbers(int arraySize)
{
    int[] filledArray = new int[arraySize];

    //Fill the array with random numbers
    for (int i = 0; i < arraySize; i++)
    {
        filledArray[i] = new Random().Next(-100, 100);
    }
    return filledArray;
}

void ProgramCheck()
{
    Console.WriteLine("-----------------PROGRAM CHECK-------------------\n");
    
    int[] testNums1 = new int[4]{3, 7, 23, 12};
    PrintResult(
        GetAStringWithArrayElements(testNums1),
        FindSumOfElementsInOddPositions(testNums1));
    
    int[] testNums2 = new int[4]{-4, -6, 89, 6};
    PrintResult(
        GetAStringWithArrayElements(testNums2),
        FindSumOfElementsInOddPositions(testNums2));
        
    int[] testNums3 = new int[5]{61, -62, -3, 66, -78};
    PrintResult(
        GetAStringWithArrayElements(testNums3),
        FindSumOfElementsInOddPositions(testNums3));

    int[] testNums4 = new int[2]{-98, 21};
    PrintResult(
        GetAStringWithArrayElements(testNums4),
        FindSumOfElementsInOddPositions(testNums4));
    
    Console.WriteLine("\n---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();

try
{
    Console.Write("Enter the number of elements in the array ");
    int sizeOfArray = Convert.ToInt32(Console.ReadLine());
    
    int[] array = FillArrayWithRandomNumbers(sizeOfArray);
      
    PrintResult(
        GetAStringWithArrayElements(array),
        FindSumOfElementsInOddPositions(array));
}
catch
{
    Console.WriteLine("You entered an invalid number!");
}