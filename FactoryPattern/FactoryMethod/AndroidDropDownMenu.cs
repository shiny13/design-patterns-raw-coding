namespace FactoryMethod;

public class AndroidDropDownMenu : Element
{
    protected override Button CreateButton()
    {
        var button = new Button { Type = "Android Button" };
        Console.WriteLine(button.Type);

        return button;
    }
}
