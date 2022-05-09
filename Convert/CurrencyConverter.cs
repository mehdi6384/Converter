using Convert.Common;
using Convert.StrategyPattern;

namespace Convert;

public class CurrencyConverter : ICurrencyConverter
{
    private static CurrencyConverter _instance = null;
    private static object _obj = new Object();

    public static CurrencyConverter GetInstance
    {
        get
        {
            if(_instance == null)
            {
                lock(_obj)
                {
                    if(_instance == null)
                    {
                        _instance = new CurrencyConverter();
                    }
                }
            }
            return _instance;
        }
    }

    public double Convert(string fromCurrency, string toCurrency, double amount)
    {
        var context = Context.GetInstance;
        switch (CastToEnum(fromCurrency, toCurrency))
        {
            case ConverterPath.CADTOERU:
                {
                    context.SetStrategy(new ConvertCadToEur());
                }
                break;
            default:
                {
                    throw new Exception("The path not found!");
                }
        }
        return context.ConvertCurrency(amount);
    }

    private ConverterPath CastToEnum(string fromCurrency, string toCurrency)
    {
        switch(fromCurrency, toCurrency)
        {
            case ("CAD","EUR"):
                return ConverterPath.CADTOERU;
            default:
                break;
        }
        return ConverterPath.DEFAULT;
    }
}
