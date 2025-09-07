namespace _1_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book fBook = new Book();
            fBook.printInfo();

            Book sBook = new("Война и мир", "Толстой", 1869, true);
            sBook.printInfo();
            

        }
    }
}
