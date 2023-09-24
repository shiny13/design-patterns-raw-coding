namespace AbstractFactoryPattern;

public class Navigationbar
{
    public Navigationbar(IUIFactory factory) => factory.CreateButton();
}
