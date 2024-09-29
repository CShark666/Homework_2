using Task_1;

namespace Task_1;

public class Product : Money
{
    public string Name { get; }

    public Product(string name, int dollars, int cents) : base(dollars, cents)
    {
        Name = name;
    }
    public void MakeDiscount(int dollars, int cents)
    {
        Dollars -= dollars;
        Cents -= cents;
    }

    public override string ToString()
    {
        return $"Product: {Name}\nPrice: {base.ToString()}";
    }
}
