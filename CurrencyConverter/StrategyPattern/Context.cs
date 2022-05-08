namespace CurrencyConverter.StrategyPattern;

public class Context
{
    private IStrategy _strategy;

    public Context()
    { }

    public Context(IStrategy strategy)
    {
        _strategy = strategy;
    }

    public void SetStrategy(IStrategy strategy) 
    {
        _strategy = strategy;
    }

    public void ConvertCurrency(double amount)
    {
        var result = _strategy.Convert(amount);

        Console.WriteLine($"Result of convert is: {result}");
    }
}
