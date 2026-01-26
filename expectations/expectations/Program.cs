using System.ComponentModel.DataAnnotations;

namespace expectations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userInput = "";
            int result = 0; ;
            bool isValid = false;
            string message = "";

            do
            {
                Console.WriteLine("Please enter a number");
                Console.WriteLine("Enter \"Q\" to quit.");
                userInput = Console.ReadLine();
                Console.Clear();
                Console.WriteLine($"You entered {userInput}");

                try 
                {
                    result = int.Parse(userInput);
                    message = $"Good job {userInput} is a number";
                    isValid = true;
                }
                catch (Exception ex)
                    
                {
                    if (userInput == "Q") || userInput == "Q"
                        
                        {
                        (userInput = "Q")
                    }
                    message = $"Have a nice day!";
                    isValid = true;
                    else
                    {
                    message = $"{userInput} is not a number";
                    }
                }
                {
                    Console.WriteLine($"{userInput} is not a number " + ex.Message); //or stacktrace

                }
                
            }
            while (isValid = false);

            Console.WriteLine($"Good job, you know your numbers, {result} is a number!");

        }
    }
}
