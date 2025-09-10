class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    private int _distanceDriven = 0;
    private int _batteryLife = 100;
    
    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
    }

    public bool BatteryDrained() => _batteryLife < _batteryDrain;

    public int DistanceDriven() => _distanceDriven;
    
    public void Drive() 
    {
        if (!BatteryDrained())
        {
        _distanceDriven += _speed;
        _batteryLife -= _batteryDrain;
        }
    }
    
    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained()) car.Drive();
        return car.DistanceDriven() >= _distance;
    }
}
