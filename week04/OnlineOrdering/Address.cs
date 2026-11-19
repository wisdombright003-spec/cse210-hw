public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        _street = street;
        _city = city;
        _state = state;
        _country = country;
    }

    private bool Location()
    {
        return _country.Equals("USA", StringComparison.OrdinalIgnoreCase); // return yes if the counntry is "USA" lowerr case upper it doesn't matter
    }

    public bool InRegion()
    {
        return Location();
    }

    public string DisplayAddress()
    {
        return $"{_street}, {_state}, {_country}";
    }
}