using System;

struct Person
{
    public string firstName;
    public string LastName;
    public int age;

    public Person(String firstName, string LastName, int age)
    {
        this.firstName = firstName;
        this.LastName = LastName;
        this.age = age;
    }

    public override string ToString()
    {
        return firstName + " " + LastName + ", age" + age;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Tony", "Allen", 20);
        Console.WriteLine(person);
    }
}

