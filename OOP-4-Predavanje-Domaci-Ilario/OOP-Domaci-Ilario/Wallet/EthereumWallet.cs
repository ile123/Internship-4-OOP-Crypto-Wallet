namespace OOP_Domaci_Ilario.Wallet;

public sealed class EthereumWallet : Wallet
{
    private readonly List<Guid> _addressesOfSupportedFungibleAndNonFungibleAssets;
    private readonly List<Guid> _addressesOfOwnedNonFungibleAssets;

    public EthereumWallet()
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