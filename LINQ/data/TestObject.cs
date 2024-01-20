using System.Collections;

namespace LINQ;

public class TestObject : IEnumerable<Clients>
{
    public IEnumerator<Clients> GetEnumerator()
    {
        
        var list = new List<Clients>()
        {
            new Clients(1, 2023, 03, 3),
            new Clients(2, 2023, 07, 1),
            new Clients(3, 2024, 01, 2),
            new Clients(4, 2023, 11, 1),
            new Clients(5, 2024, 02, 3),
        };

        foreach (Clients s in list)
        {
            yield return s;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}