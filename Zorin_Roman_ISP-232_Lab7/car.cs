internal class Car
{
    public string? model;

    private int _currentSpeed;

    protected string? engineType;

    public void Accelerate(int speed)
    {
        if (speed > 0)
        {
            _currentSpeed += speed;
            Console.WriteLine($"Разгон до {_currentSpeed} км/ч");
        }
    }

    private void CheckEngine()
    {
        Console.WriteLine("Проверка двигателя..");
    }

    protected void SetEngine(string type)
    {
        engineType = type;
    }
}