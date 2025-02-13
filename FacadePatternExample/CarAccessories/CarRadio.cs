public class CarRadio : ICarAccessory
{
    public void SwitchOff()
    {
        Console.WriteLine("Radio off!");
    }

    public void SwitchOn()
    {
        Console.WriteLine("Radio on!");
    }
}