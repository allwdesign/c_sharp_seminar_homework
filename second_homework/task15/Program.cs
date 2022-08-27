//Напишите программу, которая принимает на вход цифру, обозначающую
//день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

void PrintAnswer()
{
    try
    {

        int dayNumberOfTheWeek  = Convert.ToInt32(Console.ReadLine());

        if (dayNumberOfTheWeek  == 6 || dayNumberOfTheWeek == 7)
        {
            Console.WriteLine("Yes. It's a day off.");
        }
        else
        {
            Console.WriteLine("No. It's a work day.");
        }
    }
    catch
    {
        Console.WriteLine("Please enter a valid number.");
    }
}

Console.Write("Enter the number of the day of the week:  ");
PrintAnswer();

