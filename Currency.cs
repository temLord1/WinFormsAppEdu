using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppEdu
{
    internal class Currency
    {
        public string CurrencyName { get; set; }
        public string StringCode { get; set; }
        public double ExchangeRate { get; set; }
        public double Quantity { get; set; }

        public Currency(string name, string strCode, double exchangeRate, double quantity)
        {
            CurrencyName = name;
            StringCode = strCode;
            ExchangeRate = exchangeRate;
            Quantity = quantity;

        }

        public double ExchangeTo(Currency currency, double amount) 
        {
            double sourceUnitPrice = this.ExchangeRate / this.Quantity;
            double targetUnitPrice = currency.ExchangeRate / currency.Quantity;
            return (sourceUnitPrice) / (targetUnitPrice) * amount; 
        }
    }
}
