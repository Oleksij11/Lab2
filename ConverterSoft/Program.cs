namespace Converter;

internal static class Program
{
    private const decimal Usd = 40M;
    private const decimal Eur = 39.8M;
    private const decimal Gbp = 42M;

    static void Main(string[] args)
    {
        IConverter converter = new Converter(Usd, Eur, Gbp);

        while (true)
        {
            Console.Clear();

            Console.WriteLine("Enter the amount of money in UAH: ");
            decimal amount = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Choose the currency to convert: ");
            Console.WriteLine("1. USD");
            Console.WriteLine("2. EUR");
            Console.WriteLine("3. GBP");

            if(!int.TryParse(Console.ReadLine(), out int currency))
            {
                Console.WriteLine("Incorrect input");
                Console.ReadKey();
                continue;
            }
            string resultText = currency switch
            {
                1 => $"You will get {converter.ConvertToUSD(amount)} USD",
                2 => $"You will get {converter.ConvertToEUR(amount)} EUR",
                3 => $"You will get {converter.ConvertToGBP(amount)} GBP",
                _ => "Error"
            };

            Console.WriteLine(resultText);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
