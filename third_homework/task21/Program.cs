//Напишите программу, которая принимает на вход координаты двух 
//точек и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


//Change the globalization settings. So that a fractional number 
//is displayed with a dot and not with a comma.
// 43,75 -> 43.75
System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");

double DistanceBetweenToPointsIn3dSpace(double[] aCoordinates, double[] bCoordinates)
{
    double result = 0.00;
    
    double xA = aCoordinates[0];
    double yA = aCoordinates[1];
    double zA = aCoordinates[2];

    double xB = bCoordinates[0];
    double yB = bCoordinates[1];
    double zB = bCoordinates[2];
        
    result = Math.Sqrt(
            Math.Pow((xB-xA), 2) +
            Math.Pow((yB-yA), 2) +
            Math.Pow((zB-zA), 2));
 
    return result;
}

double[] GetСoordinates(string pointName)
{
    double[] array = new double[3];

    Console.WriteLine("Enter point " + pointName + " coordinates: ");

    try
    {

        double x = Convert.ToDouble(Console.ReadLine());
        double y = Convert.ToDouble(Console.ReadLine());
        double z = Convert.ToDouble(Console.ReadLine());

        array[0] = x;
        array[1] = y;
        array[2] = z;
    }
    catch
    {
        throw new ArgumentException("You entered the wrong coordinates!");
    }
    return array;
}

try
{
    double[] pointACoordinates = GetСoordinates("A");
    double[] pointBCoordinates = GetСoordinates("B");

    double distance = DistanceBetweenToPointsIn3dSpace(
        pointACoordinates,
        pointBCoordinates);

    Console.WriteLine("{0:0.00}", distance);
}
catch (ArgumentException e)
{
    Console.WriteLine(e);
}
catch
{
    Console.Write("Something went wrong!");
}