namespace PickRandomCards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во карт для выбора: ");
            string? line = Console.ReadLine();

            if (int.TryParse(line, out int numberOfCards))
            {
                foreach (string card in CardPicker.PickSomeCards(numberOfCards))
                {
                    Console.WriteLine($"Карта: {card}");
                }
            }
            else
                Console.WriteLine("Введите корректное число.");
        }
    }
}
