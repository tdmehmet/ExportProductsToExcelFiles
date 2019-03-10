using log4net;
using System;
namespace ExportProductsToExcelFiles.Utils
{
    public static class MathUtil
    {
        private static readonly log4net.ILog log = LogManager.GetLogger(typeof(MathUtil));
        public static decimal CalculatePSFIN(decimal price, decimal psf, decimal taxId)
        {
            return psf > (price * (100 + taxId) / (100 * 105 / 100)) ? psf / ((100 + taxId) / 100) : 0;
        }

        public static decimal CalculatePriceByMarjVat(decimal buyingPrice, decimal marj, decimal vat) {
            return buyingPrice * (1 + marj / 100) * (1 + vat / 100);
        }

        public static decimal ConvertPriceFromAEDToTL(decimal aedPrice, decimal currencyFactor) {
            return aedPrice * currencyFactor;
        }


        public static decimal Truncate(decimal number, int digits)
        {
            decimal stepper = (decimal)(Math.Pow(10.0, (double)digits));
            int temp = (int)(stepper * number);
            return (decimal)temp / stepper;
        }
    }
}
