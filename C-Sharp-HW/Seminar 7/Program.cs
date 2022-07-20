/*
int [] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);

Console.WriteLine($"[{String.Join(";", array)}]");

Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
m = 3, n = 4.
1 4 8 19
5 -2 33 -2
77 3 8 1
------------
int rows = Int32.Parse(Console.ReadLine());
int columns = Int32.Parse(Console.ReadLine());

int [,] matrix = new int[rows,columns]; 

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = new Random().Next(0,11); //NextDouble() -> от 0 до 1
        Console.Write(matrix[i,j] + "\t"); // t - print a tab || print a new line – we use \n
    }
    Console.WriteLine();
}
------------
**Задача 48:** Задайте двумерный массив размера m на n, 
каждый элемент в массиве находится по формуле: Aₘₙ = m+n. 
Выведите полученный массив на экран.
m = 3, n = 4.
0 1 2 3
1 2 3 4
2 3 4 5
------------Solution
int[,] array = new int[4,5];
for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 5; j++)
    {
        array[i,j] = i+j;
        Console.Write(array[i,j] + "\t");
    }
    Console.WriteLine();
}
OR
int[,] matrix = new int [3,4];

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i,j] = i + j;
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
------------
**Задача 49: **Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4
------------Solution
int[,] matrix = {{1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4}};

for (int i = 0; i < matrix.GetLength(0); i++) {
    for (int j = 0; j < matrix.GetLength(1); j++) {
        if (i % 2 == 0 && j % 2 == 0) {
            matrix[i,j]*= matrix[i,j];
        }
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}
-------
OR
-------
int[,] matrix = {{1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4}};
int sum = 0;

for (int i = 0; i < matrix.GetLength(0); i++) {
    for (int j = 0; j < matrix.GetLength(1); j++) {
        if (i == j) {
            sum+=matrix[i,j];
        }
        Console.Write(matrix[i,j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine(sum);
------------
**Задача 51:** Задайте двумерный массив. 
Найдите элементы, у которых оба индекса чётные, 
и замените эти элементы на их квадраты.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Сумма элементов главной диагонали: 1+9+2 = 12
------------Solution

------------
H/W
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
------------Solution
double [,] matrixArray = new double [3,4];

for (int i = 0; i < matrixArray.GetLength(0); i++)
{
    for (int j = 0; j < matrixArray.GetLength(1); j++)
    {
        matrixArray[i,j] = Math.Round(new Random().NextDouble(), 1);

        Console.Write(matrixArray[i,j] + "\t");
    }
    Console.WriteLine();
}
------------
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
------------Solution
Console.WriteLine("Enter index position for rows: ");
int indexRows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter index position for columns: ");
int indexColumns = Convert.ToInt32(Console.ReadLine());


int[,] matrixArray = new int[3, 4] { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
Console.WriteLine("Your array is:");
for (int i = 0; i < matrixArray.GetLength(0); i++)
{
    for (int j = 0; j < matrixArray.GetLength(1); j++)
    {
        Console.Write(matrixArray[i, j] + "\t");
    }
    Console.WriteLine();
}

if (indexRows <= matrixArray.GetLength(0) && indexColumns <= matrixArray.GetLength(1)) {
    Console.WriteLine($"The element at [{indexRows};{indexColumns}] is: " + matrixArray[indexRows, indexColumns]);
}else{
    Console.WriteLine("No such element found in array.");
    return;
}
------------
Задача 52. Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
------------Solution
int rows = 3;
int columns = 4;

int [,] array = {{1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4}};

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(array[i,j] + "\t");
    }
Console.WriteLine();
}

void FindMean (int [,] array) {
    double columnTotal, average;
    for (int col = 0; col < 4; col++)
    {
        columnTotal = 0;
        for (int row = 0; row < 3; row++)
        {
        columnTotal += array[row, col];
        }
    average = Math.Round(Convert.ToDouble(columnTotal/3), 1);
    Console.WriteLine("Average: " + average);
    }
}

FindMean(array);
------------
*/


