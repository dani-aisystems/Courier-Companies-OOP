using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

class Program
{
    static void Main()
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
        Console.OutputEncoding = Encoding.UTF8;

        List<Courier> couriers = new List<Courier>();
        couriers.Add(new Speedy());
        couriers.Add(new Econt());
        couriers.Add(new BoxNow());

        Shipment firstShipment = new Shipment("Иван Петров", "Мария Иванова", 4, "Стандартна");
        Shipment secondShipment = new Shipment("Георги Димитров", "Петър Георгиев", 1, "Документи");
        Shipment thirdShipment = new Shipment("Елена Стоянова", "Николай Колев", 2.5, "Чуплива");
        Shipment fourthShipment = new Shipment("Димитър Илиев", "Ана Тодорова", 5.3, "Експресна");

        couriers[0].SendShipment(firstShipment);
        couriers[1].SendShipment(secondShipment);
        couriers[2].SendShipment(thirdShipment);
        couriers[0].SendShipment(fourthShipment);

        Console.WriteLine("--- Сравнение на цените за експресна пратка от 5.3 кг ---");

        foreach (Courier courier in couriers)
        {
            Console.WriteLine($"{courier.Name}: {courier.CalculatePrice(fourthShipment):F2} €");
        }

        Console.WriteLine();
        Console.WriteLine("--- Информация за фирмите ---");

        foreach (Courier courier in couriers)
        {
            courier.PrintInfo();
            Console.WriteLine();
        }
    }
}
