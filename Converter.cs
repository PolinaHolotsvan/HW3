using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW3
{
    internal class Converter
    {
        private decimal _eurRate { get; set; }
        private decimal _usdRate { get; set; }
        public Converter(decimal eur, decimal usd)
        {
            _eurRate = eur;
            _usdRate = usd;
        }

        public decimal USDToUAH(decimal usd)
        {
            return usd*_usdRate;
        }
        
        public decimal UAHToUSD(decimal uah)
        {
            return uah/_usdRate;
        }
        
        public decimal EURToUAH(decimal eur)
        {
            return eur*_eurRate;
        }

        public decimal UAHToEUR(decimal uah)
        {
            return uah/_eurRate;
        }

    }
}
