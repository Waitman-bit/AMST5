class ExibirNota
{
    static void Main()
    {
        Console.Write("Digite o id do carro: ");
        int idd = int.Parse(Console.ReadLine());

        Console.Write("Digite o modelo do carro: ");
        string mod = Console.ReadLine();

        Console.Write("Digite o first instant do carro: ");
        double fi = double.Parse(Console.ReadLine());

        Console.Write("Digite o last instant do carro: ");
        double li = double.Parse(Console.ReadLine());

        Console.Write("Digite o value hour do carro: ");
        double vh = double.Parse(Console.ReadLine());

        Console.Write("Digite o value day do carro: ");
        double vd = double.Parse(Console.ReadLine());

        Car car1 = new Car(idd, mod, fi, li, vh, vd);
        car1.ExibirNota();
    }
}