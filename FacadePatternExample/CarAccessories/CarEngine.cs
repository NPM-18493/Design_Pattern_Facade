public class CarEngine : ICarAccessory
{
    public void SwitchOff()
    {
        Console.WriteLine("Engine off!");
    }

    public void SwitchOn()
    {
        Console.WriteLine("Engine on!");
    }
}