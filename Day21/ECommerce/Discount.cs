public interface IDiscount
{
    public decimal Discount();
}

public class PercentageDiscount : IDiscount
{
    public decimal Percentage { get; set; }

    public decimal Discount
    {
        
    }
}

public class FlatDiscount : IDiscount
{
    public decimal Amount { get; set; }

    public decimal Discount
    {
        
    }
}

public class BuyOneGetOneFree : IDiscount
{
   
}
