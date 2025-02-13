public class CarAC : ICarAccessory
{
    public void SwitchOff()
    {
        Console.WriteLine("AC off!");
    }

    public void SwitchOn()
    {
        Console.WriteLine("AC on!");
    }
}