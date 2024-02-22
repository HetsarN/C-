namespace Tenta;
public class Volvo : Car
{
    public Volvo() { }
    public Volvo(string licenseNumber) : base(licenseNumber) { }
    public override void Print()
    {
        Console.WriteLine("I am a Volvo!");
    }
}