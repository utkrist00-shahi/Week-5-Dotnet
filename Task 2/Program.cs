namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.Brand = "Toyota";
            c.Speed = 120;
            c.Seats = 4;

            Motorcycle m = new Motorcycle();
            m.Brand = "Yamaha";
            m.Speed = 150;
            m.Type = "Sport";

            c.Start();
            c.DisplayInfo();
            c.Stop();

            Console.WriteLine();

            m.Start();
            m.DisplayInfo();
            m.Stop();
        }
    }
}
