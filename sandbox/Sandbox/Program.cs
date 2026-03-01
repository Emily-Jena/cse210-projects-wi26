using System;

class Program
{
    // static void Main(string[] args)
    // {
    //     //Console.WriteLine("Hello Sandbox World!");

    //     for (int i = 0; i < 10; i++)
    //     {
    //         Console.WriteLine(i);
    //     }
    // }

// How to write a funtion
    public static void Greeting()
    {
        Console.WriteLine("Hey Emily");
    }
// Returning a function 
    public static int AddNumbers(int n1, int n2)
    {
        return n1 + n2;
    }

// Calling a function 
static void Main(string[] args)
    {
        Greeting();
        int total = AddNumbers(10,20);
        Console.WriteLine(total);
    }
}