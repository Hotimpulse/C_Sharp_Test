/*
30th june c/w

Напишите программу, которая принимает на вход координаты точки (X и Y), 
причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.


int X = Convert.ToInt32(Console.ReadLine());
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0) {
    Console.WriteLine("1");
} if (X > 0 && Y < 0) {
    Console.WriteLine("4");
}if (X < 0 && Y < 0) {
    Console.WriteLine("3");
}if (X < 0 && Y > 0) {
    Console.WriteLine("2");
}

Задача 18: Напишите программу, которая по заданному номеру четверти, 
показывает диапазон возможных координат точек в этой четверти (x и y).
Решение в группах задач:

Console.WriteLine("Input your quarter of the axis: ");

int C = Convert.ToInt32(Console.ReadLine());

if (C==1) {
    Console.WriteLine("X > 0 && Y > 0");
} if (C==2) {
    Console.WriteLine("X > 0 && Y < 0");
}if (C==3) {
    Console.WriteLine("X < 0 && Y < 0");
}if (C==4) {
    Console.WriteLine("X < 0 && Y > 0");
}
---------------

Задача 21: Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 2D пространстве.

int x1 = Convert.ToInt32(Console.ReadLine());
int x2 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());

var distance = Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
Console.WriteLine(Math.Round(distance));
------------------
Задача 22: Напишите программу, которая принимает на вход число 
(N) и выдаёт таблицу квадратов чисел от 1 до N.
5 -> 1, 4, 9, 16, 25.
2 -> 1,4


Console.WriteLine("Enter your number to see all the squared numbers up to your number: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i=1; i <= N; i++) {
    Console.WriteLine($"Squared value of {i} = {i*i}");
}
-------
seminar 3 h/w

Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да
------------
Solution:
------------
int N = 0;
int sum = 0;
int reverse = 0;
int temp = 0;
Console.WriteLine("Enter your 5-digit number to see if it's a palindrome or not: ");
N = int.Parse(Console.ReadLine());
temp = N;
while (N > 0) {
    reverse = N % 10;
    sum = (sum * 10) + reverse;
    N = N / 10;
}
if (temp == sum) {
    Console.WriteLine($"{true}, your number is a palindrome.");
}else{
    Console.WriteLine($"{false}, your number is not a palindrome.");
}
----------
Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53
------------
Solution:
------------
Console.WriteLine("Find the distance between two points in 3D space.");
Console.WriteLine("Input x,y,z coordinates for point A (one by one). After each value - press enter: ");
int x1 = Convert.ToInt32(Console.ReadLine());
int y1 = Convert.ToInt32(Console.ReadLine());
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input x,y,z coordinates for point B (one by one). After each value - press enter: ");
int x2 = Convert.ToInt32(Console.ReadLine());
int y2 = Convert.ToInt32(Console.ReadLine());
int z2 = Convert.ToInt32(Console.ReadLine());

double distance = Math.Sqrt((Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)) + (Math.Pow(z2 - z1, 2))));
Console.WriteLine($"The distance between A and B in 3D space is: {Math.Round(distance, 2)}");
----
Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
------------
Solution:
------------
Console.WriteLine("Enter your number to see all the cubic values of numbers up to your number: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i=1; i <= N; i++) {
    Console.WriteLine($"Squared value of {i} = {i*i*i}");
}
*/









