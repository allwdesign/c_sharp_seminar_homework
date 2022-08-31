//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

void PrintCubeOfNumberFrom1ToN(int n)
{
    int index = 1;
    while (index <= n)
    {
        int cube = index * index * index;
        if (index != n) Console.Write($"{cube}, ");
        else Console.Write($"{cube}");
        
        index++;
    }
    Console.WriteLine();

}

try
{
    Console.Write("Enter N number ");
    int num = Convert.ToInt32(Console.ReadLine());
    PrintCubeOfNumberFrom1ToN(num);
}
catch
{
    Console.WriteLine("You entered an invalid number!");
}