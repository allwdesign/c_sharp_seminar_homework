//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 
//ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//-1, -7, 567, 89, 223-> 3

string[] ParseUserInput()
{
    Console.Write("Enter numbers from the keyboard separated by a space: ");
    
    string stringWithNumbers = Console.ReadLine();

    string[] stringNumbersArray = stringWithNumbers.Split(' ');
    
    return stringNumbersArray;
}

int[] convertStringsToNumbers(string[] stringNumbers)
{
    int[] numbers = new int[stringNumbers.Length];
        
    for (int i = 0; i < stringNumbers.Length; i++)
    {
        try
        {
            numbers[i] = Convert.ToInt32(stringNumbers[i]);       
        }
        catch
        {
            throw new InvalidCastException("Invalid type conversions. You entered an invalid number!");
        }
    }
    return numbers;
}

int GetQuantityOfPositiveNumbers(int[] numbers)
{
    int count = 0;
    foreach (int num in numbers) if (num > 0) ++count;   
   
    return count;
}

try
{
    //Input: user numbers
    string[] strings = ParseUserInput();

    int[] intNumbers = convertStringsToNumbers(strings);

    Console.WriteLine(
        "Quantity of positive numbers:" + 
        GetQuantityOfPositiveNumbers(intNumbers));
}
catch (InvalidCastException e)
{
    Console.WriteLine(e);
}
catch
{
    Console.WriteLine("Something went wrong!");
}
