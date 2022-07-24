/*
C/W - 21/07/22

----
Basic occurence - how do you exit recursion
Recursion - call the function

n! = 1..n

function

int Factorial (int n) {
    if (n == 1) return 1;
    return n * Factorial(n-1);
}

 Задайте значение N. 
Напишите программу, которая выведет 
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
------------

int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers (int start, int end) {
    if (start == end) return start.ToString(); // базовый случай - условие выхода
    return(start + ", " + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(1,N));
------------
Задача 65. Задайте значения M и N. Напишите программу, 
 которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
----------------
int M = Convert.ToInt32(Console.ReadLine());
int N = Convert.ToInt32(Console.ReadLine());

string PrintNumbers (int start, int end) {
    if (start == end) return start.ToString(); // базовый случай - условие выхода
    return(start + ", " + PrintNumbers(start + 1, end));
}
Console.WriteLine(PrintNumbers(M,N));
----------------
Задача 67: Напишите программу, которая будет принимать на вход число и 
возвращать сумму его цифр.
453 -> 12
45 -> 9
----------
Console.WriteLine("Enter any number to find out the sum of its digits: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers (int anyNumber) {
    if (anyNumber == 0) return 0;
    return (anyNumber % 10 + SumOfNumbers(anyNumber/10));
}

Console.WriteLine($"The sum of consisting digits is: " + SumOfNumbers(anyNumber));


-----------
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
------------
int anyNumber = Convert.ToInt32(Console.ReadLine());
int powerNumber = Convert.ToInt32(Console.ReadLine()); //global args

double PowerFunction (int anyNumber, int powerNumber) { // local args
    if (powerNumber == 0) return 1;
    if (powerNumber == 1) return anyNumber;
    return (anyNumber * PowerFunction(anyNumber, powerNumber-1));
}

System.Console.WriteLine(PowerFunction(anyNumber,powerNumber));
----------
H/W
|
|
Задача 64: Задайте значения M и N. Напишите программу, которая умножает все натуральные числа в промежутке от M до N.

----------Solution
Console.WriteLine("This program finds the product of all integers between the two numbers of your choice.");
Console.WriteLine("Input first number and press enter: ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input second number and press enter: ");
int secondNumber = Convert.ToInt32(Console.ReadLine());


int MultiplyFunction (int firstNumber, int secondNumber) {
    int result = firstNumber;
    Console.WriteLine("Your numbers are: ");
    if (firstNumber>=secondNumber) {
        Console.WriteLine("First number should be smaller than the second.");
        return 0;
    }
    for (int i = firstNumber; i <=secondNumber; i++)
    {
        result*=i;
        Console.Write(i + "\t");
    }
    Console.WriteLine($"The product of all the numbers between {firstNumber} and {secondNumber} is " + result);
    return 0;
}

MultiplyFunction(firstNumber,secondNumber);
----------

Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
----------Solution
Console.WriteLine("This program finds the sum between the two integers of your choice.");
Console.WriteLine("Input a starting number and press enter: ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter a second number to find the sum in between: ");
int endNumber = Convert.ToInt32(Console.ReadLine());

int SumNumbers (int startNumber, int endNumber) {
    int result = 0;
    Console.WriteLine("Your numbers are: ");
    if (startNumber>=endNumber) {
        Console.WriteLine("Make sure the first number is smaller than the second.");
        return 0;
    }
    for (int i = startNumber; i <= endNumber; i++)
    {
        result+=i;
        Console.Write(i + "\t");
    }
    Console.WriteLine($"The sum of all numbers between {startNumber} and {endNumber} is " + result);
    return 0;
}

SumNumbers(startNumber,endNumber);
----------
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 9

----------Solution
int m = 2;
int n = 3;
int AckermannFunction(int m, int n) {
    if (m == 0) {
        return n+1;
    }else if((m>0) && (n==0)){
        return AckermannFunction(m-1,1);
    }else if((m>0) && (n>0)){
        return AckermannFunction(m-1, AckermannFunction(m,n-1));
    }else{
        return n+1;
    }
}
Console.WriteLine(AckermannFunction(m,n));
----------
*/



