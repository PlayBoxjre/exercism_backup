static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if(balance >= 5000)
        {
            return 2.475f ;
        }else if (balance >= 1000)
        {
            return 1.621f ;
        }else if (balance >= 0)
        {
            return .5f ;
        }else
        {
            return 3.213f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        return (decimal)InterestRate(balance) * balance / 100.0m ;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return balance + Interest(balance);
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int index = 0;
        decimal yearTotalBalance  = balance;
        while(yearTotalBalance < targetBalance)
        {
            yearTotalBalance = AnnualBalanceUpdate(yearTotalBalance);
            index++;
        }
        return index;
    }
}
