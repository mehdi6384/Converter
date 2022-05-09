// See https://aka.ms/new-console-template for more information

using Convert;

Parallel.Invoke(
        () => Convert(60),
        () => Convert(80)
    );

static void Convert(double amount)
{
    var currencyConverter = CurrencyConverter.GetInstance;
    var result = currencyConverter.Convert("CAD", "EUR", amount);
    Console.WriteLine($"Result of convert {amount} CAD is: {result} EUR");
}
