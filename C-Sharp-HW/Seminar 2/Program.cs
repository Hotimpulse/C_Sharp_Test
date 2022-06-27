/* print a random number from an array [10,99] and show the biggest number in that number

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
//
int firstNumber = Convert.ToInt32(Console.Readline());
int secondNumber = Convert.ToInt32(Console.Readline());

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
*/
