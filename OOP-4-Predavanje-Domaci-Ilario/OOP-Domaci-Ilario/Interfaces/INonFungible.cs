namespace OOP_Domaci_Ilario.Interfaces;

using Asset;

using Transaction;

public interface INonFungible
{
    decimal ReturnValue(List<Asset> assets);

    decimal ReturnPreviousValue(List<Transaction> transactions, List<Asset> assets);
}