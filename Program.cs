/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */

#pragma warning disable 
 
Console.Write("Введите кол-во строк: "); 
int n; 
int.TryParse(Console.ReadLine()!, out n); 
Console.Write("Введите кол-во столбцов: "); 
int m; 
int.TryParse(Console.ReadLine()!, out m); 
 
int[,] arr = new int[n, m]; 

for (int i = 0; i < n; i++) 
{ 
    for (int j = 0; j < m; j++) 
    { 
        arr[i, j] = new Random().Next(1, 10); 
        Console.Write($"{arr[i, j], -2} "); 
    } 
    Console.WriteLine(); 
} 

for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(1) - 1; k++)
            {
                if (arr[i, k] < arr[i, k + 1])
                {
                    int temp = arr[i, k + 1];
                    arr[i, k + 1] = arr[i, k];
                    arr[i, k] = temp;
                }
            }
        }
    Console.WriteLine(); }

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        Console.Write($"{arr[i, j], -2} ");
    }
    Console.WriteLine(); 
}

/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */


Console.Write("Введите кол-во строк: "); 
int n; 
int.TryParse(Console.ReadLine()!, out n); 
Console.Write("Введите кол-во столбцов: "); 
int m; 
int.TryParse(Console.ReadLine()!, out m); 
 
int[,] arr = new int[n, m]; 

for (int i = 0; i < n; i++) 
{ 
    for (int j = 0; j < m; j++) 
    { 
        arr[i, j] = new Random().Next(1, 10); 
        Console.Write($"{arr[i, j], -2} "); 
    } 
    Console.WriteLine(); 
} 

int MinSumLine = 0;
int SumLine = SumLineNumbers(arr, 0);
for (int i = 1; i < arr.GetLength(0); i++)
{
  int tempSumLine = SumLineNumbers(arr, i);
  if (SumLine > tempSumLine)
  {
    SumLine = tempSumLine;
    MinSumLine = i;
  }
}

Console.WriteLine($"\n{MinSumLine+1} - номер строки с минимальной суммой ({SumLine}) элементов ");

int SumLineNumbers(int[,] arr, int i)
{
  int sumLine = arr[i,0];
  for (int j = 1; j < arr.GetLength(1); j++)
  {
    sumLine += arr[i,j];
  }
  return sumLine;
}

/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */

Console.Write("Задайте размер матрицы: "); 
int N; 
int.TryParse(Console.ReadLine()!, out N); 
int[,] FtMartrix = new int[N, N];
int[,] SecMartrix = new int[N, N]; 
Console.WriteLine("1-я Матрица: ");
for (int i = 0; i < N; i++) 
{ 
    for (int j = 0; j < N; j++) 
    { 
        FtMartrix[i, j] = new Random().Next(1, 10); 
        Console.Write($"{FtMartrix[i, j], -2} "); 
    } 
    Console.WriteLine(); 
} 

Console.WriteLine("2-я Матрица: ");
for (int i = 0; i < N; i++) 
{ 
    for (int j = 0; j < N; j++) 
    { 
        SecMartrix[i, j] = new Random().Next(1, 10); 
        Console.Write($"{SecMartrix[i, j], -2} "); 
    } 
    Console.WriteLine(); 
} 

int[,] ResultMartrix = new int[N, N];
for (int i = 0; i < N; i++)
{
    for (int j = 0; j < N; j++)
    {
        for (int k = 0; k < N; k++)
        {
            ResultMartrix[i, j] = ResultMartrix[i, j] + (FtMartrix[i, k] * SecMartrix[k, j]);
        }
    }
}
Console.WriteLine("Результат произведение двух матриц:   ");
for (int i = 0; i < ResultMartrix.GetLength(0); i++)
{
    for (int j = 0; j < ResultMartrix.GetLength(1); j++)
    {
        Console.Write($"{ResultMartrix[i, j], -2} ");
    }
    Console.WriteLine(); 
}

/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

int[,,] array = new int[new Random().Next(2, 5), new Random().Next(2, 5), new Random().Next(2, 5)];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int k = 0; k < array.GetLength(2); k++)
        {
            array[i, j, k] = new Random().Next(10, 100);
            Console.Write($"{array[i, j, k],4} ({i}, {j}, {k})");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

int N = 4;
int M = 4;
int[,] array = new int[N, M];

int Ibeg = 0, Ifin = 0, Jbeg = 0, Jfin = 0;
int k = 1;
int i = 0;
int j = 0;

while (k <= N * M)
{
    array[i, j] = k;
    if (i == Ibeg && j < M - Jfin - 1)
        ++j;
    else if (j == M - Jfin - 1 && i < N - Ifin - 1)
        ++i;
    else if (i == N - Ifin - 1 && j > Jbeg)
        --j;
    else
        --i;

    if ((i == Ibeg + 1) && (j == Jbeg) && (Jbeg != M - Jfin - 1))
    {
        ++Ibeg;
        ++Ifin;
        ++Jbeg;
        ++Jfin;
    }
    ++k;
}


Console.WriteLine();
for (int row = 0; row < array.GetLength(0); row++)
{
    for (int col = 0; col < array.GetLength(1); col++)
    {
        Console.Write($"{array[row, col],3}");
    }
    Console.WriteLine();
}  