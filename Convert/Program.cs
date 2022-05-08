// See https://aka.ms/new-console-template for more information

using Convert.StrategyPattern;

Parallel.Invoke(
        () => Convert1(),
        () => Convert2()
    );

static void Convert1()
{
    var context = Context.GetInstance;
    context.SetStrategy(new ConvertCadToEur());
    context.ConvertCurrency(60);
}

static void Convert2()
{
    var context = Context.GetInstance;
    context.SetStrategy(new ConvertCadToEur());
    context.ConvertCurrency(80);
}
//Console.WriteLine("Hello, World!");
