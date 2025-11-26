namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Printer myPrinter = new Printer();
                myPrinter.Print("Hello, Myself!");
                myPrinter.Print(33);
                myPrinter.Print("C# is pretty good", 3);
               
           
        }
    }
}
