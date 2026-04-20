using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppEdu
{
    internal class Ruble : Currency
    {
        public override string CurrencyName { get => "Российский рубль"; }
        public override string DigitCode { get => "643"; }
        public override string StringCode { get => "RUB"; }
        public override double ExchangeRate { get => 1; }
        public override double Quantity { get => 1; }
        
    }
}
