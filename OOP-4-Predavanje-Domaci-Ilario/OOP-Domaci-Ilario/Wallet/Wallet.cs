namespace OOP_Domaci_Ilario.Wallet;

public abstract class Wallet
{
    private readonly Guid _address;
    private readonly List<(Guid Address, int Balance)> _fungibleAssetsBalance;
    private readonly List<Guid> _transactionAddresses;

    protected Wallet()
    {
        _address = Guid.NewGuid();
        _fungibleAssetsBalance = new List<(Guid Address, int Balance)>();
        _transactionAddresses = new List<Guid>();
    }

    public Guid GetAddress()
    {
        return _address;
    }

    public List<(Guid address, int Balance)> GetFungibleAssetsBalance()
    {
        return _fungibleAssetsBalance;
    }

    public List<Guid> GetTransactionAddresses()
    {
        return _transactionAddresses;
    }
    
}