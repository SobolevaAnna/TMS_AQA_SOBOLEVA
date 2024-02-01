namespace AbstractClasses.Game;

public abstract class Base
{
    public string Name { get; set; }
    public double Price { get; set; }
    protected Base()
    {

    }
    protected Base(string name)
    {
        Name = name;
    }
    protected Base(string name, double price)
    {
        Name = name;
        Price = price;
    }

    public abstract void PrintInfo();
    public abstract bool IsExpired();
}