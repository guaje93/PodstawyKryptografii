using Keys;
using Messages;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Converters
{

    public class BigIntToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {

            BigInteger buffer = value as BigInteger;
            return buffer?.ToString();
        }


        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            string text = value as string;
            return Encoding.ASCII.GetBytes(text);
        }
    }

    public class BigIntToString2Converter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {

            BigInteger buffer = value as BigInteger;
            return buffer?.ToString();
        }


        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            string text = value as string;
            var bytes = Encoding.ASCII.GetBytes(text);
            return new BigInteger(bytes);
        }
    }
    public class KeyPConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            Key Key = value as Key;
            return Key?.KeyValue.ToString();
        }


        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class ByteToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            if (value != null)
                return new BigInteger(value as byte[])?.ToString();
            return "";
        }


        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return null;
        }
    }

    public class CipheredC1FileConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            var cipher = value as CipheredFileMessage;
            if (cipher != null)
                return new BigInteger(cipher.HashC1)?.ToString();
            return "";
        }


        public object ConvertBack(object value, Type targetType,
            object parameter, CultureInfo culture)
        {
            return null;
        }
    }

}
