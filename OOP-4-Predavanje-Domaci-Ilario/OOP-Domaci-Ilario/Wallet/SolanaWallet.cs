namespace OOP_Domaci_Ilario.Wallet;

public sealed class SolanaWallet : Wallet
{
    private readonly List<Guid> _addressesOfSupportedFungibleAndNonFungibleAssets;
    private readonly List<Guid> _addressesOfOwnedNonFungibleAssets;

    public SolanaWallet()
    {
        _addressesOfSupportedFungibleAndNonFungibleAssets = new List<Guid>();
        _addressesOfOwnedNonFungibleAssets = new List<Guid>();
    }

    public List<Guid> GetSupportedAssets()
    {
        return _addressesOfSupportedFungibleAndNonFungibleAssets;
    }

    public List<Guid> GetOwnedAssets()
    {
        return _addressesOfOwnedNonFungibleAssets;
    }
}