namespace OOP_Domaci_Ilario.Wallet;

public sealed class BitcoinWallet : Wallet
{

    private decimal CalculateTotalValueOfAssets()
    {
        var total = 0m;
        var assetValue = 0m;
        foreach (var item in GetFungibleAssetsBalance())
        {
            
        }

        return total;
    }
    
    
}