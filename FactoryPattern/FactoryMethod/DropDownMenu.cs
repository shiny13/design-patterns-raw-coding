namespace FactoryMethod;

public class DropDownMenu : Element
{
    protected override Button CreateButton()
    {
        var button = new Button { Type = "Default Button" };
        Console.WriteLine(button.Type);

        return button;
    }
}
