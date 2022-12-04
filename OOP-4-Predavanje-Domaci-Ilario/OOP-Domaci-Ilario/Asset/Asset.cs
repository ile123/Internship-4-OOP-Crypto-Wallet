namespace OOP_Domaci_Ilario.Asset;

public abstract class Asset
{
    private readonly Guid _address;
    public string Name { get; set; }
    private decimal _value;

    public Guid Address
    {
        get { return _address; }
    }

    public decimal Value
    {
        get { return _value; }
        set { _value = value; }
    }

    protected Asset(string name, decimal value)
    {
        _address = Guid.NewGuid();
        Name = name;
        _value = value;
    }
    
}