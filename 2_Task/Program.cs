namespace _2_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount BA = new BankAccount();
            BA.Deposit(1000);
            BA.Withdraw(500);
            BA.PrintBalance();
        }
    }
}
