using OOP_Domaci_Ilario.Asset;

namespace OOP_Domaci_Ilario.Transaction;

public sealed class FungibleAssetTransaction : Transaction
{
    private decimal _beggingBalanceOfSenderWallet;
    private decimal _finalBalanceOfSenderWallet;
    private decimal _beggingBalanceOfReceiverWallet;
    private decimal _finalBalanceOfReceiverWallet;

    public decimal BeggingSenderBalance
    {
        get { return _beggingBalanceOfSenderWallet; }
        set { _beggingBalanceOfSenderWallet = value; }
    }

    public decimal FinalSenderBalance
    {
        get { return _finalBalanceOfSenderWallet; }
        set { _finalBalanceOfSenderWallet = value; }
    }

    public decimal BeggingReceiverBalance
    {
        get { return _beggingBalanceOfReceiverWallet; }
        set { _beggingBalanceOfReceiverWallet = value; }
    }

    public decimal FinalReceiverBalance
    {
        get { return _finalBalanceOfReceiverWallet; }
        set { _finalBalanceOfReceiverWallet = value; }
    }
    
    public FungibleAssetTransaction(Guid assetAddress, Guid senderWallet, Guid receiverWallet, decimal beggingBalanceSender, decimal finalBalanceSender, decimal beggingBalanceReceiver, decimal finalBalanceReceiver) : base(assetAddress, senderWallet, receiverWallet)
    {
        _beggingBalanceOfSenderWallet = beggingBalanceSender;
        _finalBalanceOfSenderWallet = finalBalanceReceiver;
        _beggingBalanceOfReceiverWallet = beggingBalanceReceiver;
        _finalBalanceOfReceiverWallet = finalBalanceReceiver;
    }
}