using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class CurrencyConverter
    {
        private IEnumerable<ExchangeRate> _exchangeRates;

        // first we need to make the constructor private not public
        private CurrencyConverter()
        {
            LoadExchangeRates();
        }

        // we make a static variable with the same name of class
        // eager instailation لو حجم الداتا مش كبير ومفيش استهلال للمميوري كثير 
        //private static CurrencyConverter _instance = new ();


        // lazy initation بحطه لما احتاجة مع اول كول
        private static CurrencyConverter _instance;

        private static object _lock = new ();

        // we incapsulate this varibale in static property
        public static CurrencyConverter Instance
        {
            get
            {
                if (_instance == null)
                {
                    // to solve multi threading problem we need to make a lock 
                    // لو اثنين ثريد دخلوا واحد هيدخل والباقي يستني
                    lock (_lock)
                    {
                        if (_instance == null)
                            _instance = new();
                    }
                }
                return _instance;
            }
        }
        
        private void LoadExchangeRates()
        {
            Thread.Sleep( 3000 ); // waitiing for 3 seconds to simulate heavy work

            _exchangeRates = new[]
            {
                new ExchangeRate("USD","SAR",3.75m),
                new ExchangeRate("USD","EGP",30.60m),
                new ExchangeRate("SAR","EGP",8.16m)
            };
        }

        public decimal Convert(string baseCurrencym ,string targetCurrency, decimal amount)
        {
            var exchangeRate = _exchangeRates.FirstOrDefault(rate=>rate.BaseCurrency==baseCurrencym && rate.TargetCurrency == targetCurrency) ;
            return amount * exchangeRate.Rate;
        }
    }
}
