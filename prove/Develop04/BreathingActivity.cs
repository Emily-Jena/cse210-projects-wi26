using System.Security.Cryptography;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.")
    {}

    public void BreathingActivity.Run()
    {
        int cycleTime = 10;
        int totalCycles = _duration / cycleTime;

        for (int i = 0; i < totalCycles; i++)
        {
            Console.Write("\n Breathe In... ");
            ShowCountDown(5);

            Console.Write("\n Breathe Out... ");
            ShowCountDown(5);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}