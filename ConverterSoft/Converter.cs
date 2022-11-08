namespace Converter;

internal interface IConverter
{
    decimal Usd { get; }
    decimal Eur { get; }
    decimal Gbp { get; }

    decimal ConvertToUSD(decimal uah);

    decimal ConvertToUSD(decimal uah, decimal usd);

    decimal ConvertToEUR(decimal uah);

    decimal ConvertToGBP(decimal uah);

    decimal ConvertFromUsd(decimal usd);

    decimal ConvertFromEuro(decimal euro);

    decimal ConvertFromGbp(decimal gbp);
}

internal  sealed class Converter : IConverter
{
    private readonly decimal _usd;
    private readonly decimal _eur;
    private readonly decimal _gbp;

    public Converter(decimal usd, decimal eur, decimal gbp)
    {
        _usd = usd;
        _eur = eur;
        _gbp = gbp;
    }

    public decimal Usd => _usd;

    public decimal Eur => _eur;

    public decimal Gbp => _gbp;

    decimal IConverter.ConvertToUSD(decimal uah)
    {
        return uah / Usd;
    }
    decimal IConverter.ConvertToEUR(decimal uah)
    {
        return uah / Eur;
    }

    decimal IConverter.ConvertToGBP(decimal uah)
    {
        return uah / Gbp;
    }

    decimal IConverter.ConvertFromUsd(decimal usd)
    {
        return usd * Usd;
    }

    decimal IConverter.ConvertFromEuro(decimal euro)
    {
        return euro * Eur;
    }

    decimal IConverter.ConvertFromGbp(decimal gbp)
    {
        return gbp * Gbp;
    }

    decimal IConverter.ConvertToUSD(decimal uah, decimal usd) => uah / usd;
}
