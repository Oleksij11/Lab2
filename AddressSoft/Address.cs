using System.Text;

namespace Lab1;

internal sealed class Address
{
    private string _city = string.Empty;
    private string _street = string.Empty;
    private int _index;
    private int _house;
    private int _apartment;

    public int Index
    {
        get => _index;
        set => _index = value;
    }

    public string Street
    {
        get => _street;
        set => _street = value;
    }

    public int House
    {
        get => _house;
        set => _house = value;
    }

    public int Apartment
    {
        get => _apartment;
        set => _apartment = value;
    }

    public string City
    {
        get => _city;
        set => _city = value;
    }

    /// <inheritdoc />
    public override string ToString()
    {
        return $"Index: {Index}, Street: {Street}, House: {House}, Apt. : {Apartment}, City: {City}";
    }
}
