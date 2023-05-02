// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


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


// void SUMM(int[,] number)
// {
//         int summ = 0;
//         int i = 0;
//         for (int j = 0; j < number.GetLength(1); j++)
//         {
//             summ = summ + number[i, j];
//             if(j > number.GetLength(1))
//             {
//                 System.Console.WriteLine(summ / n);
//                 for (i = 0; i < number.GetLength(0); i++)
//                 {
//                     System.Console.WriteLine();
//                 }
//                 }
//         }
// }

void SUMM(int[,] number)
{
    int summ = 0;
    int i = 0;
    int j = 0;
    if(j < n)
    {
        summ = summ + number[i, j];
        if(j > n)
        {
            System.Console.WriteLine(summ / n);
                if(i < m)
                {
                    i++;
                }
                else{
                    System.Console.WriteLine();
                }
                }
        }
}



void Print()
{
    Massive(Matrix);
    SUMM(Matrix);
}

Print();


