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

int m = Number1Massive("Введите число m");
int n = Number2Massive("Введите число n");

int[,] Matrix = new int[m, n];

void Massive(int[,] Matrix)
{
        Random rnd = new Random();
        for (int i = 0; i < Matrix.GetLength(0); i++)
        {
            for (int j = 0; j < Matrix.GetLength(1); j++)
            {
                Matrix[i, j] = rnd.Next(1, 10);
                System.Console.Write($"{Matrix[i, j]} ");
            }
            System.Console.WriteLine();
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

int x = NumberOfIndex("Введите элемент для поиска в массиве");

void SerchNumber(int[,] numbers)
{
    int summ = 0;
    for(int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
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
    

void Print()
{
    Massive(Matrix);
    SerchNumber(Matrix);
}

Print();


