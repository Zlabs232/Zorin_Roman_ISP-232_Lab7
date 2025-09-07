namespace _3_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car2 myCar = new Car2("Tesla Model S", 250);

            myCar.Accelerate(120);
            myCar.PrintInfo(); 

            myCar.Brake();
            Console.WriteLine($"После торможения: {myCar.Speed} км/ч");
        }
    }
}
