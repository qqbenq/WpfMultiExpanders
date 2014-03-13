using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace ExpanderTest
{
    public class ExpanderMaxHeightConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return Math.Max(0, (double)value - (int.Parse((string)parameter) * 30)); // number of expanders in view multiplied by height of their header and spacing...
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
           throw new NotSupportedException();
        }
    }
}
