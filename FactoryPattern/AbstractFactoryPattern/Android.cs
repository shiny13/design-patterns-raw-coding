namespace AbstractFactoryPattern;

public class Android : IUIFactory
{
    public Button CreateButton()
    {
        var button = new Button() { Type = "Android Button" };
        Console.WriteLine(button.Type);

        return button;
    }
}
