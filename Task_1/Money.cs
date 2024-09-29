namespace Task_1;

public class Money
{
    private int _dollars;
    private int _cents;

    public int Dollars
    {
        get => _dollars;
        set
        {
            if (value < 0)
            {
                throw new ArgumentException("Price cannot be negative");
            }
            _dollars = value;
        }
    }
    public int Cents
    {
        get => _cents;
        set
        {
            var intPart = value / 100;
            if (value < 0)
            {
                Dollars -= value % 100 == 0 ? 0 : 1;
                value -= (intPart - 1) * 100;
            }
            _cents = value % 100;
            Dollars += intPart;
        }
    }

    public Money(int dollars = 0, int cents = 0)
    {
        Dollars = dollars;
        Cents = cents;
    }
    public Money(double price)
    {
        Dollars = Convert.ToInt32(Math.Floor(price));
        Cents = Convert.ToInt32(price % 1 * 100);
    }

    public override string ToString()
    {
        return $"{Dollars}.{Cents}";
    }
}
