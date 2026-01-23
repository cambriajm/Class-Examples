namespace AnotherExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine($"Count: {i}");
            //}

            //for (int i = 5; i >= -5; i--)
            //{
            //    Console.WriteLine($"Count: {i}");
            //}


            int number = 1;

            //only runs if condition is true
            while (number <= 5)
            {
                Console.WriteLine($"In While Loop Number: {number}");
                number++;
            }//checks before it runs


            //always runs at least one time 
            do
            {
                Console.WriteLine($"In Do Loop Number: {number}");
                number++;
            } while (number <= 3);
            //do loop runs once if true. evaluates once. not true. wont run again 





            //pause
            Console.Read();

        }
    }
}
