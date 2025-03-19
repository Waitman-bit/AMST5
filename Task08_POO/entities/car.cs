public class Car
{
    public int Id { get; private set; }
    public string Model { get; private set; }
    public double First_instant { get; private set; }
    public double Last_instant { get; private set; }
    public double Valuehour { get; private set; }
    public double Valuedaily { get; private set; }

    public Car(int id, string model, double first_instant, double last_instant, double valuehour, double valuedaily)
    {
        Id = id;
        Model = model;
        First_instant = first_instant;
        Last_instant = last_instant;
        Valuehour = valuehour;
        Valuedaily = valuedaily;
    }

    public void ExibirNota()
    {
        Console.WriteLine($"Id: {Id} ; Model: {Model} ; First_instant {First_instant} ; Last_instant {Last_instant} ; Value p/ Hour: {Valuehour} ; Value p/ day: {Valuedaily}");
    }
}
