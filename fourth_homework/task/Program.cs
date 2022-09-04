//Написать программу сортировки массива от большего
//к меньшему. Массив задается размерностью N с клавиатуры,
//далее заполняется случайными целыми числами.

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

int[] FillArray(int n)
{
    int[] array = new int[n];

    //Fill the array with random numbers
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(-100, 101);
    }
    return array;
}

void SortArray(int[] numbers)
{
    //Insertion sort
    for (int i = 0; i < numbers.Length - 1; i++)
    {
        int maxPosition = i;
        int max = numbers[i];
        for (int j = i + 1; j < numbers.Length; j++)
        {
            if (numbers[j] > max) 
            {
                maxPosition = j;
                max = numbers[j];
            }
        }
        //Exchange the value of the old max and the current max
        int temp = numbers[i];
        numbers[i] = max;
        numbers[maxPosition] = temp;
    }
}

void ProgramCheck()
{
    Console.WriteLine("-----------------PROGRAM CHECK-------------------");
    
    int[] testNums1 = new int[5]{61, -62, -3, 66, -78};
    Console.WriteLine("---BEFORE SORTED---");
    PrintArray(testNums1);
    SortArray(testNums1);
    Console.WriteLine("---AFTER SORTED---");
    PrintArray(testNums1);
    
    int[] testNums2 = new int[6]{-29, -62, -28, -31, -39, -56};
    PrintArray(testNums2);
    SortArray(testNums2);
    Console.WriteLine("---AFTER SORTED---");
    PrintArray(testNums2);

    int[] testNums3 = new int[8]{44, -91, -93, -18, -83, 84, -31, 47};
    PrintArray(testNums3);
    SortArray(testNums3);
    Console.WriteLine("---AFTER SORTED---");
    PrintArray(testNums3);

    int[] testNums4 = new int[8]{44, -91, 84, -18, -83, 84, -31, 47};
    PrintArray(testNums4);
    SortArray(testNums4);
    Console.WriteLine("---AFTER SORTED---");
    PrintArray(testNums4);
    
    Console.WriteLine("---------------END PROGRAM CHECK------------------\n");
}
ProgramCheck();
try
{
    
    Console.Write("Enter N number ");
    int num = Convert.ToInt32(Console.ReadLine());
    int[] numbers = FillArray(num);

    Console.WriteLine("---BEFORE SORTED---");
    PrintArray(numbers);

    SortArray(numbers);

    Console.WriteLine("---AFTER SORTED---");
    PrintArray(numbers);

}
catch
{
    Console.WriteLine("Something went wrong!");
}
