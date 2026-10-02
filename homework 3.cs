public class BankAccount
{
    public decimal Balance { get; set; }
    public int IsActive { get; set; } = 1; // 1 - активен, 0 - аннулирован
}

public class CreditCard
{
    public BankAccount Account { get; set; }
    public int IsBlocked { get; set; } = 0; // 0 - активна, 1 - заблокирована
}

public class Client
{
    public BankAccount Account { get; set; }
    public CreditCard Card { get; set; }

    public void Pay(decimal amount)
    {
        if (Card.IsBlocked == 0 && Account.IsActive == 1 && Account.Balance >= amount)
            Account.Balance -= amount;
    }

    public void Transfer(BankAccount target, decimal amount)
    {
        if (Card.IsBlocked == 0 && Account.IsActive == 1 && Account.Balance >= amount)
        {
            Account.Balance -= amount;
            target.Balance += amount;
        }
    }

    public void BlockCard() => Card.IsBlocked = 1;
    public void CancelAccount() => Account.IsActive = 0;
}

public class Administrator
{
    public void CheckOverlimit(CreditCard card, decimal amount, decimal limit)
    {
        if (amount > limit) card.IsBlocked = 1;
    }
}