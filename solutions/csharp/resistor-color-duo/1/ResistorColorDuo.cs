public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
           string[] colorsMap = new [] 
    {
        "black",
        "brown",
        "red",
        "orange",
        "yellow",
        "green",
        "blue",
        "violet",
        "grey",
        "white"
    };
    int[] maps  = colors.Select(x => colorsMap.IndexOf(x)).ToArray();
    // maps ==> 15;
    return maps[0]*10 +  maps[1];
    }
}
