int Number1Massive(string arg1)
{
    System.Console.WriteLine(arg1);
    int i;
    while (!int.TryParse(System.Console.ReadLine(), out i)) { System.Console.WriteLine("Это не число"); }
    {
        return i;
    }
}

int Number2Massive(string arg2)
{
    System.Console.WriteLine(arg2);
    int j;
    while (!int.TryParse(System.Console.ReadLine(), out j)) { System.Console.WriteLine("Это не число"); }
    {
        return j;
    }
}


void MassiveInt(int[,] numbers)
{
        Random rnd = new Random();
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = rnd.Next(1, 10);
                System.Console.Write($"{numbers[i, j]} ");
            }
            System.Console.WriteLine();
        }
}


void SUMM(int[,] number)
{
    int i;
    for (int j = 0; j < number.GetLength(1); j++)
    {
        double sum = 0;
        for (i = 0; i < number.GetLength(0); i++)
        {
            sum = sum + number[i, j];
        }
        Console.Write($"{sum/i}; ");
    }
}


void Print()
{
    int m = Number1Massive("Введите число m");
    int n = Number2Massive("Введите число n");
    int[,] Matrix = new int[m, n];
    MassiveInt(Matrix);
    SUMM(Matrix);
}

Print();

