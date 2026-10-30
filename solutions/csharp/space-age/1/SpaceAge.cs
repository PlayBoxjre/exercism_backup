public class SpaceAge
{
    private int seconds;
    public SpaceAge(int seconds)
    {
        this.seconds = seconds;
    }

    public double OnEarth()
    {
        return seconds/ 31557600.0f ;
    }

    public double OnMercury()
    {
        return  OnEarth() / 0.2408467d;
    }

    public double OnVenus()
    {
         return  OnEarth() / 0.61519726d;
    }

    public double OnMars()
    {
        return  OnEarth() / 1.8808158d;
    }

    public double OnJupiter()
    {
       return  OnEarth() / 11.862615d;
    }

    public double OnSaturn()
    {
       return  OnEarth() / 29.447498d;
    }

    public double OnUranus()
    {
        return  OnEarth() / 	84.016846d;
    }

    public double OnNeptune()
    {
        return  OnEarth() / 164.79132d;
    }
}