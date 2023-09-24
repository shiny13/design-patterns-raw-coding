namespace FactoryMethod;

public abstract class Element
{
    protected abstract Button CreateButton();

    public Element() => CreateButton();
}
