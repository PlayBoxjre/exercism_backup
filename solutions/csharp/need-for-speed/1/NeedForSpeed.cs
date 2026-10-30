class RemoteControlCar
{
    // TODO: define the constructor for the 'RemoteControlCar' class
    private int speed = 5;
    private int batteryDrain = 2;

    private int meters = 0;
    private int battary = 100;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
    }

    public bool BatteryDrained()
    {
        return battary < batteryDrain;
    }

    public int DistanceDriven()
    {
        return this.meters;
    }

    public void Drive()
    {
        if(BatteryDrained()) return;
        this.meters += speed;
        this.battary -= batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int distance;

    // TODO: define the constructor for the 'RaceTrack' class
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive();
        }
        return distance <= car.DistanceDriven();
    }
}
