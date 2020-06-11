using System;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace CoronaLive.Classes
{
    public class Brush : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int? input = (int?)value;
            var brush = new SolidColorBrush(Color.FromRgb(252, 50, 57));
            if (input != null) return brush;
            else return DependencyProperty.UnsetValue;

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }

    public class Brush1 : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int? input = (int?)value;
            var brush = new SolidColorBrush(Color.FromRgb(255, 238, 170));
            if (input != null) return brush;
            else return DependencyProperty.UnsetValue;

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }

    public class BrushText : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int? input = (int?)value;
            var brush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            if (input != null) return brush;
            else return DependencyProperty.UnsetValue;

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
    public class BrushGreen : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int input = (int)value;
            var brush = new SolidColorBrush(Color.FromRgb(50, 168, 82));
            if (input != 0) return brush;
            else return DependencyProperty.UnsetValue;

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }

    public class BrushGreenText : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            int input = (int)value;
            var brush = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            if (input != 0) return brush;
            else return DependencyProperty.UnsetValue;

        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }
    }
}
