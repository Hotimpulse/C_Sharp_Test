// Console.WriteLine("Enter first number: ");
// int numberOne = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Enter second number: ");
// int numberTwo = Convert.ToInt32(Console.ReadLine());

// if (numberOne > numberTwo) {
// 	Console.WriteLine(numberOne);
// }
// else {
// 	Console.WriteLine("The bigger number is " + numberTwo);
// }






internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("You are about to enter three numbers and find the largest. \n");

        Console.WriteLine("Enter the first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a > b && a > c)
        {
            Console.WriteLine("The largest number is " + a);
        }
        else if (b > a && b > c) {
                Console.WriteLine("The largest number is " + b);
            }
        else if (c > a && c > b) {
            Console.WriteLine("The largest number is " + c);
        }
    }
}