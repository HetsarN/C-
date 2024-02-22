namespace Tenta;

public static class ExamUtils
{
    public static void RenamePerson(ref Person p)
    {
        p = new Person(p.Id, "Tenta");
    }
    public static void Increment()
    {
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine($"i: {i}");
        }
        Console.WriteLine("Done!");
    }
}
