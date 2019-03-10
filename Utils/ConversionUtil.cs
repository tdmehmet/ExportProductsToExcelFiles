using System;

namespace ExportProductsToExcelFiles.Utils
{
    public static class ConversionUtil
    {
        public static int? ConvertStringToIntNotParsableNull(string stringVal)
        {
            bool parsed = int.TryParse(stringVal, out int parsedValue);
            if (parsed) return parsedValue; else return null;
        }

        public static int ConvertStringToIntNotParsable0(string stringVal)
        {
            bool parsed = int.TryParse(stringVal, out int parsedValue);
            if (parsed) return parsedValue; else return 0;
        }

        public static decimal? ConvertStringToDecimalNotParsableNull(string stringVal)
        {
            bool parsed = decimal.TryParse(stringVal, out decimal parsedValue);
            if (parsed) return parsedValue; else return null;
        }

        public static decimal ConvertStringToDecimalNotParsable0(string stringVal)
        {
            bool parsed = decimal.TryParse(stringVal, out decimal parsedValue);
            if (parsed) return parsedValue; else return 0;
        }

        public static double? ConvertStringToDoubleNotParsableNull(string stringVal)
        {
            bool parsed = double.TryParse(stringVal, out double parsedValue);
            if (parsed) return parsedValue; else return null;
        }

        public static double ConvertStringToDoubleNotParsable0(string stringVal)
        {
            bool parsed = double.TryParse(stringVal, out double parsedValue);
            if (parsed) return parsedValue; else return 0;
        }

        public static int ConvertNullableDecimalToIntIfNullNotParsable0(decimal? decimalVal)
        {
            if (decimalVal == null) return 0;
            return int.Parse(Math.Round(decimalVal.Value, 0).ToString(), System.Globalization.CultureInfo.InvariantCulture);
        }

        public static double ConvertNullableDecimalToDoubleIfNullNotParsable0(decimal? decimalVal)
        {
            if (decimalVal == null) return 0;
            bool parsable = double.TryParse(decimalVal.ToString(), out double parsedValue);
            if (!parsable) return 0;
            return double.Parse(decimalVal.Value.ToString(), System.Globalization.CultureInfo.InvariantCulture);
        }

        public static double ConvertNullableDoubleToDoubleIfNull0(double? doubleVal)
        {
            return doubleVal ?? 0;
        }

        public static decimal ConvertNullableDoubleToDecimalIfNull1(double? doubleVal)
        {
            if (doubleVal == null) return 1;
            bool parsable = decimal.TryParse(doubleVal.ToString(), out decimal parsedValue);
            if (!parsable) return 0;
            return decimal.Parse(doubleVal.Value.ToString(), System.Globalization.CultureInfo.InvariantCulture);
        }

        public static decimal ConvertDoubleToDecimal(double doubleVal)
        {
            bool parsed = decimal.TryParse(doubleVal.ToString(), out decimal parsedValue);
            if (parsed)
                return decimal.Parse(doubleVal.ToString(), System.Globalization.CultureInfo.InvariantCulture);
            else
                return 0;
        }

        public static double ConvertDecimalToDouble(decimal decimalVal)
        {
            return double.Parse(decimalVal.ToString(), System.Globalization.CultureInfo.InvariantCulture);
        }

        public static decimal ConvertIntToDecimal(int intVal)
        {
            return decimal.Parse(intVal.ToString(), System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}
