// This file is generated from ILinearGradientBrush.cs. Update the source file to change its contents.

using UniversalUI.Media;
using DependencyProperty = Microsoft.UI.Xaml.DependencyProperty;

namespace AnywhereControls.WinUI.Media
{
    public class LinearGradientBrush : GradientBrush, ILinearGradientBrush
    {
        public static readonly DependencyProperty StartPointProperty = PropertyUtils.Register(nameof(StartPoint), typeof(Point), typeof(LinearGradientBrush), default(Point));
        public static readonly DependencyProperty EndPointProperty = PropertyUtils.Register(nameof(EndPoint), typeof(Point), typeof(LinearGradientBrush), default(Point));
        
        public Point StartPoint
        {
            get => (Point) GetValue(StartPointProperty);
            set => SetValue(StartPointProperty, value);
        }
        
        public Point EndPoint
        {
            get => (Point) GetValue(EndPointProperty);
            set => SetValue(EndPointProperty, value);
        }
    }
}
