using OOP_Domaci_Ilario.Interfaces;

namespace OOP_Domaci_Ilario.Asset;

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
        var assetValue = assets.Find(x => x.Address.Equals(FungibleAssetAddress)).Value;
        if (assetValue is 0m)
        {
            return 0m;
        }
        value += base.Value * assetValue;
        return value;
    }
}