class RemoteControlCar
{
    private int _chargeLevel = 100;
    private int _totalDistance = 0;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_totalDistance} meters";

    public string BatteryDisplay() => _chargeLevel != 0 ? $"Battery at {_chargeLevel}%" : "Battery empty";

    public void Drive()
    {
        if (_chargeLevel > 0)
        {
            _chargeLevel -= 1;
            _totalDistance += 20;
        }
    }
}
