namespace _4_Task
{
    internal class Dice
    {
        Random random = new Random();
        public int _sides;

        public Dice(int _sides)
        {
            this._sides = _sides;
        }

        public void Roll()
        {
            Console.WriteLine($"{_sides}-гранный кубик: {random.Next(1, _sides + 1)},{random.Next(1, _sides + 1)},{random.Next(1, _sides + 1)}");
        }

    }
}
