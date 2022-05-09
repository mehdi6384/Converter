namespace Convert;

public interface ICurrencyConverter
{
    /// <summary>
    /// Converts the specified amount to the desired currency.
    /// </summary>
    double Convert(string fromCurrency, string toCurrency, double amount);
}
