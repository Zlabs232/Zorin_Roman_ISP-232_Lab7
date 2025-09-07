namespace Zorin_Roman_ISP_232_Lab7
{
    internal class Player
    {
        private int health = 100;

        public void takeDamage(int damage)
        {
            if (damage > 0)
            {
                health -= damage;
                Console.WriteLine($"Персонаж получил урона: {damage}. Осталось здоровья: {health}");
            }
        }
        public int GetHealth()
        {
            return health;
        }
    }
}
