// var calclulator = new DiscountCalculator();
// var res = calclulator.CalculateDiscount(new GoldDiscount());

// class DiscountCalculator
// {
//     public int CalculateDiscount(Discount discount)
//     {
//         return discount.GetDiscount();
//         if (membershipType == "Silver")
//     }
// }

// public abstract class Discount
// {
//     public abstract int GetDiscount();
// }

// public class SilverDiscount : Discount
// {
//     public override int Get()
// }

// I

// public interface IPrinter
// {
//     void Print();
// }

// public interface IScanner
// {
//     void Scan();
// }

// public interface IFax
// {
//     void Fax();
// }

// public class Printer : IPrinter, IScanner
// {
//     public void Print()
//     {
//         System.Console.WriteLine("Printing");
//     }

//     public void Scan()
//     {
//         System.Console.WriteLine("Scanning");
//     }
// }


// D
public class GreenBulb
{
    public void TurnOn() => System.Console.WriteLine("ON");
    public void TurnOff() => System.Console.WriteLine("OFF");
}

public class Switch
{
    private readonly GreenBulb _bulb;

    public Switch(GreenBulb bulb)
    {
        _bulb = bulb;
    }

    public void SwitchOn() => _bulb.TurnOn();
    public void SwitchOff() => _bulb.TurnOff();

}