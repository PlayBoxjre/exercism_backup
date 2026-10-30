public static class SquareRoot
{
    public static int Root(int number)
      {
        if(number == 1){
            return 1;
        }
        double downLimit = 0;
        double upLimit = number;
        double i = 0;
        for(int count = 0; count < 100; count++)
        {
            i = downLimit + (upLimit - downLimit) / 2;
            double expect = i * i; 
            double diff = number  -  expect ;
            if (diff < 0 ) {
                diff = -diff;
            }
            if (diff < 0.01d )
            {
                break;
            }else if (expect > number)
            {
                upLimit = i;
            } else
            {
                downLimit = i;
            }
        }

        return (int)(i + 0.5); 

    }
}
