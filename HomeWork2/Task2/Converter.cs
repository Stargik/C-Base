using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Converter
    {
        double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double UahToUsd(double uah)
        {
            return uah / usd;
        }

        public double UahToEur(double uah)
        {
            return uah / eur;
        }

        public double UahToRub(double uah)
        {
            return uah / rub;
        }

        public double UsdToUah(double usd)
        {
            return usd * this.usd;
        }

        public double EurToUah(double eur)
        {
            return eur * this.eur;
        }

        public double RubToUah(double rub)
        {
            return rub * this.rub;
        }
    }
}
