namespace AbstractClasses.Game;
public class Product : Base
{
    public DateOnly ProductionDate;
    public DateOnly ExpirationDate; 

    public Product(string name, double price, DateOnly productionDate, DateOnly expirationDate) : base(name, price)
    {
        ProductionDate = productionDate;
        ExpirationDate = expirationDate;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Наименование товара: {Name}. Цена: {Price} руб. Дата изготовления: {ProductionDate}. Годен до: {ExpirationDate}");
    }

    public override bool IsExpired()
    {
        return DateOnly.FromDateTime(DateTime.Now) > ExpirationDate;
    }
}