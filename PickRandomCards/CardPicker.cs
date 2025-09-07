using System.Globalization;

namespace PickRandomCards
{
    internal class CardPicker
    {
        static Random random = new Random();

        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Туз";
            if (value == 11) return "Валет";
            if (value == 12) return "Дама";
            if (value == 13) return "Король";
            return value.ToString();
        }

        private static string RandomSuit()
        {
            int value = random.Next(1,5);
            if (value == 1) return "Пик";
            if (value == 2) return "Червей";
            if (value == 3) return "Треф";
            return "Бубен";
        }
    }
}
