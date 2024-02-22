namespace Tenta;

public class PersonRegister : List<Person>
{
    public int RegisterId { get; set; }
    public delegate void PersonAddedHandler(object source, PersonArgs args);
    public event PersonAddedHandler onPersonAdded;
    public new void Add(Person person)
    {
        base.Add(person);
        if (onPersonAdded != null)
        {
            PersonArgs args = new(person.Id, person.Name);
            onPersonAdded(this, args);
        }
    }
}