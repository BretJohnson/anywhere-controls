// This file is generated from IGradientStop.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using DependencyProperty = System.Windows.DependencyProperty;

namespace Microsoft.StandardUI.Wpf.Media
{
    public class GradientStop : StandardUIDependencyObject, IGradientStop
    {
        public static readonly DependencyProperty ColorProperty = PropertyUtils.Register(nameof(Color), typeof(ColorWpf), typeof(GradientStop), ColorWpf.Default);
        public static readonly DependencyProperty OffsetProperty = PropertyUtils.Register(nameof(Offset), typeof(double), typeof(GradientStop), 0.0);
        
        public ColorWpf Color
        {
            get => (ColorWpf) GetValue(ColorProperty);
            set => SetValue(ColorProperty, value);
        }
        Color IGradientStop.Color
        {
            get => Color.Color;
            set => Color = new ColorWpf(value);
        }
        
        public double Offset
        {
            get => (double) GetValue(OffsetProperty);
            set => SetValue(OffsetProperty, value);
        }
    }
}
