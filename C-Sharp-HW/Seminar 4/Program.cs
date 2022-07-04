/*
c/w

int [] array = {1,2,3,4,5};

Console.WriteLine($"{String.Join("; ", array)}");

int a = 5;
Console.WriteLine();
--------
int index = 1;

System.Console.WriteLine(++index);
|
|
2
-------------
TryParse

string test = "12345"; 
int result = 0;
Console.WriteLine(int.TryParse(test, out result));
Console.WriteLine(result);
|
|
$ dotnet run
True
12345
-----
string test = "fhgfhfgh"; // 12345
int result = 0;
Console.WriteLine(int.TryParse(test, out result));
Console.WriteLine(result);
|
|
$ dotnet run
False
0
-------------
Task 24
Напишите программу, которая принимает на вход число A и выдаёт сумму чисел от 1 до А.

7 - 28
4 - 10
8 - 36

int A = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int count = 0;

for (int i=1; i<=A; i++) {
    sum+=i;
    count++;
}

Console.WriteLine("Interations: " + count);

Console.WriteLine(sum);
----------
OR
----------
int A = Convert.ToInt32(Console.ReadLine());

int sum = 0;


int i = 1;
while (i <=A) {
    sum+=i;
    i++;
}

Console.WriteLine(sum);
---------
Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5

--------Solution
int number = Convert.ToInt32(Console.ReadLine());

int count = 0; 

while (number!=0) {
    number/=10;
    count++;
} 

Console.WriteLine(count);
---------
OR
--------Solution

--------
Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
4 -> 24
5 -> 120
--------#1
Console.WriteLine("Input your number");
int N = Convert.ToInt32(Console.ReadLine());

int product = 1;
for (int i=0; i < N; i++) {
    product *= i+1;
}

Console.WriteLine(product);
--------
OR
--------#2
int N = Convert.ToInt32(Console.ReadLine());

int result = 1;

for(int i = 2; i<=N; i++) {
    result*=i;
}
Console.WriteLine(result);
--------
OR
-------#3
int N = Convert.ToInt32(Console.ReadLine());

int result = 1;
int start = 1;

while(start <= N) {
    result*=start;
    start++;
}

Console.WriteLine(result);
---------

Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]

--------Solution
int[] array = new int[8];
for (int i=0; i<array.Length; i++) {
    array[i] = new Random().Next(0, 2);
    Console.WriteLine(array[i]);
}
------
OR
------
int [] array = GetBinaryArray(8);
System.Console.WriteLine($"[{String.Join("; ", array )}]");
int [] GetBinaryArray(int size) {
    int [] resultArray = new int[size];
    for (int i = 0; i < size; i++) {
        resultArray[i] = new Random().Next(2);
    }
    return resultArray;
}
---------
h/w

String str;
char[] StrChar = Str.ToCharArray();
и не важно числа или символы. Какраз таки массив символов создаётся


Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16

Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12

Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

