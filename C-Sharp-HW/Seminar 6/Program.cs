/*
c/w 6th seminar 
-----------
Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
---------Solution
int [] inputArray = {1, 2, 3, 4, 5};

int lastIndex = inputArray.Length - 1;
int [] resultArray = new int[inputArray.Length/2 + inputArray.Length%2];

for (int i = 0; i < resultArray.Length; i++)
{
    resultArray[i] = inputArray[i] * inputArray[lastIndex - i];
    if (i == lastIndex - i) {
        resultArray[i] = inputArray[i];
    }
    Console.WriteLine($"{resultArray[i]} ");
}
--------------+
Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
[1 2 3 4 5] -> [5 4 3 2 1]
[6 7 3 6] -> [6 3 7 6]
---------Solution #1
int[] array = GetArray(10, 0, 10);
Console.WriteLine(String.Join(" ", array));

int[] reverseArray=ReverseCopyArray(array);
Console.WriteLine(String.Join(" ", reverseArray));

ReverseArray(array);
Console.WriteLine(String.Join(" ", array));

int[] GetArray(int size, int minValue, int maxValue)
{
int[] res = new int[size];

for (int i = 0; i < size; i++)
{
    res[i] = new Random().Next(minValue, maxValue + 1); // Next(0,11) -> [0;10]
}
return res;
}
---------Solution #2

void ReverseArray(int[] inArray)
{
for (int i = 0; i < inArray.Length / 2; i++)
{
int temp = inArray[i];
inArray[i] = inArray[inArray.Length - i - 1];
inArray[inArray.Length - i - 1] = temp;
}
}
---------Solution #3
int[] ReverseCopyArray(int[] inArray)
{
int[] result = new int[inArray.Length];
for (int i = 0; i < inArray.Length; i++)
{
result[i] = inArray[inArray.Length - 1 - i];

}
return result;
}
--------------
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
может ли существовать треугольник с сторонами такой длины.
int firstSide = 3;
int secondSide = 4;
int thirdSide = 5;

if (firstSide + secondSide > thirdSide && ) {

}
--------
Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
---------Solution
int N = 10;
int firstElement = 0;

int secondElement = 1;

Console.WriteLine(firstElement);
Console.WriteLine(secondElement);

for (int i = 3; i <= N; i++)
{
    int nextElement = firstElement + secondElement;
    Console.WriteLine(nextElement);
    firstElement = secondElement;
    secondElement = nextElement;
}
-----------
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
---------Solution
void Binary(int number) {
    string errorResult = "";
    string result = "";
    while (number > 0) {
        result = number%2 + result;
        errorResult = errorResult + number%2;
        number/=2;
    }
    Console.WriteLine(result);
    Console.WriteLine("Wrong result: " + errorResult);
}

int inputNumber = Convert.ToInt32(Console.ReadLine());
Binary(inputNumber);
-------------
H/W
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223 -> 4
---------Solution
Console.WriteLine("Enter a bunch of numbers, separated by commas to see how many are positive: ");
int [] array = Array.ConvertAll(Console.ReadLine().Split(","), int.Parse);
int count = 0;
Console.WriteLine($"Your array is: [{String.Join("; ", array)}]");

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0) {
        count++;
    }
}
Console.WriteLine($"The amount of positive numbers in the array is: {count}");
---------
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
---------Solution
Console.WriteLine("Enter 4 numbers corresponding to the coordinates that make up two lines.\n Press enter after each number: ");


double b1 = Convert.ToInt32(Console.ReadLine());
double b2 = Convert.ToInt32(Console.ReadLine());
double k1 = Convert.ToInt32(Console.ReadLine());
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (b2-b1)/(k1-k2);
double y = k1*(b2-b1)/(k1-k2)+b1;
Console.WriteLine($"Your point of intersection is: ({x}; {y})");
---------
*/
