using System.Security.Cryptography;

namespace Person;



public class Student : Person 
{
    int _schoolYear;
    public Student(string c1, string c2, string c3, DateOnly c4) : base(c1,c2,c3,c4)
    {
        _schoolYear = _AGE - 4;
    }

    public Student(string c1, string c2, string c3, DateOnly c4, int schoolYear) : base(c1,c2,c3,c4)
    {
        _schoolYear = schoolYear;
    }
}

