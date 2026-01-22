namespace ControlFlow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What score did you get?");

            //int score = userInput;

            //if (score >= 100)
            //{
            //    Console.WriteLine("Great! 100!");
            //}
            //if (score >= 90)
            //{
            //    Console.WriteLine("Excellent! You got an A!");
            //}
            //else if (score >= 70)
            //{
            //    Console.WriteLine("Pass. You did well enough.");
            //}
            //else
            //{
            //    Console.WriteLine("Ew try again");
            //}



            string userInput = "";
            int firstNumber, secondNumber;
            Console.WriteLine("Please enter a number");
            firstNumber = Console.ReadLine();


            Console.WriteLine("Please enter a number for the day of the week, 1-7");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("It's Monday. Time to start the week!");
                    break;
                case "2":
                    Console.WriteLine("It's Tuesday. Keep going!");
                    break;
                case "3":
                    Console.WriteLine("It's Wednesday. Halfway there!");
                    break;
                case "4":
                    Console.WriteLine("It's Thursday. Good luck!");
                    break;
                case "5":
                    Console.WriteLine("It's Friday.Awesome!");
                    break;
                case "6":
                    Console.WriteLine("It's Saturday. Weekend!");
                    break;
                case "7":
                    Console.WriteLine("It's Sunday. Ew next week.");
                    break;
                default:
                    Console.WriteLine("It's another day. Make it count!");
                    break;
            }

                    //pause
                    Console.ReadLine();
            
        }
    }
}
