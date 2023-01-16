namespace BenchmarkTryout;

public class Person
{
    public string GivenName { get; set; } = default!;
    public string Surname { get; set; } = default!;
    public List<Address> Addresses { get; set; } = new();
    public List<Person> Children { get; set; } = new();
}

public class Address {
    public string Street { get; set; } = default!;
    public string PostalCode { get; set; } = default!;
    public string Country { get; set; } = default!;
    public AddressType Type { get; set; } = default!;

}

public enum AddressType { 
    Home,
    Work
}