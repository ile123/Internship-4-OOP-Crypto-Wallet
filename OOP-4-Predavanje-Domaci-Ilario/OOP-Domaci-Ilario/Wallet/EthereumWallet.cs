namespace OOP_Domaci_Ilario.Wallet;

public sealed class EthereumWallet : Wallet
{
    private readonly List<Guid> _addressesOfOwnedNonFungibleAssets;

    public EthereumWallet()
    {
        _addressesOfOwnedNonFungibleAssets = new List<Guid>();
    }

    public List<Guid> GetOwnedAssets()
    {
        return _addressesOfOwnedNonFungibleAssets;
    }
}