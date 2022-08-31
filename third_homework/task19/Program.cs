//Напишите программу, которая принимает на вход пятизначное 
//число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

void IsPalindrome(int n)
{
    int lastDigit = n%10;
    int secondDigitFromTheEnd = (n / 10) % 10;
    int firstDigit = n / 10000;
    int secondDigit = (n / 1000) % 10;

    if ((lastDigit == firstDigit) &
        (secondDigitFromTheEnd == secondDigit))
    {
        Console.WriteLine($"Yes. Number {n} is a palidrome.");
    }
    else Console.WriteLine($"No. Number {n} is not a palindrome.");
}

try
{
    Console.Write("Enter N number ");
    int num = Convert.ToInt32(Console.ReadLine());
    IsPalindrome(num);
}
catch
{
    Console.WriteLine("You entered an invalid number!");
}