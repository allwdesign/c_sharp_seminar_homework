//Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая 
//покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
void ShowQuantityOfEvenNumbersInArray(int[] numbers)
{
   int evenNumbersQuantity = 0;
   for (int i=0; i<numbers.Length; i++)
   {
        if (numbers[i] % 2 == 0) ++evenNumbersQuantity;
   }
   
   Console.WriteLine(
    $"Quantity of even numbers in array {evenNumbersQuantity}"
    ); 
}

void PrintArray(int[] array)
{
    //Formatted information output
    string msg = string.Empty;
    
    for (int i = 0; i < array.Length; i++)
    {     
        if (i!= array.Length-1) msg += $"{array[i]}, ";
        else msg += $"{array[i]}";
    }
    Console.WriteLine($"[{msg}]");
}

int[] FillArrayWithPositiveThreeDigitNumbers(int arraySize)
{
    int[] filledArray = new int[arraySize];

    //Fill the array with random positive three-digit numbers
    for (int i = 0; i < arraySize; i++)
    {
        filledArray[i] = new Random().Next(100, 1000);
    }

    PrintArray(filledArray);

    return filledArray;
}

void ProgramCheck()
{
    Console.WriteLine("-----------------PROGRAM CHECK-------------------");
    
    int[] testNums1 = new int[4]{345, 897, 568, 234};
    PrintArray(testNums1);
    ShowQuantityOfEvenNumbersInArray(testNums1);
        
    int[] testNums2 = new int[5]{268, 508, 164, 943, 168};
    PrintArray(testNums2);
    ShowQuantityOfEvenNumbersInArray(testNums2);

    int sizeOfArray  = 8;
    int[] array = FillArrayWithPositiveThreeDigitNumbers(sizeOfArray);
    ShowQuantityOfEvenNumbersInArray(array);    

    Console.WriteLine("---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();


try
{
    Console.Write("Enter the number of elements in the array ");
    int sizeOfArray  = Convert.ToInt32(Console.ReadLine());
    
    int[] array = FillArrayWithPositiveThreeDigitNumbers(sizeOfArray);
    
    ShowQuantityOfEvenNumbersInArray(array);    
}
catch
{
    Console.WriteLine("You entered an invalid number!");
}