namespace OOP_Domaci_Ilario.Asset;

public abstract class Asset
{
    private readonly Guid _address;
    public string Name { get; set; }
    public decimal Value { get; private set; }

    public Guid Address
    {
        get { return _address; }
    }

    protected Asset(string name, decimal value)
    {
        _address = Guid.NewGuid();
        Name = name;
        Value = value;
    }
    
}