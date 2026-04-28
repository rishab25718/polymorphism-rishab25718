using System.Security.Cryptography;

namespace Person;

public class Person
{
    string _firstName = "";
    string _lastName = "";
    string _emailAddress = "";
    DateOnly _dateOfBirth = new DateOnly(0,0,0);

    public Person(string c1, string c2, string c3, DateOnly c4)
    {
        _firstName = c1;
        _lastName = c2;
        _emailAddress = c3;
        _dateOfBirth = c4;
    }

}
