namespace FactoryPattern;

public class ButtonFactory
{
    public static Button CreateButton()
    {
        var button = new Button { Type = "Default Button" };
        Console.WriteLine(button.Type);

        return button;
    }
}
