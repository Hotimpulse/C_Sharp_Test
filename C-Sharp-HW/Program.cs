Console.WriteLine("Enter first number: ");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter second number: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo) {
	Console.WriteLine(numberOne);
}
else {
	Console.WriteLine("The bigger number is " + numberTwo);
}
