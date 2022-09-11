//Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 
//задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
//Решаем через систему уравнений
//y = k1 * x + b1               =>  y - y = k1 * x + b1 - (k2 * x + b2)
//y = k2 * x + b2                   y = k2 * x + b2
//
//0 = k1 * x - k2 * x + b1 - b2 =>  0 = x * (k1 - k2) + b1 - b2
//y = k2 * x + b2                   y = k2 * x + b2
//
//- x * (k1 - k2) = b1 - b2     =>  x = -((b1 - b2)/(k1 - k2)) 
//y = k2 * x + b2                   y = k2 * x + b2

void GetPointOfIntersectionOfTwoLines(double b1, double k1, double b2, double k2)
{
    if (k1 == k2) Console.WriteLine("Lines do not intersect (lines are parallel)");
    else
    {
        double x = -((b1 - b2) / (k1 - k2));
        double y = k2 * x + b2;
        
        Console.WriteLine($"The point of intersection of two lines: ({x}, {y})");
    }
}


Console.WriteLine(
    "To find the intersection point of two lines given by the equations " + 
    "\n" + 
    "y = k1 * x + b1 and y = k2 * x + b2.\n"); 

Console.Write("Enter the value for b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the value for k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the value for b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter the value for k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

GetPointOfIntersectionOfTwoLines(b1, k1, b2, k2);