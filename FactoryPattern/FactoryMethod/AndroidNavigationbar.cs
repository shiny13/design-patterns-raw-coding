namespace FactoryMethod;

public class AndroidNavigationbar : Element
{
    protected override Button CreateButton()
    {
        var button = new Button { Type = "Android Button" };
        Console.WriteLine(button.Type);

        return button;
    }
}
