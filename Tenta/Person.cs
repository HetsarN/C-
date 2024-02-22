namespace Tenta;
public class Person : IPerson, ICloneable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public Car Car { get; set; }
    public Person() { }
    public Person(int id, string name)
    {
        Id = id;
        Name = name;
    }
    public void Print()
    {
        Console.WriteLine($"I am {Name}");
    }
    public void Talk()
    {
        Console.WriteLine("Just a person");
    }
public void Speak()
    {
        Console.WriteLine($"ID: {Id}");
    }
    public object Clone()
    {
        Person clone = new()
        {
            Id = Id,
            Name = Name,
            Car = Car
        };
        return clone;
    }
    public override string ToString()
    {
        return "Hata data";
    }
    public override bool Equals(object? obj)
    {
        return 2 > 1;
    }
}