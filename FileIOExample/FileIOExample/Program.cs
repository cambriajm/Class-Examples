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
            
            //pause
            Console.Read();
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

        static int CountOfLinesIn(string filePath)
        {
            int count = 0;
            using (StreamReader testFile = new StreamReader(filePath))
            {
                do
                {
                    testFile.ReadLine();
                    count++;
                } while (!testFile.EndOfStream);
            }
            return count;
        }
        static string[,] FileToArray(string filePath)
        {
            int counter = 0;
            string[,] customerData = new string[4, CountOfLinesIn(filePath)];
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
                        temp[3] = temp[3].Replace("\"", "");
                        customerData[0, counter] = temp[0];
                        customerData[1, counter] = temp[1];
                        customerData[2, counter] = temp[2];
                        customerData[3, counter] = temp[3];
                        //customerData[4, counter] = temp[4];
                        //customerData[5, counter] = temp[5];
                    }

                    
                    counter++;
                } while (!testFileNO.EndOfStream);
            }
            return customerData;

        }

        static void DisplayData(string[,] data)
        {
            string formattedRow = "";

            for (int row = 0; row < data.GetLength(1); row++)
            {
            for (int column = 0; column < data.GetLength(0); column++)
            {
                   if (data[column, row] != null)
                    {
                        formattedRow += data[column, row].PadRight(14);
                    }
            }
            if(formattedRow != "")
                {
                    Console.WriteLine(formattedRow);
                }

            }
        }
    }
}
