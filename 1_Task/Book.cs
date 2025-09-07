namespace _1_Task
{
    internal class Book
    {
        public string? book;
        public string? author;
        public int year;
        public bool isAvailable;

        public Book()
        {
            book = "неизвестно";
            author = "неизвестно";
            year = 19;
            isAvailable = false;
        }

        public Book(string? book, string? author, int year, bool isAvailable)
        {
            this.book = book;
            this.author = author;
            this.year = year;
            this.isAvailable = isAvailable;
        }

        public void printInfo()
        {
          
            Console.WriteLine($"Книга: {book}, Автор: {author} , Год: {year} , Доступна для выдачи: {(isAvailable == true ? "Да" : "Нет")} ");
        }
    }
}
