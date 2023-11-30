namespace SingletonPattern
{
    public class ExchangeRate
    {

        public ExchangeRate(string baseCurrency, string targetCurrency, decimal rate)
        {
           BaseCurrency = baseCurrency;
           TargetCurrency = targetCurrency;   
           Rate = rate;
        }

        public string BaseCurrency { get; set; }
        public string TargetCurrency { get; set; }
        public decimal Rate { get; set; }

    }
}