public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
      private int _month;
    private int _year;
    public Meetup(int month, int year)
    {
        this._month = month;
        this._year = year;
    }

    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var candidatas = Enumerable.Range(1, DateTime.DaysInMonth(_year, _month))
            .Select(x => new DateTime(_year, _month, x))
            .Where(dt => dt.DayOfWeek == dayOfWeek);
        return schedule switch
        {
            Schedule.Teenth => candidatas.First(time => time.Day >= 13 && time.Day <= 19),
            Schedule.First => candidatas.ElementAt(0),
            Schedule.Last => candidatas.Last(),
            Schedule.Second => candidatas.ElementAt(1),
            Schedule.Third => candidatas.ElementAt(2),
            Schedule.Fourth => candidatas.ElementAt(3),
            _ => throw new ArgumentException()
        };
    }
}