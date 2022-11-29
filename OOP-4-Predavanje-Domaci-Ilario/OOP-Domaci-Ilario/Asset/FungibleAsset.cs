namespace OOP_Domaci_Ilario.Asset;

public sealed class FungibleAsset : Asset
{
    private string _label;
    public FungibleAsset(string name, decimal value, string label) : base(name, value)
    {
        _label = label;
    }

    public string GetLabel()
    {
        return _label;
    }

    public void SetLabel(string label)
    {
        _label = label;
    }
}