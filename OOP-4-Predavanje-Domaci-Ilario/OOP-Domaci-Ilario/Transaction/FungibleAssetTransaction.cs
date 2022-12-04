using OOP_Domaci_Ilario.Asset;

namespace OOP_Domaci_Ilario.Transaction;

public sealed class FungibleAssetTransaction : Transaction
{
    public decimal BeggingBalanceOfSenderWallet { get; set; }
    public decimal FinalBalanceOfSenderWallet { get; set; }
    public decimal BeggingBalanceOfReceiverWallet { get; set; }
    public decimal FinalBalanceOfReceiverWallet { get; set; }

    public FungibleAssetTransaction(Guid assetAddress, Guid senderWallet, Guid receiverWallet, decimal beggingBalanceSender, decimal finalBalanceSender, decimal beggingBalanceReceiver, decimal finalBalanceReceiver) : base(assetAddress, senderWallet, receiverWallet)
    {
        BeggingBalanceOfSenderWallet = beggingBalanceSender;
        FinalBalanceOfSenderWallet = finalBalanceReceiver;
        BeggingBalanceOfReceiverWallet = beggingBalanceReceiver;
        FinalBalanceOfReceiverWallet = finalBalanceReceiver;
    }
}