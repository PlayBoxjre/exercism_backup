class Lasagna
{
    private int expectedMinutes => ExpectedMinutesInOven();
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return 40;
    }

    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int inMinutes) =>  expectedMinutes - inMinutes;
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int layers) => layers * 2 ; 

    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int layers, int inMinutes) => PreparationTimeInMinutes(layers) + inMinutes;
}
