namespace Tenta;

public class Saab : Car
{
    public Saab() { }
    public Saab(string licenseNumber) : base(licenseNumber) { }
    public new void Print()
    {
        Console.WriteLine("I am a Saab!");
    }
}
