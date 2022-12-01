namespace OOP_Domaci_Ilario.Wallet;

public sealed class SolanaWallet : Wallet
{
    private readonly List<Guid> _addressesOfOwnedNonFungibleAssets;

    public List<Guid> OwnedNonFungibleAssets
    {
        get { return _addressesOfOwnedNonFungibleAssets;  }
    }

    public SolanaWallet()
    {
        _addressesOfOwnedNonFungibleAssets = new List<Guid>();
    }

    public override string PrintWallet(List<Asset.Asset> assets)
    {
        return $"";
    }
}