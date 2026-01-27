namespace randomnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); // constructor

            //test randomness and range with a for loop
            for (int i = 0; i < 10; i++)
            {
            int n = rand.Next(1, 5); //random number between one and six
            
            Console.WriteLine(n);

            }

            //pause
            Console.Read();
        }
    }
}
