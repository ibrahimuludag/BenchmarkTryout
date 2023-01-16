using BenchmarkDotNet.Attributes;

namespace BenchmarkTryout;

public class NewtonsoftVsSystemText
{
	private readonly List<Person> _people;
    public NewtonsoftVsSystemText()
	{
        _people = new List<Person> {
            new Person{
                GivenName = "John",
                Surname = "Smith",
                Addresses = new List<Address>{
                    new Address{
                        Street = "Fifth Avenue",
                        PostalCode = "12345",
                        Country = "USA",
                        Type = AddressType.Home
                    },
                    new Address{
                        Street = "Fourth Avenue",
                        PostalCode = "12346",
                        Country = "USA",
                        Type = AddressType.Work
                    }
                },
                Children = new List<Person>{
                    new Person{
                        GivenName = "Mai",
                        Surname = "Smith"
                    },
                    new Person{
                        GivenName = "Susan",
                        Surname = "Smith"
                    }
                }
            }
        };
    }


    [Benchmark]
    public string NewtonSerialization() => Newtonsoft.Json.JsonConvert.SerializeObject(_people);

    [Benchmark]
    public string SystemTextSerialization() => System.Text.Json.JsonSerializer.Serialize(_people);
}
