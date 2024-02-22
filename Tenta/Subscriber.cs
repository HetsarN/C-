namespace Tenta;

public class Subscriber
{
    public void Subscribe(PersonRegister register)
    {
        PersonRegister.PersonAddedHandler handler = new(React);
        register.onPersonAdded += handler;
    }
    private void React(object sender, PersonArgs e)
    {
        PersonRegister register = sender as PersonRegister;
        Console.WriteLine($"Register {register.RegisterId} Added: {e.Id}, {e.Name}");
    }
}