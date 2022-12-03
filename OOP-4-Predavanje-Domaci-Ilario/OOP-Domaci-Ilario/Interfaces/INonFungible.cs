namespace OOP_Domaci_Ilario.Interfaces;

using OOP_Domaci_Ilario.Asset;

public interface INonFungible
{
    //public List<Guid> OwnedNonFungibleAssets { get; set; }

    decimal ReturnTotalValueOfNonFungibleAssets(List<Asset> assets);
}