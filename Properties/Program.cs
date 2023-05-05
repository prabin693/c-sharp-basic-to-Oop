//WAP in C# to demonstrate concept of Property.

using System;

public class Person
{
    private string _name;
    private int _age;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Age
    {
        get { return _age; }
        set { _age = value; }
    }

    public Person(string name, int age)
    {
        _name = name;
        _age = age;
    }
}

public class Program
{
    public static void Main()
    {
        Person person = new Person("John", 30);
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);

        person.Name = "Jane";
        person.Age = 25;
        Console.WriteLine("Name: " + person.Name);
        Console.WriteLine("Age: " + person.Age);
    }
}


