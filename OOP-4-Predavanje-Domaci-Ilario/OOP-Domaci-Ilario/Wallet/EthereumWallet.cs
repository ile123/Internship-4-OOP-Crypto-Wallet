namespace OOP_Domaci_Ilario.Wallet;

using OOP_Domaci_Ilario.Asset;

public sealed class EthereumWallet : Wallet
{
    private readonly List<Guid> _addressesOfOwnedNonFungibleAssets;

    public List<Guid> OwnedNonFungibleAssets
    {
        get { return _addressesOfOwnedNonFungibleAssets; }
    }

    public EthereumWallet()
    {
        _addressesOfOwnedNonFungibleAssets = new List<Guid>();
    }

    public override string PrintWallet(List<Asset> assets)
    {
        return $"";
    }
}