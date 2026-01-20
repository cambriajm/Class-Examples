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
        int A4 = 440;
        int D5 = 587;


        //note duration
        int quarter = 500;//milliseconds
        int whole = 1000; //miliseconds
        int eighth = 250; //miliseconds 
    
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Play song");
        Console.Beep(D4, quarter);
        Console.Beep(D4, quarter);
        Console.Beep(D5, quarter);
        Console.Beep(A4, quarter);
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();

    }
    }
