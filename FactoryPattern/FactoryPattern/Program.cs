namespace FactoryPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Factory pattern...");
        new DropDownMenu();
        new Navigationbar();
    }
}
