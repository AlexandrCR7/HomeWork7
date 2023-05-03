void Main()
{
    bool isWork = true;
    while (isWork)
    {
        System.Console.WriteLine("Enter number of task");
        string command = System.Console.ReadLine();

        switch (command)
        {
            case "task 47":
                Task47();
                break;
            case "task 50":
                Task50();
                break;
            case "task 52":
                Task52();
                break;
            case "exit":
                isWork = false;
                break;
        }
    }
}


void Task47()
{
    int m = Number1Massive("Введите число m");
    int n = Number2Massive("Введите число n");
    double[,] Matrix = new double[m, n];
    Massive(Matrix);
}

void Task50()
{
    int m = Number1Massive("Введите число m");
    int n = Number2Massive("Введите число n");
    int[,] Matrix = new int[m, n];
    MassiveInt(Matrix);
    SerchNumber(Matrix);
}


void Task52()
{
    int m = Number1Massive("Введите число m");
    int n = Number2Massive("Введите число n");
    int[,] Matrix = new int[m, n];
    MassiveInt(Matrix);
    SUMM(Matrix);
}


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


void Massive(double[,] numbers)
{
        Random rnd = new Random();
        for (int i = 0; i < numbers.GetLength(0); i++)
        {
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[i, j] = Math.Round(rnd.Next(-100, 100) * 0.1, 2);
                System.Console.Write($"{numbers[i, j]} ");
            }
            System.Console.WriteLine();
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


int NumberOfIndex(string arg3)
{
    System.Console.WriteLine(arg3);
    int i;
    while (!int.TryParse(System.Console.ReadLine(), out i)) { System.Console.WriteLine("Это не число"); }
    {
        return i;
    }
}


void SerchNumber(int[,] numbers)
{
    int x = NumberOfIndex("Введите элемент для поиска в массиве");
    int summ = 0;
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            if(numbers[i, j] == x)
            {
                summ = summ + 1; 
            }
        } 
    }  
if(summ > 0)
{
    System.Console.WriteLine($"Да, кол-во упоминаний в таблице - {summ}");
}
else
{
    System.Console.WriteLine("Такого число в массиве нет");
}
}


Main();
