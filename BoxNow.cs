using System;

public class BoxNow : Courier
{
    public BoxNow() : base("Box Now")
    {
    }

    public override double CalculatePrice(Shipment shipment)
    {
        double price;

        switch (shipment.Type)
        {
            case "Документи":
                price = 3;
                break;
            case "Стандартна":
                price = 5;
                break;
            case "Чуплива":
                price = 7;
                break;
            case "Експресна":
                price = 10;
                break;
            default:
                return 0;
        }

        return price + CalculateExtraFee(shipment.Weight, 2, 1);
    }

    public override void PrintInfo()
    {
        base.PrintInfo();
        Console.WriteLine("Тарифа: Документи - 3.00 €, Стандартна - 5.00 €, Чуплива - 7.00 €, Експресна - 10.00 €");
        Console.WriteLine("Допълнителна такса: 1.00 € за всеки килограм над 2 кг");
    }
}
