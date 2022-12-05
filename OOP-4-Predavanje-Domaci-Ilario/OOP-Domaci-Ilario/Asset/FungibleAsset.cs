using OOP_Domaci_Ilario.Interfaces;

namespace OOP_Domaci_Ilario.Asset;

using Transaction;

public sealed class FungibleAsset : Asset, IFungible
{
    public string Label { get; set; }

    public FungibleAsset(string name, decimal value, string label) : base(name, value)
    {
        Label = label;
    }

    public decimal ReturnValue()
    {
        return base.Value;
    }

    public decimal ReturnPreviousValue(List<Transaction> transactions)
    {
        if (transactions.Count is 0)
        {
            return 0m;
        }

        if (transactions.Find(x => x.Asset == Address) is null)
        {
            return 0m;
        }
        var assetValue = transactions.Where(item => item.Asset == Address)
            .OrderBy(x => x.TransactionDate).Last().AssetValue;
        return assetValue;
    }

}