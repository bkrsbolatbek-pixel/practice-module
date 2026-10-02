public class Train
{
    public string Number { get; set; }
    public List<string> Stations { get; set; } = new();
    public decimal Price { get; set; }
}

public class Invoice
{
    public string Details { get; set; }
    public decimal Amount { get; set; }
    public int IsPaid { get; set; } = 0; // 0 - не оплачен, 1 - оплачен
}

public class Cashier
{
    public Train AddTrain(string number, List<string> stations, decimal price)
    {
        return new Train { Number = number, Stations = stations, Price = price };
    }
}

public class Passenger
{
    public Invoice SelectTrain(Train train)
    {
        return new Invoice { Details = $"Билет на поезд №{train.Number}", Amount = train.Price };
    }

    public void PayInvoice(Invoice invoice) => invoice.IsPaid = 1;
}