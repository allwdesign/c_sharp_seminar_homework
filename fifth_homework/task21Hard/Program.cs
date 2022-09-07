//Напишите программу, которая принимает на вход целое положительное число N
//и координаты двух точек и находит расстояние между ними в N-мерном 
//пространстве. 
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

double DistanceBetweenToPointsInNdSpace(
    double[] aCoordinates,
    double[] bCoordinates)
{
    double result = 0.00;
    double sumOfSquaresOfCoordinateDifferences = 0.00;

    for (int i = 0; i < aCoordinates.Length; i++)
    {
        sumOfSquaresOfCoordinateDifferences += Math.Pow((aCoordinates[i]- bCoordinates[i]), 2);
    }
    result = Math.Sqrt(sumOfSquaresOfCoordinateDifferences);
    return result;
}

double[] FillСoordinates(int n)
{
    double[] array = new double[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-100,101);

    }
    return array;
}

void PrintCoordinatesArray(double[] array, string pointName)
{
    //Formatted information output
    string msg = string.Empty;
    
    for (int i = 0; i < array.Length; i++)
    {     
        if (i!= array.Length-1) msg += $"{array[i]}, ";
        else msg += $"{array[i]}";
    }
    Console.WriteLine($"{pointName} point coordinates is: [{msg}]");
}

void ProgramCheck()
{
    Console.WriteLine("\n-----------------PROGRAM CHECK-------------------\n");
    
    double[] coords1 = new double[3]{3, 6, 8};
    double[] coords2 = new double[3]{2, 1, -7};
    PrintCoordinatesArray(coords1, "First");
    PrintCoordinatesArray(coords2, "Second");
    double distance = DistanceBetweenToPointsInNdSpace(coords1, coords2);
    Console.WriteLine(
        "Distance between two points in N-dimensional space is: {0:0.00}",
        distance);
    
    Console.WriteLine("\n---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();

try
{
    Console.Write("Enter N: ");
    int n = Convert.ToInt32(Console.ReadLine());

    double[] coords1 = FillСoordinates(n);
    double[] coords2 = FillСoordinates(n);

    double distance = DistanceBetweenToPointsInNdSpace(coords1, coords2);
    
    PrintCoordinatesArray(coords1, "First");
    PrintCoordinatesArray(coords2, "Second");
    Console.WriteLine(
        "Distance between two points in N-dimensional space is: {0:0.00}",
        distance);
}
catch (ArgumentException e)
{
    Console.WriteLine(e);
}
catch
{
    Console.Write("Something went wrong!");
}