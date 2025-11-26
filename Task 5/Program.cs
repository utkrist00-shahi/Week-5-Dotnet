namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ElectronicStore store = new ElectronicStore();

            Laptop laptop = new Laptop("Dell", 1000m);
            SmartPhone phone = new SmartPhone("iPhone", 1299m);

            store.AddDevice(laptop);
            store.AddDevice(phone);

            store.ShowAllDeviceDetails();
        }
    }
}
