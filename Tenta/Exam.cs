using System.Reflection;

namespace Tenta;
public class Exam
{
    static void A()
    {
        List<Car> cars = new();
        Car car = new("ESC-123");
        Saab saab = new("ALT-456");
        Volvo volvo = new("CMD-789");
        cars.Add(new Car());
        cars.Add(new Saab());
        cars.Add(new Volvo());
        foreach (var tmpCar in cars)
        {
            tmpCar.Print();
        }
        Car myCar = saab + volvo;
        Console.WriteLine($"License Number: {myCar.LicenseNumber}");
        bool sameCar = Object.ReferenceEquals(saab, cars[1]);
        Console.WriteLine($"Same car: {sameCar}");
    }
    public static void B()
    {
        Volvo volvo = new("CIL-654");
        Saab saab = new("CLR-843");
        Person p1 = new(1, "Mary Sue");
        Person p2 = new(2, "Gary Stu");
        p1.Car = volvo;
        p2.Car = saab;
        Person p3 = p1.Clone() as Person;
        p3.Id = 3;
        p3.Name = "Ham";
        volvo.LicenseNumber = "CTS-991";
        p3.Car = volvo;
        Console.WriteLine($"Person 1 Car: {p1.Car.GetType()}, {p1.Car.LicenseNumber}");
        Console.WriteLine($"Person 2 Car: {p2.Car.GetType()}, {p2.Car.LicenseNumber}");
        Console.WriteLine($"Person 3 Car: {p3.Car.GetType()}, {p3.Car.LicenseNumber}");
        bool a = p1.Equals(p2);
        bool b = Object.ReferenceEquals(p1, p2);
        bool c = p1 == p3;
        Console.WriteLine($"a: {a}");
        Console.WriteLine($"b: {b}");
        Console.WriteLine($"c: {c}");
        Person p4 = new(4, "Ken");
        Person p5 = p4;
        ExamUtils.RenamePerson(ref p4);
        bool d = Object.ReferenceEquals(p4, p5);
        Console.WriteLine($"d: {d}");
    }
    static void C()
    {
        PersonRegister reg = new();
        reg.RegisterId = 1;
        Person p1 = new(1, "Bob");
        Person p2 = new(2, "Ken");
        Subscriber s1 = new();
        Subscriber s2 = new();
        s1.Subscribe(reg);
        s2.Subscribe(reg);
        reg.Add(p1);
        reg.Add(p2);
        foreach (Person p in reg)
        {
            p.Print();
        }
        IPerson p3 = new Person();
        p3.Id = 1;
        p3.Name = "Vim";
        IPerson p4 = new Person();
        p4.Id = 2;
        p4.Name = "Sue";
        Type t = p3.GetType();
        Console.WriteLine($"Type: {t}");
        p3.Print();
        p4.Talk();
        //p4.Speak();
    }
    static void D()
    {
        Type type = Type.GetType("Tenta.Person");
        object obj = Activator.CreateInstance(type);
        MethodInfo mi = type.GetMethod("Talk");
        mi.Invoke(obj, null);
        Thread[] threads = new Thread[2];
        threads[0] = new Thread(new ThreadStart(ExamUtils.Increment));
        threads[1] = new Thread(new ThreadStart(ExamUtils.Increment));
        foreach (Thread thread in threads)
        {
            thread.Start();
            thread.Join();
        }
        Console.WriteLine("Threads done!");
    }

    static void Main(string[] args)
    {
        Console.WriteLine("--- Start ---");
        Console.WriteLine("A ---");
        A();
        Console.WriteLine("B ---");
        B();
        Console.WriteLine("C ---");
        C();
        Console.WriteLine("D ---");
        D();
        Console.WriteLine("--- End ---");
    }
}