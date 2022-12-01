namespace OOP_Domaci_Ilario.Asset;

public sealed class FungibleAsset : Asset
{
    private string _label;

    public string Label
    {
        get { return _label; }
        set { _label = value; }
    }
    
    public FungibleAsset(string name, decimal value, string label) : base(name, value)
    {
        _label = label;
    }
}