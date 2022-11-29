namespace OOP_Domaci_Ilario.Transaction;

public class NonFungibleAssetTransaction : Transaction
{
    public NonFungibleAssetTransaction(Guid assetAddress, Guid senderWallet, Guid receiverWallet) : base(assetAddress, senderWallet, receiverWallet)
    {
        
    }
}