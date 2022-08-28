//Напишите программу, считывающую с пользовательского ввода целое
//число n (неотрицательное), выводящее это число в консоль вместе
//с правильным образом изменённым словом "программист", для того,
//чтобы робот мог нормально общаться с людьми, например:
//1 программист, 2 программиста, 5 программистов.
//В комнате может быть очень много программистов. Проверьте, что
//ваша программа правильно обработает все случаи, как минимум
//до 1000 человек

string CheckForNumber(int number)
{   
    //1 программист
    //2 программиста
    //5 программистов
    //21 программист
    //22 программиста
    //100 программистов
    //111 программистов
    //101 программист
    //150 программистов
    //151 программист
    //200 программистов
    //201 программист
    //999 программистов
    
    string end = string.Empty;
        
    //N-significant (N > 2) number of the type: 
    //111, 211, 1111, 11111 ending in 11. 
    if (number % 100 == 11) number = number % 100;
    
    //2-significant number 
    if (number > 19) number = number % 10;

    //0 или от 5 до 19
    if ((number <= 19 && number >= 5) || (number == 0)) end = "ов";
    
    //от 2 до 4 включительно
    else if (number < 5 && number > 1) end = "а";
    else
    {
        //number = 1
        end = string.Empty;
    }
    return end;
}

string GetСorrectPlural(int number)
{
    string endString = string.Empty;
    endString = CheckForNumber(number);
    return endString;
}

void PrintMessage(int number)
{
    string word = "программист";
    string ending = GetСorrectPlural(number);

    Console.WriteLine($"{number} {word}{ending}");
}

// void ProgramCheck()
// {
//     Console.WriteLine("-----------------PROGRAM CHECK-------------------");
//     for (int i = 0; i <= 1000; i++)
//     {
//         PrintMessage(i); 
//     }
// }

// ProgramCheck();

Console.Write("Enter the number:  ");

try
{   
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 0)
    {
        throw new ArgumentException("You enter a number less than zero!");
    }
    PrintMessage(number);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}
catch
{
    Console.WriteLine("You didn't enter a number!");
}