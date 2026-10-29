using System;
using System.Collections.Generic;

public class Courier
{
    private string name;
    private List<Shipment> shipments;

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public List<Shipment> Shipments
    {
        get { return shipments; }
        set { shipments = value; }
    }

    public Courier(string name)
    {
        this.name = name;
        this.shipments = new List<Shipment>();
    }

    public void SendShipment(Shipment shipment)
    {
        double price = CalculatePrice(shipment);

        if (price == 0)
        {
            Console.WriteLine("Пратката не може да бъде изпратена!");
            Console.WriteLine();
            return;
        }

        this.shipments.Add(shipment);

        Console.WriteLine($"Куриерска фирма: {this.name}");
        Console.WriteLine($"Подател: {shipment.Sender}");
        Console.WriteLine($"Получател: {shipment.Receiver}");
        Console.WriteLine($"Вид пратка: {shipment.Type}");
        Console.WriteLine($"Тегло: {shipment.Weight} кг");
        Console.WriteLine($"Цена за доставка: {price} €");
        Console.WriteLine("Пратката е изпратена успешно!");
        Console.WriteLine();
    }

    public virtual double CalculatePrice(Shipment shipment)
    {
        return 0;
    }

    public virtual void PrintInfo()
    {
        Console.WriteLine($"Куриерска фирма: {this.name}");
        Console.WriteLine($"Брой пратки: {this.shipments.Count}");

        foreach (Shipment shipment in this.shipments)
        {
            Console.WriteLine($"- {shipment.Sender} -> {shipment.Receiver}, {shipment.Type}, {shipment.Weight} кг, {CalculatePrice(shipment):F2} €");
        }
    }

    protected double CalculateExtraFee(double weight, double weightLimit, double feePerKilogram)
    {
        if (weight > weightLimit)
        {
            return Math.Ceiling(weight - weightLimit) * feePerKilogram;
        }

        return 0;
    }
}
