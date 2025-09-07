namespace _2_Task
{
    internal class BankAccount
    {
        private static string? AccountNumber = "2200 2113 3450 3204";
        private decimal Balance = 0m;

        public void Deposit(decimal amount)
        {
            if(amount > 0)
                this.Balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= this.Balance)
                this.Balance -= amount;
            else
                Console.WriteLine("Недостаточно средств!");
        }
        public void PrintBalance()
        {
            Console.WriteLine($"Текущий баланс: {Balance}");
        }
    }
}
