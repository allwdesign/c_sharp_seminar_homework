//Задайте массив вещественных чисел. Найдите разницу между максимальным
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double FindDifferenceBetweenMaxAndMin(double max, double min)
{
    return max-min;
}

void PrintResult(double max, double min, double difference)
{   
    Console.WriteLine($"Max element: {max}. Min element: {min}.");
    if (min < 0) Console.WriteLine($"{max} - ({min}) = {difference}");
    else Console.WriteLine($"{max} - {min} = {difference}");
}

void PrintArray(double[] array)
{
    //Formatted information output
    string msg = string.Empty;
    
    for (int i = 0; i < array.Length; i++)
    {     
        if (i!= array.Length-1) msg += $"{array[i]}, ";
        else msg += $"{array[i]}";
    }
    Console.WriteLine($"Array is: [{msg}]");
}

double[] FillArray(int n)
{
    double[] array = new double[n];

    //Fill the array with random numbers
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

double[] FindMinMaxElements(double[] numbers)
{
    double max = numbers[0];
    double min = numbers[0];
    
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max) max = numbers[i];
        else
        {
            if (numbers[i] < min) min = numbers[i];
        }
      
    }
    return new double[2]{max, min};
}

void ProgramCheck()
{
    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    
    double[] testNums1 = new double[5]{3, 7, 22, 2, 78};
    PrintArray(testNums1);
    double[] maxMinArray = FindMinMaxElements(testNums1);

    PrintResult(
        maxMinArray[0],
        maxMinArray[1],
        FindDifferenceBetweenMaxAndMin(maxMinArray[0], maxMinArray[1]));
    
    double[] testNums2 = new double[8]{44, -91, -93, -18, -83, 84, -31, 47};
    PrintArray(testNums2);
    double[] maxMinArray2 = FindMinMaxElements(testNums2);

    PrintResult(
        maxMinArray2[0],
        maxMinArray2[1],
        FindDifferenceBetweenMaxAndMin(maxMinArray2[0], maxMinArray2[1]));
        
    Console.WriteLine("\n---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();

try
{
    
    Console.Write("Enter the number of array elements: ");
    int num = Convert.ToInt32(Console.ReadLine());
    
    double[] numbers = FillArray(num);
    PrintArray(numbers);
    
    double[] maxMinArray = FindMinMaxElements(numbers);

    PrintResult(
        maxMinArray[0],
        maxMinArray[1],
        FindDifferenceBetweenMaxAndMin(maxMinArray[0], maxMinArray[1]));
}
catch
{
    Console.WriteLine("Something went wrong!");
}