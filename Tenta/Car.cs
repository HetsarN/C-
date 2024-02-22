namespace Tenta;

public class Car
{
    public string LicenseNumber { get; set; }
    public Car() { }
    public Car(string licenseNumber)
    {
        LicenseNumber = licenseNumber;
    }
    public virtual void Print()
    {
        Console.WriteLine("I am a car!");
    }
    public static Car operator +(Car car1, Car car2)
    {
        Car newCar = new();
        newCar.LicenseNumber = car1.LicenseNumber + car2.LicenseNumber;
        return new Car();
    }
}