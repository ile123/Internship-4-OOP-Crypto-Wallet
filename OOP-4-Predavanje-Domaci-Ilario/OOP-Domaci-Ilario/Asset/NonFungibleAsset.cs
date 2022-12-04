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

    public decimal ReturnValue(Asset asset)
    {
        return base.Value * asset.Value;
    }
}