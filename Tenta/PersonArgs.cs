namespace Tenta;

public class PersonArgs : EventArgs
{
    public int Id { get; set; }
    public string Name { get; set; }
    public PersonArgs(int id, string name)
    {
        Id = id;
        Name = name;
    }
}