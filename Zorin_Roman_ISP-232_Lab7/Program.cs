namespace Zorin_Roman_ISP_232_Lab7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Student Denis = new Student();
            Console.WriteLine(Denis);
        }
    }

    class Student
    {
        string? name;
        int age;
        string? group;

        public void PrintInfo()
        {
            Console.WriteLine($"Имя: {name}, Возраст: {age}, Группа: {group}.");
        }
    }
}
