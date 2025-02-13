public class CarFacade
{
    private readonly Lazy<ICarAccessory> CarACInstance = new Lazy<ICarAccessory>(()=> new CarAC());
    private readonly Lazy<ICarAccessory> CarRadioInstance = new Lazy<ICarAccessory>(()=> new CarRadio());
    private readonly Lazy<ICarAccessory> CarEngineInstance = new Lazy<ICarAccessory>(()=> new CarEngine());

    public void StartCar(){
        Console.WriteLine("*****Starting Car*****");
        CarACInstance.Value.SwitchOn();
        CarRadioInstance.Value.SwitchOn();
        CarEngineInstance.Value.SwitchOn();
    }

    public void SwitchOffCar(){
        Console.WriteLine("*****Shutting down Car*****");
        CarACInstance.Value.SwitchOff();
        CarRadioInstance.Value.SwitchOff();
        CarEngineInstance.Value.SwitchOff();
    }
}