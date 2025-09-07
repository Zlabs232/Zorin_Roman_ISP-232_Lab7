namespace Zorin_Roman_ISP_232_Lab7
{
    internal class television
    {
        private int volume = 100;

        public void SetVolume(int newVolume)
        {
            if (newVolume <= 100 && newVolume >= 0)
            {
                volume = newVolume;
                Console.WriteLine($"Громкость изменена: {volume}");
            }
            else
                Console.WriteLine($"Громкость должна быть от 0 до 100.");
        }
    }
}
