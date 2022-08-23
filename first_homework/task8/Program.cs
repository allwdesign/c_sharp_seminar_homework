Console.Write("Enter the integer number ");
int numberN = Convert.ToInt32(Console.ReadLine());
string msg = "";

for (int i=1; i<=numberN; i++)
{
    if (i % 2 == 0)
    {
        msg = msg + i + ", ";
    }
    
}

Console.WriteLine(msg);
