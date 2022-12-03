using OOP_Domaci_Ilario.Interfaces;

namespace OOP_Domaci_Ilario.Wallet;

using OOP_Domaci_Ilario.Asset;
using OOP_Domaci_Ilario.Transaction;

public sealed class EthereumWallet : Wallet, IFungible, INonFungible
{
    public List<Guid> AddressesOfOwnedNonFungibleAssets { get; set; }

    public EthereumWallet()
    {
        AddressesOfOwnedNonFungibleAssets = new List<Guid>();
    }

    public override void PrintWallet(List<Asset> assets, List<(Guid address, DateTime date, decimal value)> fungibleAssetPriceHistory)
    {
        
    }

    public decimal ReturnTotalValueOfFungibleAssets(List<Asset> assets)
    {
        return 0m;
    }

    public decimal ReturnTotalValueOfNonFungibleAssets(List<Asset> assets)
    {
        return 0m;
    }
    
}