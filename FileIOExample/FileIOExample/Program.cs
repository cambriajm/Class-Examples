using System.Diagnostics.Metrics;

namespace FileIOExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //WriteToFile();
            //AppendToFile();
            //ReadFile();
            //ReadEntireFile("..\\..\\..\\TestFileYEEHAW.txt");
            //ReadEntireFile("..\\..\\..\\email");
            FileToArray("..\\..\\..\\email.txt");
            CountOfLine("..\\..\\..\\email.txt");
            //pause
            //Console.Read();
        }

        static void WriteToFile()
        {
            using (StreamWriter testFileNO = File.CreateText("..\\..\\..\\TestFileYEEHAW.txt"))
            {
                testFileNO.WriteLine("This is where I watched my parents die, Raphael");
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

        static void ReadEntireFile(string filePath)
        {
            using (StreamReader testFileNO = new StreamReader(filePath))
            {

                do
                {
                    Console.WriteLine(testFileNO.ReadLine());
                } while (!testFileNO.EndOfStream);


            }
        }

        static int CountOfLine(string filePath)
        {
            using (StreamReader testFileNO = new StreamReader(filePath))
            {
                int count = 0;
                testFileNO.ReadToEnd();
                do
                {
                    testFileNO.ReadLine();
                    count++;
                } while (!testFileNO.EndOfStream);

                return count;
            }

        }
        static string[,] FileToArray(string filePath)
        {
            int counter = 0;
            string[,] customerData = new string[5, CountOfLine];
            string[] temp;


            using (StreamReader testFileNO = new StreamReader(filePath))
            {
                //testFileNO.ReadToEnd();
                do
                {
                    temp = testFileNO.ReadLine().Split(",");

                    if (temp.Length == 5)
                    {
                        temp[0] = temp[0].Replace("\"$$", "");
                        temp[3] = temp[3].Replace("\""");

                        customerData[0, counter] = temp[0];
                        customerData[1, counter] = temp[1];
                        customerData[2, counter] = temp[2];
                        customerData[3, counter] = temp[3];
                        //customerData[4, counter] = temp[4];
                        //customerData[5, counter] = temp[5];
                    }

                    Console.WriteLine(temp[2]);
                    counter++;
                } while (!testFileNO.EndOfStream);
            }
            return customerData;

        }
    }
}
