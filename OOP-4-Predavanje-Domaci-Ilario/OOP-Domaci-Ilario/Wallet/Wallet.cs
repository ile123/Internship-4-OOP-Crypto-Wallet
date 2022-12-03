namespace OOP_Domaci_Ilario.Wallet;

using OOP_Domaci_Ilario.Asset;
using OOP_Domaci_Ilario.Transaction;
public abstract class Wallet
{
    private readonly Guid _address;
    private readonly List<(Guid Address, int Balance)> _fungibleAssetsBalance;
    private readonly List<Guid> _supportedAssetsAddresses;
    private readonly List<Guid> _transactionAddresses;

    public Guid Address
    {
        get { return _address; }
    }

    public List<(Guid Address, int Balance)> FungibleAssetsBalance
    { 
        get { return _fungibleAssetsBalance; }
    }

    public List<Guid> SupportedAssetsAddresses
    {
        get { return _supportedAssetsAddresses; }
    }

    public List<Guid> TransactionAddresses
    {
        get { return _transactionAddresses; }
    }

    protected Wallet()
    {
        _address = Guid.NewGuid();
        _fungibleAssetsBalance = new List<(Guid Address, int Balance)>();
        _supportedAssetsAddresses = new List<Guid>();
        _transactionAddresses = new List<Guid>();
    }

    public abstract void PrintWallet(List<Asset> assets, List<(Guid address, DateTime date, decimal value)> fungibleAssetPriceHistory);

    /*
    public Transaction? GetLastTransactionRelatedToAsset(List<Transaction> transactions, Guid assetAddress)
    {
        if (transactions.Count is 0)
        {
            return null;
        }

        var filteredTransactions = TransactionAddresses.Select(item => transactions.Find(x => x.Id.Equals(item))).ToList();

        return filteredTransactions.OrderBy(x => x?.TransactionDate).Last();
    }
    */
}