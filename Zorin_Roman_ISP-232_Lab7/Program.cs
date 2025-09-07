namespace Zorin_Roman_ISP_232_Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student Denis = new Student();
            Console.WriteLine(Denis);

            Denis.name = "Roman";
            Denis.age = 18;
            Denis.group = "ISP-232";

            Denis.PrintInfo();

            Console.WriteLine($"Студент {Denis.name} " +
                $"совершеннолетний - {Denis.IsAdult(Denis.age)}");

            Student neighbor = new Student();

            Console.Write("Введите имя соседа: ");
            neighbor.name = Console.ReadLine();

            Console.Write("Введите возраст соседа: ");
            neighbor.age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Введите группу соседа: ");
            neighbor.group = Console.ReadLine();

            neighbor.PrintInfo();
        }
    }

    class Student
    {
        public string? name;
        public int age;
        public string? group;

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}, Группа: {group}.");
        }

        public bool IsAdult(int age)
        {
            return age >= 18;
        }
    }
}
