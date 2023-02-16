// Fig. 1.4: Program.cs
// TExt-displaying app.
using System;

class Program
{
    // Main method begins execution of C# app
    static void Main()
    {
        float r, s, p;
        //This is π
        float pi = 3.14159f;

        Console.Write("Enter Your Radius : "); // prompt user
        // read first number from user
        r = float.Parse(Console.ReadLine());

        s = pi * r * r;
        p = pi * 2 * r;

        Console.Write($"\n\to For π We Use '{pi}'");
        Console.Write($"\n\n\t| S in This Circle is : {s}");
        Console.Write($"\n\t| P in This Circle is : {p}");



        // To not close the terminal
        Console.ReadKey();
    } // Main
} // end class Program

// Made by $oh@i1