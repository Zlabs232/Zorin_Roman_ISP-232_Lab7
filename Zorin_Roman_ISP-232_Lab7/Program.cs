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
    }
}
