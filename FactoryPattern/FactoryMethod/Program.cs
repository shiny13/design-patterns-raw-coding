namespace FactoryMethod;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Factory pattern with method...");
        new DropDownMenu();
        new Navigationbar();
        new AndroidDropDownMenu();
        new AndroidNavigationbar();
    }
}
