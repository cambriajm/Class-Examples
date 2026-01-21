namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Hello, World!");
            //Console.Beep(3000, 200)
            //Console.Beep(200, 30000);

            //string userInput = "hello";

            //Console.WriteLine("Please Type Some Text");
            //userInput = Console.ReadLine();

            //Console.WriteLine($"User entered: \"{userInput}\""); //easy way
            //Console.WriteLine("User entered: " + "\"" + userInput + "\""); // harder way same thing
            
            Console.WriteLine("Hello! What is your name?");
            string userInput = Console.ReadLine();
            Console.WriteLine($"Hello {userInput}");


            Console.Read();
        }
    }
}
