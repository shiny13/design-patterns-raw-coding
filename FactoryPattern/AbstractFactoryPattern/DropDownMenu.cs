namespace AbstractFactoryPattern;

public class DropDownMenu
{
    public DropDownMenu(IUIFactory factory) => factory.CreateButton();
}
