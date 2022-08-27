//Напишите программу, которая выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет.
//В этой задаче нумерация идет слева направо.

void GetThirdDigit(int num)
{
    string stringFromNumber = Convert.ToString(num);
    
    int length = stringFromNumber.Length;

    if (length < 3)
    {
        Console.WriteLine("There is no third digit!");
    }
    else
    {
        Console.WriteLine(stringFromNumber[2]);
    }
}

Console.Write("Enter an integer  ");

try
{
    int number = Convert.ToInt32(Console.ReadLine());
    GetThirdDigit(number);
}
catch
{
    Console.WriteLine("You didn't enter a number. Please try again.");
}