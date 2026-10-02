public class Car
{
    public string Number { get; set; }
    public int IsWorking { get; set; } = 1; // 1 - исправен, 0 - на ремонте
}

public class Driver
{
    public string Name { get; set; }
    public int IsSuspended { get; set; } = 0; // 0 - работает, 1 - отстранен

    public void RequestRepair(Car car) => car.IsWorking = 0;
}

public class Trip
{
    public string Route { get; set; }
    public Driver Driver { get; set; }
    public Car Car { get; set; }
    public int IsCompleted { get; set; } = 0; // 0 - в пути, 1 - завершен

    public void FinishTrip(int carIsOk) // передаем 1 (исправен) или 0 (в ремонт)
    {
        IsCompleted = 1;
        Car.IsWorking = carIsOk;
    }
}

public class Dispatcher
{
    public Trip AssignTrip(string route, Driver driver, Car car)
    {
        if (driver.IsSuspended == 1 || car.IsWorking == 0) return null;
        return new Trip { Route = route, Driver = driver, Car = car };
    }

    public void SuspendDriver(Driver driver) => driver.IsSuspended = 1;
}