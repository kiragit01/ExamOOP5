using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamOOP5
{
    class Converter
    {
        double usd;
        double eur;
        double rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public double ConvertToUsd(double byn) => byn * usd;
        public double ConvertToEur(double byn) => byn * eur;
        public double ConvertToRub(double byn) => byn * rub;

        public double ConvertReversUsd(double count) => count / usd;
        public double ConvertReversEur(double count) => count / eur;
        public double ConvertReversRub(double count) => count / rub;


    }
}
