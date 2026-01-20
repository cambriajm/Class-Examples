// Example1
//Cam Morgan
//RCET2265
//Spring 2026

    internal class Program
    {
        static void Main(string[] args)
        {
        //frequency note define
        int C4 = 262;
        int D4 = 294;
        int E4 = 330;
        int F4 = 349;
        int G4 = 392;


        //note duration
        int quarter = 500;//milliseconds
    
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Play song");
        Console.Beep(293,350);
        Console.Beep(293,350);
        Console.Beep(587,350);
        Console.Read();
        }
    }
