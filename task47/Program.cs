﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

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


void Print()
{
    int m = Number1Massive("Введите число m");
    int n = Number2Massive("Введите число n");
    double[,] Matrix = new double[m, n];
    Massive(Matrix);
}

Print();



