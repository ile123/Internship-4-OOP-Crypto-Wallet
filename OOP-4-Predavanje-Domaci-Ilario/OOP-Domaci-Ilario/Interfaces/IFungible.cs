namespace OOP_Domaci_Ilario.Interfaces;

using Transaction;

public interface IFungible
{
    decimal ReturnValue();

    decimal ReturnPreviousValue(List<Transaction> transactions);

}