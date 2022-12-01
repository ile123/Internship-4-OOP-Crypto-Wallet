namespace OOP_Domaci_Ilario.Wallet;

using OOP_Domaci_Ilario.Asset;

public sealed class BitcoinWallet : Wallet
{

    private decimal CalculateTotalValueOfAssets(List<Asset> assets)
    {
        var total = Decimal.Zero;
        var assetValue = Decimal.Zero;
        foreach (var item in base.FungibleAssetsBalance)
        {
            assetValue = assets.Find(x => x.GetAddress().Equals(item.Address)).GetValue();
            if (assetValue is not 0m)
            {
                total += assetValue * item.Balance;
            }
        }
        return total;
    }

    public override string PrintWallet(List<Asset> assets)
    {
        return $"Bitcoin - {base.Address} - {CalculateTotalValueOfAssets(assets)} - ";
    }
}