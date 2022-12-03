namespace OOP_Domaci_Ilario.Interfaces;

using OOP_Domaci_Ilario.Asset;

public interface IFungible
{
    decimal ReturnTotalValueOfFungibleAssets(List<Asset> assets);
}