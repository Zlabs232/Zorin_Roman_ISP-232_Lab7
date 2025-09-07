class Car2
{
    public string Model;
    public int Speed;
    public int MaxSpeed;

    public Car2(string model, int maxSpeed)
    {
        this.Model = model;
        this.MaxSpeed = maxSpeed;
        this.Speed = 0;
    }
    public void Accelerate(int delta)
    {
        if (delta > 0)
        {
            this.Speed += delta;
            if (this.Speed > this.MaxSpeed)
                this.Speed = this.MaxSpeed;
        }
    }
    public void Brake()
    {
        this.Speed = 0;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Модель: {this.Model}, Текущая скорость: {this.Speed} км/ч");
    }
}