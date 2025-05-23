using System.ComponentModel;
using System.Globalization;
using UniversalUI.Wpf.Media;
using UniversalUI.Converters;

namespace UniversalUI.Wpf.Converters
{
    public class BrushTypeConverter : TypeConverterBase
    {
        public override object ConvertFrom(ITypeDescriptorContext? context, CultureInfo culture, object valueObject) =>
            new SolidColorBrush
            {
                Color = ColorConverter.ConvertFromString(GetValueAsString(valueObject))
            };
    }
}
