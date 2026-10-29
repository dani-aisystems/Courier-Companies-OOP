using System;

public class Speedy : Courier
{
    public Speedy() : base("Speedy")
    {
    }

    public override double CalculatePrice(Shipment shipment)
    {
        double price;

        switch (shipment.Type)
        {
            case "Документи":
                price = 4;
                break;
            case "Стандартна":
                price = 6;
                break;
            case "Чуплива":
                price = 9;
                break; 
            case "Експресна":
                price = 12;
                break;
            default:
                return 0;
        }

        return price + CalculateExtraFee(shipment.Weight, 2, 1.5);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine("Тарифа: Документи - 4.00 €, Стандартна - 6.00 €, Чуплива - 9.00 €, Експресна - 12.00 €");
        Console.WriteLine("Допълнителна такса: 1.50 € за всеки килограм над 2 кг");
    }
}
 