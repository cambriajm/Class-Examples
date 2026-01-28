namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thing = 0;
            string[] fruits = new string[7];
            string[] daysOfTheWeek = ["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"];
            int[,] grid = new int[5, 5]; 


            //fruits[0] = "apple";
            //fruits[1] = "banana";
            //fruits[2] = "pear";
            //fruits[3] = "pineapple";
            //fruits[4] = "kiwi";
            ////fruits[5] = "orange";
            ////fruits[6] = "dragonfruit";
            //////fruits[7] = "strawberry";//this will crash YIPPEE


            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(fruits[i]);
            //}

            ////same with no index or need for known length
            //foreach (string fruit in fruits)
            //{
            //    Console.WriteLine(fruit);
            //}

            //Console.WriteLine($"the length of fruits is: {fruits.Length}");

            //Console.WriteLine(fruits);


            for (int column = 0; column < 5; column++)
            {
                for (int row = 0; row < 5; row++)
                {
                    grid[column, row] = column * row;
                }
            }

                Console.WriteLine(grid[3, 3]);

            //pause
            Console.Read();
        }
    }
}
