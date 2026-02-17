namespace FileIOExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            WriteToFile();
            AppendToFile();
            ReadFile();
            
            //pause
            //Console.Read();
        }

        static void WriteToFile()
        {
            using (StreamWriter testFile = File.CreateText("..\\..\\..\\TestFileYEEHAW.txt"))
            {
                testFile.WriteLine("This is where I watched my parents die, Raphael");
            }
        }
        static void AppendToFile()
        {
            using (StreamWriter testFile = File.AppendText("..\\..\\..\\TestFileYEEHAW.txt"))
            {
                testFile.WriteLine("Cowabummer dude");
            
            }

        }
        static void ReadFile()
            {
                using (StreamReader testFileNO = new StreamReader("..\\..\\..\\TestFileYEEHAW.txt"))
                {
               
                Console.WriteLine(testFileNO.ReadLine());
                Console.WriteLine(testFileNO.ReadLine());
                    

                }
            }
    }
}
