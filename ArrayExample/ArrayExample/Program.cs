namespace ArrayExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int thing = 0;
            string[] fruits = new string[7]; 
            fruits[0] = "apple";
            fruits[1] = "banana";
            fruits[2] = "pear";
            fruits[3] = "pineapple";
            fruits[4] = "kiwi";
            fruits[5] = "orange";
            fruits[6] = "dragonfruit";
            //fruits[7] = "strawberry";//this will crash YIPPEE

            Console.WriteLine(fruits[3]);


                
            //pause
            Console.Read();
        }
    }
}
