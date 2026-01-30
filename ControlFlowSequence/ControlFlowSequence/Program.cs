
/*
 TODO:
[  ] user can quit at any time, skip remaining prompts 
[  ] get a valid number - always runs once 
[  ] get a valid number - only runs if user did not quit 
[  ] get a choice - also only runs if user did not quit
[  ] repeat the whole thing if user did not quit
*/
namespace ControlFlowSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            bool userQuit = false, validResponse = false;
            string userInput = "";


            //firstNumber
            do
            {
                Console.WriteLine("Enter your first number");
                userInput = Console.ReadLine();
                try 
                {
                    Console.WriteLine($"you entered {int.Parse(userInput)}");
                    validResponse = true;
                }
                catch(Exception)
                {
                    if (userInput == "Q" || userInput == "q") 
                    {
                        userQuit = true;
                    }
                    else
                    {
                        Console.WriteLine($"{userInput} is not a number");
                    }
                }

            } while (validResponse == false || userQuit == false);
            Console.WriteLine("end first loop");
            validResponse = false; //reset flag

            //secondNumber
            do
            {
                Console.WriteLine("Enter your second number");
                userInput = Console.ReadLine();
                try
                {
                    Console.WriteLine($"you entered {int.Parse(userInput)}");
                    validResponse = true;
                }
                catch (Exception)
                {
                    if (userInput == "Q" || userInput == "q")
                    {
                        userQuit = true;
                    }
                    else
                    {
                        Console.WriteLine($"{userInput} is not a number");
                    }
                }

            } while (validResponse == false || userQuit == false);
            Console.WriteLine("end second loop");
            validResponse = false; //reset flag

            //operationChoice
            while (validResponse == false && userQuit == false) ;
            {
                Console.WriteLine("select your operation: \n 1. Option 1\n2. Option 2\n3. Option 3");
                userInput = Console.ReadLine();

                switch (userInput) 
                {
                case "1":
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "Q":
                        userQuit = true;
                    break;
                case "q":
                        userQuit = true;
                    break;
                default:
                        Console.WriteLine("YEEHAW");
                    break;
                       
                        Console.WriteLine("end third loop");
                }

            }


            //pause
            Console.Read();
        }
    }
}
