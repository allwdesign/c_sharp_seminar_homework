//Напишите программу, которая принимает на вход 
//натуральное число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

// void ProgramCheck()
// {
//     Console.WriteLine("-----------------PROGRAM CHECK-------------------");
    
//     int testNum1 = 452;
//     int testNum2 = 82;
//     int testNum3 = 9012;    
    
//     PrintSumOfDigits(testNum1);
//     PrintSumOfDigits(testNum2);
//     PrintSumOfDigits(testNum3);
//     Console.WriteLine("---------------END PROGRAM CHECK------------------");
// }

void PrintSumOfDigits(int initial_num)
{
    int n = initial_num;
    int sum = 0;
    int digit = 0;
    string msg = string.Empty;

    for (int i = 0; n > 0; i++)
    {
        digit = n%10;
        sum += digit;
        
        //Dividing the current number n by 10 will return us the
        //whole part of the division. Example: 52/10 = 5.
        n = n / 10;
 
        //Formatted information output
        if (n!= 0) msg += $"{digit} + ";
        else msg += $"{digit}";
    }
    Console.WriteLine($"Number {initial_num}: {msg} = {sum}"); 
}

//ProgramCheck();

try
{
    Console.Write("Enter N number ");
    int initial_num = Convert.ToInt32(Console.ReadLine());

    PrintSumOfDigits(initial_num);
}
catch
{
    Console.WriteLine("Something went wrong!");
}