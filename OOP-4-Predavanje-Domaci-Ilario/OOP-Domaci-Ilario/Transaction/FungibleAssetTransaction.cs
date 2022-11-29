using OOP_Domaci_Ilario.Asset;

namespace OOP_Domaci_Ilario.Transaction;

public sealed class FungibleAssetTransaction : Transaction
{
    private decimal BeggingBalanceOfSenderWallet { get; }
    private decimal FinalBalanceOfSenderWallet { get; }
    private decimal BeggingBalanceOfReceiverWallet { get; }
    private decimal FinalBalanceOfReceiverWallet { get; }
    public FungibleAssetTransaction(Guid assetAddress, Guid senderWallet, Guid receiverWallet, decimal beggingBalanceSender, decimal finalBalanceSender, decimal beggingBalanceReceiver, decimal finalBalanceReceiver) : base(assetAddress, senderWallet, receiverWallet)
    {
        BeggingBalanceOfSenderWallet = beggingBalanceSender;
        FinalBalanceOfSenderWallet = finalBalanceReceiver;
        BeggingBalanceOfReceiverWallet = beggingBalanceReceiver;
        FinalBalanceOfReceiverWallet = finalBalanceReceiver;
    }
}