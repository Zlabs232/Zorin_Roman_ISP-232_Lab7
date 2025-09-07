namespace Zorin_Roman_ISP_232_Lab7
{
    internal class Person
    {
        int age;
        public static int retirementAge = 65;

        public Person(int age)
        {
            this.age = age;
        }
        public void CheckAge()
        {
            if (age >= retirementAge)
                Console.WriteLine("Уже на пенсии");
            else
                Console.WriteLine($"До пенсии осталось: {retirementAge - age}");
            
        }
    }
}
