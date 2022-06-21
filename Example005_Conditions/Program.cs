Console.WriteLine("Enter your username: ");
string username = Console.ReadLine();

if(username.ToLower() == "maria")
{
    Console.WriteLine("Hurray! This is Maria!");
}
else
{
    Console.WriteLine("Hello, ");
    Console.WriteLine(username);
}