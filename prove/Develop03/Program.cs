using System;

class Program
{
    static void Main(string[] args)
    {
        Word myWord= new Word("Testing");
        Console.WriteLine(myWord.GetwordString());

        myWord.HideWord();
        Console.WriteLine(myWord.GetwordString());
// --------------------------------------------------
        Word myWord2= new Word("Moroni,;:");
        Console.WriteLine(myWord2.GetwordString());

        myWord2.HideWord();
        Console.WriteLine(myWord2.GetwordString());
    }
}