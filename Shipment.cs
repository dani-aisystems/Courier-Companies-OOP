public class Shipment
{
    private string sender;
    private string receiver;
    private double weight;
    private string type;

    public string Sender
    {
        get { return sender; }
        set { sender = value; }
    }

    public string Receiver
    {
        get { return receiver; }
        set { receiver = value; }
    }

    public double Weight
    {
        get { return weight; }
        set { weight = value; }
    }

    public string Type
    {
        get { return type; }
        set { type = value; }
    }

    public Shipment(string sender, string receiver, double weight, string type)
    {
        this.sender = sender;
        this.receiver = receiver;
        this.weight = weight;
        this.type = type;
    }
}
