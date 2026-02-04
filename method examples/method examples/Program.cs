namespace method_examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 5;
            int someNumber = 5, someOtherNumber = 7;
            //SayHello();
            //AddNumbers();
            //AddNumbers();
            //SayHello();
            //SayHello();
            //ShowCount();
            //Console.WriteLine(count);
            //count = SumOf(5, 7);
            //Console.WriteLine(count);
            //Console.WriteLine(ShowCount);
            Console.WriteLine(count);
            ChangeMyNumbers(ref count);
            Console.WriteLine(count);
            //pause
            Console.Read();
        }
        static void SayHello()
        {
            Console.WriteLine("Hello, World!");
        }

        static void AddNumbers()
        {
            Console.WriteLine($"{1+1}");
        }

        static void ShowCount()
        {
            int count = 7;
            Console.WriteLine(count);
        }

        static int SumOf(int firstNumber, int secondNumber)
        {
            
            return firstNumber + secondNumber; 
        }

        static void ChangeMyNumbers(ref int theNumber)
        {
            theNumber *= 2;
            Console.WriteLine();
        }

    }
}
