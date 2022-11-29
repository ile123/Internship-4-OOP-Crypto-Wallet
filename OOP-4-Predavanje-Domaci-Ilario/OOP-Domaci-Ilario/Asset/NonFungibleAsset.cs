namespace OOP_Domaci_Ilario.Asset;

public sealed class NonFungibleAsset : Asset
{
    private readonly Guid _nonFungibleAssetAdress;
    public NonFungibleAsset(string name, decimal value) : base(name, value)
    {
        _nonFungibleAssetAdress = Guid.NewGuid();
    }

    public Guid GetNonFungibleAsset()
    {
        return _nonFungibleAssetAdress;
    }
}