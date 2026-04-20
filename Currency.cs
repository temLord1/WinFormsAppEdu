using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsAppEdu
{
    internal abstract class Currency
    {
        public abstract string CurrencyName { get; }
        public abstract string StringCode { get; }
        public abstract double ExchangeRate { get; }
        public abstract double Quantity { get; }

        public double ExchangeTo(Currency currency, double amount) 
        {
            double sourceUnitPrice = this.ExchangeRate / this.Quantity;
            double targetUnitPrice = currency.ExchangeRate / currency.Quantity;
            return (sourceUnitPrice) / (targetUnitPrice) * amount; 
        }
    }

    internal class RuRuble : Currency
    {
        public override string CurrencyName { get => "Российский рубль"; }
        public override string StringCode { get => "RUB"; }
        public override double ExchangeRate { get => 1; }
        public override double Quantity { get => 1; }
    }

    internal class Dollar : Currency
    {
        public override string CurrencyName { get => "Доллар США"; }
        public override string StringCode { get => "USD"; }
        public override double ExchangeRate { get => 76.0535; }
        public override double Quantity { get => 1; }
    }

    internal class Euro : Currency
    {
        public override string CurrencyName { get => "Евро"; }
        public override string StringCode { get => "EUR"; }
        public override double ExchangeRate { get => 89.6256; }
        public override double Quantity { get => 1; }
    }

    internal class Tenge : Currency
    {
        public override string CurrencyName { get => "Тенге"; }
        public override string StringCode { get => "KZT"; }
        public override double ExchangeRate { get => 16.1315; }
        public override double Quantity { get => 100; }
    }

    internal class Yuan : Currency
    {
        public override string CurrencyName { get => "Юань"; }
        public override string StringCode { get => "CNY"; }
        public override double ExchangeRate { get => 11.1457; }
        public override double Quantity { get => 1; }
    }

    internal class Yen : Currency
    {
        public override string CurrencyName { get => "Иен"; }
        public override string StringCode { get => "JPY"; }
        public override double ExchangeRate { get => 47.6824; }
        public override double Quantity { get => 100; }
    }

    internal class Won : Currency
    {
        public override string CurrencyName { get => "Вон"; }
        public override string StringCode { get => "KRW"; }
        public override double ExchangeRate { get => 51.6457; }
        public override double Quantity { get => 1000; }
    }
    internal class BelRuble : Currency
    {
        public override string CurrencyName { get => "Белорусский рубль"; }
        public override string StringCode { get => "BYN"; }
        public override double ExchangeRate { get => 26.8352; }
        public override double Quantity { get => 1; }
    }
}
