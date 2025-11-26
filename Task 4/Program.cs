namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            Bike bike = new Bike();

           car.StartEngine();
           car.StopEngine();
           car.Display();

           bike.StartEngine();
           bike.StopEngine();
           bike.Display();

        }
    }
}
