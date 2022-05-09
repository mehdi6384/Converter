namespace Convert.StrategyPattern;

public sealed class Context
{
    private IStrategy _strategy;
    private static Context _instance = null;
    private static object _obj = new Object();

    public static Context GetInstance
    {
        get
        {
            if (_instance == null)
            {
                lock (_obj)
                {
                    if (_instance == null)
                    {
                        _instance = new Context();
                    }
                }
            }

            return _instance;
        }
    }

    public void SetStrategy(IStrategy strategy) 
    {
        _strategy = strategy;
    }

    public double ConvertCurrency(double amount)
    {
        return _strategy.Convert(amount);
    }
}
