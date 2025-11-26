namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount b = new BankAccount("utkristacc123");

            Console.WriteLine("Account: " + b.getAccountNumber());

            b.Deposit(500);
            b.Withdraw(200);

            Console.WriteLine("Balance: " + b.getBalance());
        }
    }
}
