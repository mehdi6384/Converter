namespace CurrencyConverter.StrategyPattern;

public interface IStrategy
{
    object Convert(double amount);
}
