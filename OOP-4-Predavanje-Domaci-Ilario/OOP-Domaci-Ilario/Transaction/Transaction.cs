namespace OOP_Domaci_Ilario.Transaction;

public abstract class Transaction
{
    private readonly Guid _id;
    private readonly Guid _assetAddress;
    private readonly DateTime _transactionDate;
    private readonly Guid _senderWallet;
    private readonly Guid _receiverWallet;
    private bool _isCancelled;

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

    public bool IsCancelled
    {
        get { return _isCancelled; }
        set { _isCancelled = value; }
    }
    
    protected Transaction(Guid assetAddress, Guid senderWallet, Guid receiverWallet)
    {
        _id = Guid.NewGuid();
        _assetAddress = assetAddress;
        _transactionDate = DateTime.Now;
        _senderWallet = senderWallet;
        _receiverWallet = receiverWallet;
        _isCancelled = false;
    }
    
}