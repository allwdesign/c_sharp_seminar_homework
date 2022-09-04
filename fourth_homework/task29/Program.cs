//Напишите программу, которая задаёт массив из 
//8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

// void ProgramCheck()
// {
//     Console.WriteLine("-----------------PROGRAM CHECK-------------------");
    
//     int[] testNums1 = new int[5]{1, 2, 5, 7, 19};
//     int[] testNums2 = new int[3]{6, 1, 33};
        
//     Console.Write("testNums1: ");
//     PrintArray(testNums1);
//     Console.Write("testNums2: ");
//     PrintArray(testNums2);
//     Console.WriteLine("---------------END PROGRAM CHECK------------------\n");
// }


int[] FillArray()
{
    int[] array = new int[8];
    
    //Fill the array with random numbers
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-15, 16);
    }
    return array;
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
    Console.WriteLine($"{msg}  ->  [{msg}]");
}

//ProgramCheck();

try
{
    int[] numbers = FillArray();
    PrintArray(numbers);
}
catch
{
    Console.WriteLine("Something went wrong!");
}
