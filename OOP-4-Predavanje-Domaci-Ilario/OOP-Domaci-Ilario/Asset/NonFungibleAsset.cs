using OOP_Domaci_Ilario.Interfaces;

namespace OOP_Domaci_Ilario.Asset;

using Transaction;

public sealed class NonFungibleAsset : Asset, INonFungible
{
    private readonly Guid _supportedFungibleAssetAddress;

    public Guid FungibleAssetAddress
    {
        get { return _supportedFungibleAssetAddress; }
    }
    
    public NonFungibleAsset(string name, decimal value, Guid supportedFungibleAssetAddress) : base(name, value)
    {
        _supportedFungibleAssetAddress = supportedFungibleAssetAddress;
    }

    public decimal ReturnValue(List<Asset> assets)
    {
        var value = 0m;
        var asset = assets.Find(x => x.Address.Equals(FungibleAssetAddress));
        if (asset is null)
        {
            return 0m;
        }
        value += base.Value * asset.Value;
        return value;
    }

    public decimal ReturnPreviousValue(List<Transaction> transactions, List<Asset> assets)
    {
        if (transactions.Count is 0)
        {
            return 0m;
        }

        if (assets.Count is 0)
        {
            return 0m;
        }

        if (transactions.Find(x => x.Asset == Address) is null)
        {
            return 0m;
        }
        var previousNonFungibleAssetValue = transactions.Where(item => item.Asset == Address)
            .OrderBy(x => x.TransactionDate).Last().AssetValue;
        var fungibleAsset = assets.Find(x => x.Address == FungibleAssetAddress);
        if (fungibleAsset is null)
        {
            return 0m;
        }
        var previousFungibleAssetValue = transactions.Where(item => item.Asset == fungibleAsset.Address)
            .OrderBy(x => x.TransactionDate).Last().AssetValue;
        return previousNonFungibleAssetValue * previousFungibleAssetValue;
    }
    
}