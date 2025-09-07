class Student
{
    public string? name;
    public int age;
    public string? group;

    public Student()
    {
        Console.WriteLine("Создание объекта Student");
        name = "Неизвестно";
        age = 18;
        group = "Неизвестно";
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {name}, Возраст: {age}, Группа: {group}.");
    }

    public bool IsAdult(int age)
    {
        return age >= 18;
    }
    public Student(string yorName) { name = yorName; age = 18; group = "Неизвестно"; }

    public Student(string yorName, int yourAge) { name = yorName; age = yourAge; group = "Неизвестно"; }

    public Student(string name, int yourAge, string yourGroup) { this.name = name; age = yourAge; group = yourGroup; }
}