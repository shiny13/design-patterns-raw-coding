namespace FactoryMethod;

public class Navigationbar : Element
{
    protected override Button CreateButton()
    {
        var button = new Button { Type = "Default Button" };
        Console.WriteLine(button.Type);

        return button;
    }
}
