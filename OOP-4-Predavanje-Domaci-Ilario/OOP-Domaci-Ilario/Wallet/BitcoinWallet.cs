namespace OOP_Domaci_Ilario.Wallet;

public sealed class BitcoinWallet : Wallet
{
    private readonly List<Guid> _supportedFungibleAssets;
    public BitcoinWallet()
    {
        _supportedFungibleAssets = new List<Guid>();
    }

    public List<Guid> GetAssets()
    {
        return _supportedFungibleAssets;
    }
}