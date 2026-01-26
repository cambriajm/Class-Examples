namespace SimpleCalculatorCM
//Cambria Morgan
//RCET 2265
//Spring 2026
//Simple Calculator

{
    internal class Program
    {
        static void Main(string[] args)


        {
            string userInput = "";
            int firstNumber, secondNumber, thirdNumber;

            Console.WriteLine("Please enter your first number");
            userInput = Console.ReadLine();
            firstNumber = int.Parse(userInput);
            Console.WriteLine($"You entered {firstNumber}");

            Console.WriteLine("Please enter your second number");
            userInput = Console.ReadLine();
            secondNumber = int.Parse(userInput);
            Console.WriteLine($"You entered {secondNumber}");


            Console.WriteLine("Please enter your operation, add, subtract, multiply, divide");
            userInput = Console.ReadLine();
            Console.WriteLine($"You entered {userInput}");
            switch (userInput)
            {
                case "add":
                    Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
                    break;
                case "subtract":
                    Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
                    break;
                case "multiply":
                    Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
                    break;
                case "divide":
                    Console.WriteLine($"{firstNumber} / {secondNumber} = {firstNumber / secondNumber}");
                    break;




            }






            Console.ReadLine();
        }
    }
}
