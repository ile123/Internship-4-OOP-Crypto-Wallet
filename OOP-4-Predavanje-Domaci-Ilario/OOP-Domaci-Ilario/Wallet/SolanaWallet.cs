namespace OOP_Domaci_Ilario.Wallet;

public sealed class SolanaWallet : Wallet
{
    private readonly List<Guid> _addressesOfOwnedNonFungibleAssets;

    public SolanaWallet()
    {
        _addressesOfOwnedNonFungibleAssets = new List<Guid>();
    }

    public List<Guid> GetOwnedAssets()
    {
        return _addressesOfOwnedNonFungibleAssets;
    }
}