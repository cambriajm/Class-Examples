namespace randomnumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random(); // constructor

            //test randomness and range with a for loop
            for (int i = 0; i < 1000; i++)
            {
                //rand.Next(min, max) max is not inclusive 
            int n = rand.Next(1, 6); //random number between one and six
                
            Console.Write(n);

            }

            //pause
            Console.Read();
        }
    }
}
