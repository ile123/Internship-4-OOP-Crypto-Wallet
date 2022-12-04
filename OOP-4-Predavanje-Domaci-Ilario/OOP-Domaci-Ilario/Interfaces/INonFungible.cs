namespace OOP_Domaci_Ilario.Interfaces;

using OOP_Domaci_Ilario.Asset;

public interface INonFungible
{
    decimal ReturnValue(List<Asset> assets);
}