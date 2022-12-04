namespace OOP_Domaci_Ilario.Transaction;

public abstract class Transaction
{
    private readonly Guid _id;
    private readonly Guid _assetAddress;
    private readonly DateTime _transactionDate;
    private readonly Guid _senderWallet;
    private readonly Guid _receiverWallet;
    public decimal AssetValue { get; set; }
    public bool IsCancelled { get; set; }

    public Guid Id
    {
        get { return _id; }
    }

    public Guid Asset
    {
        get { return _assetAddress; }
    }

    public DateTime TransactionDate
    {
        get { return _transactionDate; }
    }

    public Guid Sender
    {
        get { return _senderWallet; }
    }

    public Guid Receiver
    {
        get { return _receiverWallet; }
    }

    protected Transaction(Guid assetAddress, Guid senderWallet, Guid receiverWallet)
    {
        _id = Guid.NewGuid();
        _assetAddress = assetAddress;
        _transactionDate = DateTime.Now;
        _senderWallet = senderWallet;
        _receiverWallet = receiverWallet;
        IsCancelled = false;
    }
    
}