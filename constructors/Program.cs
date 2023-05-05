

//Write five seperate programs to demonostrate five types of constructors in 
//C#
using System;

class Person
{
    public string Name;
    public int Age;


    //Default Costructor 
    public Person() {
        Name = "Unknown";
        Age = 0;

    }

    //Parameterized Constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    //Static Constructors

    static Person() {
        Console.WriteLine("Static constructor called.");
    }

    //Private Constructor
    private Person(int age) {
        Name = "Unknown";
        Age = age;

    }

    //copy constructors
    public Person(Person p) { 
        Name= p.Name;
        Age = p.Age;
}
    //Displaying Output
    public void Display()
    {
        Console.WriteLine("Name:{0}, Age:{1}",Name,Age);
    }

    class Project1
    {
        static void Main(string[] args) {
        Person p1 = new Person();
        p1.Display();


       Person p2 = new Person("John",25);
       p2.Display();


            // Copy Constructor
            Person p4 = new Person(p2);
            p4.Display();

            // Static Constructor
            // Static constructor is called only once
            Person p5 = new Person();


        }
    }







}



