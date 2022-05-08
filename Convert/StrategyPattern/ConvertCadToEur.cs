namespace Convert.StrategyPattern;

public class ConvertCadToEur : IStrategy
{
    public object Convert(double amount)
    {
        var cadToUsd = amount / 1.34;
        return (cadToUsd * 0.86);
    }
}
