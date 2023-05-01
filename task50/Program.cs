// // Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// //и возвращает значение этого элемента или же указание, что такого элемента нет.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // 17 -> такого числа в массиве нет

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

void Massive()
{
    int[,] Matrix = new int[m, n];
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
    int i = 0;
    if(numbers[i] != x)
    {
        i++;
        
    }
}

void Print()
{
    Massive();
}

Print();



// int [] Array = {1, 2, 3, 4, 5};
// int x = 7;
// int i = 0;
// while(Array[i] != x)
// {
//     i++;
// }
// System.Console.WriteLine(Array[i]);


