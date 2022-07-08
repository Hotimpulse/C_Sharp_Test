/* Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2] 
---------Solution

int[] array = {-4, -8, 8, 2};
Console.Write($"Task 32. {String.Join("; ", array)}");
for (var i = 0; i < array.Length; i++)
{
    array[i] = -array[i]; // OR // array[i]*=-1;
}
Console.WriteLine($"Reversed array is: {String.Join("; ", array)}");
---------

Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
-3; массив [6, 7, 19, 345, -3] -> да

---------Solution
int [] array = {-4, -8, 8, 2};

int number = new Random().Next(1,21); // or change for direct number
System.Console.WriteLine(number);

bool flagResult = false;

for (int i=0; i<array.Length; i++) {
    if (number == array[i]) {
        flagResult = true;
        break;
    }else{
        flagResult = false;
    }
}

if (flagResult) Console.WriteLine($"{number} element exists");
else Console.WriteLine($"Element {number} doesn't exist");
----------

Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 10, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
---------Solution
int[] array = new int[10];
int size = array.Length;
int count = 0;


for (int index = 0; index < size; index++) {
    array[index] = new Random().Next(0,1000);
    if(array[index] >=10 && array[index] <=99) {
        count++;
    }
}

Console.WriteLine($"Original array: {String.Join("; ", array)}");
Console.WriteLine($"Count of positive numbers in a given array: {count}");
--------end of cw
H/W

*Начиная с этого дз при оценке учитывается оформление и названия переменных. Будьте внимательны)
*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*Solution
int[] array = new int[4];
var count = 0;

for (int i = 0; i < array.Length; i++) {
    array[i] = new Random().Next(100,1000);
    if (array[i] % 2 == 0) {
        count++;
    }
}

Console.WriteLine($"Your array is: {String.Join("; ", array)}");
Console.WriteLine($"The amount of even numbers in the array is: {count}");
----------

*Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*Solution
int[] array = new int[5];
int oddSum = 0;

for (int i=0; i < array.Length; i++) {
    array[i] = new Random().Next(1,20);
    if (i % 2 == 1) {
        oddSum+=array[i];
    }
}

Console.WriteLine($"Your random array is: {String.Join(", ", array)}");
Console.WriteLine($"The sum of integers at uneven indices is: {oddSum}");
--------------------
*extra Задача 37: 
Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21

*Solution

*Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
[3 7 22 2 78] -> 76

*Solution
double difference = 0;
double max = 0;
double min = Double.MaxValue;
System.Console.WriteLine("Input the number of elements you want in your array (i.e. 5): ");
int numOfArray = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Input {numOfArray} real numbers. You will see the difference between the max and min values of your array.");

for (int i = 0; i < numOfArray; i++) {

    double number = Convert.ToDouble(Console.ReadLine());
    if (number >=max) {
        max = number;
    }
    if (number <= min) {
        min = number;
    }
}

difference = max - min;
Console.WriteLine($"The difference between {max} and {min} is {difference}");

*/