class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
       return new int[]{0, 2, 5, 3, 7, 8, 4};
    }

    public int Today()
    {
       return birdsPerDay[^1];
    }

    public void IncrementTodaysCount()
    {
       birdsPerDay[^1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        foreach (int v in birdsPerDay){
            if (v == 0){
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int total = 0;
        for(int i = 0;i < numberOfDays ; i++){
            total += birdsPerDay[i];
        }
        return total;
    }

    public int BusyDays()
    {
        int busy = 0;
        foreach (int v in birdsPerDay){
            if (v >= 5){
               busy ++;
            }
        }
        return busy;
    }
}
