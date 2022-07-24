/*
C/W - 19.07.22
Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку массива.
--------
Console.WriteLine("Enter number of rows for an array: ");
int rows = int.Parse(Console.ReadLine()); // null - link to nowhere
Console.WriteLine("Enter number of columns for an array: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter left min random number: ");
int minRandom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter right max random number: ");
int maxRandom = Convert.ToInt32(Console.ReadLine());
/// summary - method's description
/// minValue, maxValue - two variables

int[,] GetArray(int m, int n, int minValue, int maxValue) { ///-----------populate array to memory


    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintArray (int [,] inputArray) { // print array
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j] + "\t");
        }
    Console.WriteLine();
    }

}

int [,] array = GetArray(rows, columns, minRandom, maxRandom);
PrintArray(array);

void ChangeRows (int [,] matrix) {
    int indexLastRow = matrix.GetLength(0)-1;
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[0, i];
        matrix[0, i] = matrix[indexLastRow, i];
        matrix[indexLastRow, i] = temp;
    }
}

ChangeRows(array);
Console.WriteLine("Result: ");
PrintArray(array);
------------
Task 55
Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, программа должна вывести сообщение для пользователя.
------------
void PrintReverseArray (int [,] inputArray) { 
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[j,i] + "\t");
        }
    Console.WriteLine();
    }

}
Console.WriteLine("Reverse column-rows result: ");
PrintReverseArray(array);
------------
Task 59
Задайте двумерный массив из целых чисел. Напишите программу, 
которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
-----------
Console.WriteLine("Enter number of rows for an array: ");
int rows = int.Parse(Console.ReadLine()); // null - link to nowhere
Console.WriteLine("Enter number of columns for an array: ");
int columns = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter left min random number: ");
int minRandom = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter right max random number: ");
int maxRandom = Convert.ToInt32(Console.ReadLine());
/// summary - method's description
/// minValue, maxValue - two variables

    if (rows != columns) {
        Console.WriteLine("Can't flip the array, consider revising.");
        return;
}

int[,] GetArray(int m, int n, int minValue, int maxValue) // populate array to memory
{

    int[,] matrix = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

void PrintArray (int [,] inputArray) { // print array
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            Console.Write(inputArray[i,j] + "\t");
        }
    Console.WriteLine();
    }

}

int [,] array = GetArray(rows, columns, minRandom, maxRandom);
PrintArray(array);

/// task 59

int minNumber = int.MaxValue;
int indexRow = 0;
int indexColumn = 0;

for (int i = 0; i < array.GetLength(0); i++)
{   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        if (minNumber > array[i, j]) {
            minNumber = array[i, j];
            indexRow = i;
            indexColumn = j;
        }
    }
}
System.Console.WriteLine(minNumber + "\t");

void PrintMinArray (int [,] inputArray) {
    for (int i = 0; i < inputArray.GetLength(0); i++)
    {
        if (i == indexRow) continue;
        for (int j = 0; j < inputArray.GetLength(1); j++)
        {
            if (j == indexColumn) continue;
            Console.Write(inputArray[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintMinArray(array);
---------
or
---------
int rows = 3;
int columns = 3;

int [,] matrix = new int [rows, columns];

int min = int.MaxValue;
int indexRows = 0;
int indexColumns = 0;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i, j] = new Random().Next(11);
        Console.Write(matrix[i,j] + "\t");
        if (min > matrix[i,j]) {
            min = matrix[i,j];
            indexRows = i;
            indexColumns = j;
        }
    }
    Console.WriteLine();
}
Console.WriteLine("Smallest number:" + min);
Console.WriteLine("Result after deletion: ");
for (int i = 0; i < rows; i++)
{
    if (indexRows != i) {
        for (int j = 0; j < columns; j++)
        {
            if (indexColumns != j) {
                Console.Write(matrix[i,j] + "\t");
            }
        }
        Console.WriteLine();
    }
}
----------------
H/W
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

В итоге получается вот такой массив:

1 2 4 7

2 3 5 9

2 4 4 8
---------Solution

Console.WriteLine("Your unsorted array is: ");
int [,] matrix = new int [,] {{1, 4, 7, 2},{5, 9, 2, 3},{8, 4, 2, 4}};

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write(matrix[i,j] + "\t");
    }
Console.WriteLine();
}


void SortArray (int [,] matrix) {
    int [][] rows = new int[3][];
    rows[0] = new int[] {1, 4, 7, 2};
    rows[1] = new int[] {5, 9, 2, 3};
    rows[2] = new int[] {8, 4, 2, 4};

    foreach (var arrayRows in rows)
    {
        Array.Sort(arrayRows);
        foreach (var item in arrayRows)
        {
            Console.Write(item+"\t");
        }
        Console.WriteLine();
    }
}


Console.WriteLine("Your sorted array is: ");  
SortArray(matrix);
---------
Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
---------Solution
int [,] matrix = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};
for (int i = 0; i < matrix.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum += matrix[i,j];
        Console.Write(matrix[i,j] + "\t");
        
    }
    Console.WriteLine($"Sum of numbers in row #{i} is " + sum);
}

Console.WriteLine($"Lowest sum is found in row #0 = {matrix[0,0] + matrix[0,1] + matrix[0,2] + matrix[0,3]}");

---------
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

и

1 5 8 5

4 9 4 2

7 2 2 6

2 3 4 7

Их произведение будет равно следующему массиву:

1 20 56 10

20 81 8 6

56 8 4 24

10 6 24 49
---------Solution
int [,] matrixOne = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};
int [,] matrixTwo = {{1, 5, 8, 5}, {4, 9, 4, 2}, {7, 2, 2, 6}, {2, 3, 4, 7}};
Console.WriteLine("Your first array: ");
for (int i = 0; i < matrixOne.GetLength(0); i++)
{
    for (int j = 0; j < matrixOne.GetLength(1); j++)
    {
        Console.Write(matrixOne[i,j] + "\t");
    }
    Console.WriteLine();
}
Console.WriteLine("Your second array: ");
for (int i = 0; i < matrixTwo.GetLength(0); i++)
{
    for (int j = 0; j < matrixTwo.GetLength(1); j++)
    {
        Console.Write(matrixTwo[i,j] + "\t");
    }
    Console.WriteLine();
}

void MultiplyMatrix()
    {
        int [,] matrixOne = {{1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7}};
        int [,] matrixTwo = {{1, 5, 8, 5}, {4, 9, 4, 2}, {7, 2, 2, 6}, {2, 3, 4, 7}};
        int [,] matrixMultiplied = new int [4,4];
        Console.WriteLine("Multiplied array is: ");
            for (int i = 0; i < matrixOne.GetLength(0); i++)
            {
                for (int j = 0; j < matrixOne.GetLength(1); j++)
                {
                    matrixMultiplied[i,j] = matrixOne[i,j]*matrixTwo[i,j];
                    Console.Write(matrixMultiplied[i,j] + "\t");
                }
                Console.WriteLine();
            }
}
MultiplyMatrix();
---------
Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)

---------Solution
int[,,] TripleDArray = new int [2,2,2];

void print3DArray(int[,,] TripleDArray) {
    for (int i = 0; i < TripleDArray.GetLength(0); i++)
    {
        for (int j = 0; j < TripleDArray.GetLength(1); j++)
        {
            for (int k = 0; k < TripleDArray.GetLength(2); k++)
            {
                TripleDArray[i,j,k] = new Random().Next(10,100);
                Console.Write(TripleDArray[i,j,k] + $"({i},{j},{k})" + "\t");

            }
        }
           Console.WriteLine();
    }
   Console.WriteLine();
}

Console.WriteLine("Your 3D Array is: ");
print3DArray(TripleDArray);
---------
Задача 62. Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1 2 3 4

12 13 14 5

11 16 15 6

10 9 8 7
---------Solution
Console.WriteLine("Enter a number to set array bounds for a spiral array: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
int [,] SpiralArray = new int [anyNumber,anyNumber];
int count = 1;
int column1 = 0, column2 = anyNumber - 1;
while (count <= anyNumber*anyNumber) {
    for (int i = column1; i <= column2; i++)
    {
        SpiralArray[column1,i] = count++;
    }
    for (int j = column1 + 1; j <= column2; j++)
    {
        SpiralArray[j,column2] = count++;
    }
    for (int i = column2-1; i >= column1; i--)
    {
        SpiralArray[column2,i] = count++;
    }
    for (int j = column2 - 1; j >= column1 + 1; j--)
    {
        SpiralArray[j,column1] = count++;
    }
    column1++;
    column2--;
}
for (int i = 0; i < anyNumber; i++)
{
    for (int j = 0; j < anyNumber; j++)
    {
        Console.Write(SpiralArray[i,j] + "\t");
    }
    Console.WriteLine();
}
---------
*/


