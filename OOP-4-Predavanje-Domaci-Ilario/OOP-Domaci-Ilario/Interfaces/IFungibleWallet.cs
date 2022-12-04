using OOP_Domaci_Ilario.Asset;

namespace OOP_Domaci_Ilario.Interfaces;

public interface IFungibleWallet
{
    public void AddFungibleAssetToList(FungibleAsset asset, int amount);
}