namespace Tenta;

public interface IPerson
{
    public int Id { get; set; }
    string Name { get; set; }
    public void Print();
    public void Talk();

}
