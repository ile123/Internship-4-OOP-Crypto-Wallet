namespace OOP_Domaci_Ilario.Transaction;

public abstract class Transaction
{
    private readonly Guid _id;
    private readonly Guid _assetAddress;
    private readonly DateTime _transactionDate;
    private readonly Guid _senderWallet;
    private readonly Guid _receiverWallet;
    private bool _isCalled;

    protected Transaction(Guid assetAddress, Guid senderWallet, Guid receiverWallet)
    {
        _id = Guid.NewGuid();
        _assetAddress = assetAddress;
        _transactionDate = DateTime.Now;
        _senderWallet = senderWallet;
        _receiverWallet = receiverWallet;
        _isCalled = false;
    }

    public Guid GetTransactionId()
    {
        return _id;
    }

    public Guid GetAssetAddress()
    {
        return _assetAddress;
    }

    public DateTime GetTransactionDate()
    {
        return _transactionDate;
    }

    public Guid GetSenderWallet()
    {
        return _senderWallet;
    }

    public Guid GetReceiverWallet()
    {
        return _receiverWallet;
    }

    public bool GetIsCalled()
    {
        return _isCalled;
    }

    public void SetIsCalled(bool newBool)
    {
        _isCalled = newBool;
    }
}