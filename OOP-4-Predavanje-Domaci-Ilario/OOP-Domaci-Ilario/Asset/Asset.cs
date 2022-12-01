namespace OOP_Domaci_Ilario.Asset;

public abstract class Asset
{
    private readonly Guid _address;
    private string _name;
    private decimal _value;

    public Guid Address
    {
        get { return _address; }
    }

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public decimal Value
    {
        get { return _value; }
        set { _value = value; }
    }

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
        _name = name;
        _value = value;
    }

    public string GetName()
    {
        return Name;
    }

    public Guid GetAddress()
    {
        return _address;
    }

    public decimal GetValue()
    {
        return Value;
    }
}