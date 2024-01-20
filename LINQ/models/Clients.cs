namespace LINQ;

public record Clients(int IdClient, int Year, int NumberMonth, int Duration)
{
    public override string ToString()
    {
        return $"IdClient: {IdClient}, Year: {Year}, NumberMonth: {NumberMonth}, Duration: {Duration}";
    }

    // Добавить только при работе со сложными объектами
    public virtual bool Equals(Clients? clients)
    {
        return (IdClient == clients.IdClient) && (Year == clients.Year) && (NumberMonth == clients.NumberMonth) && (Duration == clients.Duration);
    }
    
    // Показать пример, если не добавить эту перегрузку
    public override int GetHashCode() => HashCode.Combine(IdClient, Year, NumberMonth, Duration);
};