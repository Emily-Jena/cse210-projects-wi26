public class Menu
{
    public string[] _menuItems = 
    {
        "Write", "Display", "Load", "Save", "Quit"
    }; //string list available
 
    public void DisplayMenu()
    {
        Console.WriteLine($"Select one of the following Menu options: ");

        for (int i = 0; i < _menuItems.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {_menuItems[i]}");
        }
        Console.WriteLine();
        Console.Write($"Which do you want to do: ");
    }
}