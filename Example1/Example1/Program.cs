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
        int G4S = 415;
        int B3 = 246;
        int A3S = 233;


        //note duration
        int quarter = 500;//milliseconds
        int whole = 1000; //miliseconds
        int eighth = 250; //miliseconds 
        int sixteenth = 125; //miliseconds
    
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Play song");
        Console.Beep(D4, sixteenth);
        Console.Beep(D4, sixteenth);
        Console.Beep(D5, eighth);
        Console.Beep(A4, eighth);
        Console.Beep(G4S, eighth);
        Console.Beep(G4, eighth);
        Console.Beep(F4, eighth);
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();
        Console.Beep();

    }
    }
