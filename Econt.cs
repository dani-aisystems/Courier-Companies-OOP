using System;

public class Econt : Courier
{
    public Econt() : base("Econt")
    {
    }

    public override double CalculatePrice(Shipment shipment)
    {
        double price;

        switch (shipment.Type)
        {
            case "Документи":
                price = 3.5;
                break;
            case "Стандартна":
                price = 6.5;
                break;
            case "Чуплива":
                price = 8;
                break;
            case "Експресна":
                price = 11;
                break;
            default:
                return 0;
        }

        return price + CalculateExtraFee(shipment.Weight, 3, 2);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine("Тарифа: Документи - 3.50 €, Стандартна - 6.50 €, Чуплива - 8.00 €, Експресна - 11.00 €");
        Console.WriteLine("Допълнителна такса: 2.00 € за всеки килограм над 3 кг");
    }
}
