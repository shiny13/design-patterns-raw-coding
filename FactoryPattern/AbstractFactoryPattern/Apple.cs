namespace AbstractFactoryPattern;

public class Apple : IUIFactory
{
    public Button CreateButton()
    {
        var button = new Button() { Type = "iOS Button" };
        Console.WriteLine(button.Type);

        return button;
    }
}
