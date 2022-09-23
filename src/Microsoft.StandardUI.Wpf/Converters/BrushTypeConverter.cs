using System.ComponentModel;
using System.Globalization;
using Microsoft.StandardUI.Converters;
using Microsoft.StandardUI.Wpf.Media;

namespace Microsoft.StandardUI.Wpf.Converters
{
    public class BrushTypeConverter : TypeConverterBase
    {
        public override object ConvertFrom(ITypeDescriptorContext context, CultureInfo culture, object valueObject)
        {
            return new SolidColorBrush
            {
                Color = new ColorWpf(ColorConverter.ConvertFromString(GetValueAsString(valueObject)))
            };
        }
    }
}
