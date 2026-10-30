class RemoteControlCar
{
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    private int battery = 100;
    private int meters;

    public string DistanceDisplay()
    {
        return $"Driven {meters} meters";
    }

    public string BatteryDisplay()
    {   string batteryStr = battery > 0 ? "at " +  battery.ToString() + "%" : "empty";
        return $"Battery {batteryStr}";
    }

    public void Drive()
    {
        if(battery == 0) return;
        this.meters += 20;
        this.battery -= 1;
    }

}
