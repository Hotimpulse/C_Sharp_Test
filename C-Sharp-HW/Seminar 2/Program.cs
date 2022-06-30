/* 

print a random number from an array [10,99] and show the biggest digit in that number

78 -> 8
12 -> 2
85 -> 8
--------

string name = "Mark";
var date = DateTime.Now;

// Composite formatting:
Console.WriteLine("Hello, {0}! Today is {1}, it's {2:HH:mm} now.", name, date.DayOfWeek, date);
// String interpolation:
Console.WriteLine($"Hello, {name}! Today is {date.DayOfWeek}, it's {date:HH:mm} now.");
// Both calls produce the same output that is similar to:
// Hello, Mark! Today is Wednesday, it's 19:40 now.

int number = new Random().Next(10, 100); // [10,100)
 // Console.Write($"Random number - {number}"); $ - string interpolation - substitue of concatenation

int digitOne = number / 10;
int digitTwo = number % 10;

Console.WriteLine($"The number is: {number} ");
Console.WriteLine(digitOne);
Console.WriteLine(digitTwo);

int max = Math.Max(digitOne, digitTwo); // returns max of the 2 numbers
int min = Math.Min(digitOne, digitTwo);

Console.WriteLine($"The bigger number is: {max}, the smaller number is: {min}");
---------
Task 11
----------
Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
---------
int number = new Random().Next(100, 1000);
int digitOne = number / 100;
int digitThree = number % 10;

Console.WriteLine($"The number is: {number}, the two digits from start and end are: {digitOne}, {digitThree}");

----
OR another math way to solve
----

int number = new Random().Next(100, 1000);
Console.WriteLine(number);

int SearchResult (int number) {
    int first = number / 100;
    int third = number % 10;
    return first*10+third; // 4,6 - 4 десятки (от числа 46) и 6 единицы,
}
Console.WriteLine(SearchResult(number)); // function - pascale case/ if statements = camelcase;

-------
Task 12
-------
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, 
то программа выводит остаток от деления.
------
int  ran = new Random().Next(100, 1000);
int  ran1 = new Random().Next(100, 1000);
Console.WriteLine(ran);
Console.WriteLine(ran1);

if(ran1 % ran == 0) {
    Console.WriteLine($"{ran1} can be divided by {ran}");
} else {
    Console.WriteLine(ran1 % ran);
}
------------
int firstNumber = Convert.ToInt32(Console.ReadLine());
int secondNumber = Convert.ToInt32(Console.ReadLine());

if (firstNumber % secondNumber == 0) {
    Console.WriteLine("Divided with no remainder");
}else{
    Console.WriteLine($"Remainder: {firstNumber % secondNumber}");
}
---------
Task 14
---------
Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
---------
int rand = new Random().Next(1,100);
Console.WriteLine(rand);
if(rand % 7 == 0 && rand % 23 == 0) {
    Console.WriteLine($"{rand} can be divided by 7 and 23");
}else{
    Console.WriteLine("Can't be divided by 7 and 23");
}
-----
OR through a boolean function
----
bool IsMultipleOf (int number) {
    return(number % 7 == 0 && number % 23 == 0);
}

Console.WriteLine(IsMultipleOf(88));

---
seminar 2 h/w
Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1

---Solution:
Console.WriteLine("This code will show you the 2nd digit of your 3-digit number. Write your 3-digit number here: ");
int threeDigitNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your three digit number is: {threeDigitNumber}");
Console.WriteLine($"The second digit of your number is: {(threeDigitNumber / 10)%10}");
---
OR 2nd solution: added in class

string testNumber = Console.ReadLine();
Console.WriteLine($"Your third symbol of your string is: testNumber[2]");
----
string testNumber = Console.ReadLine();
Console.WriteLine($"Your third symbol of your string is: testNumber[2]");

Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

---Solution:
Console.WriteLine("Input any number and see if it has a third digit: ");
int anyNumber = Convert.ToInt32(Console.ReadLine());
if (anyNumber < 100 ) {
    Console.WriteLine("This number doesn't have a third digit.");
} else {
    Console.WriteLine($"The third digit of {anyNumber} is: {anyNumber.ToString()[2]}");
}
---
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет

---Solution:
Console.WriteLine("Input a number from 1 to 7 (corresponds to Monday-Sunday) and see if it's the weekend or not: ");
int weekNumber = Convert.ToInt32(Console.ReadLine());
if (weekNumber <= 7 && weekNumber > 5) {
    Console.WriteLine(true);
} else if (weekNumber > 7 || weekNumber == 0) {
   Console.WriteLine("This number doesn't correspond to a day of the week. Try 1-7.");
} else {
   Console.WriteLine(false);
} 

*/