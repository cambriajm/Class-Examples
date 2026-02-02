namespace ReuseableMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TestRandomNumber();
            //pause
            Console.Read();
        }

        static void TestRandomNumber()
        {
            int[] counts = new int[11];
            int max = 10, min = 5, currentNumber = 0;
            
            for (int i = 0; i < 1000; i++)
            {


                //Console.Write(RandomNumberBetween(10, 5).ToString().PadLeft(4));
                currentNumber = RandomNumberBetween(max, min);
                counts[currentNumber] += 1;

            }

            for (int i = 0; i < counts.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            //display count
            foreach (int count in counts)
            {
                Console.Write(count.ToString().PadLeft(3) + "  |");
            }

            static int RandomNumberBetween(int max, int min)
            {
                Random rand = new Random();
                int range = max - min; //get actual number range
                int randomNumber = rand.Next(range);
                randomNumber += min; //shift value back up
                randomNumber ++; 
                return randomNumber;
            }

        }
    }
}
