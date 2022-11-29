namespace OOP_Domaci_Ilario.Asset;

public abstract class Asset
{
    private readonly Guid _address;
    private string Name { get; set; }
    private decimal Value { get; set; }

    public void SetName(string name)
    {
        Name = name;
    }

    public void SetValue(decimal value)
    {
        Value = value;
    }

    protected Asset(string name, decimal value)
    {
        _address = Guid.NewGuid();
        Name = name;
        Value = value;
    }

    public string GetName()
    {
        return Name;
    }

    public decimal GetValue()
    {
        return Value;
    }
}