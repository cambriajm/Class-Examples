namespace expectations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int result = 0; ;

            Console.WriteLine("Please enter a number");
            userInput = Console.ReadLine();
            Console.WriteLine($"You entered {userInput}");
            result = int.Parse(userInput);
            try
            {
                result = int.Parse(userInput);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong stupid: " + ex.Message); //or stacktrace
            }
            //pause
            Console.Read();
        }
    }
}
