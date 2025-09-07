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