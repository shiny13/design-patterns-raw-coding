namespace AbstractFactoryPattern;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Abstract Factory pattern...");
        new DropDownMenu(new Apple());
        new Navigationbar(new Android());
    }
}
