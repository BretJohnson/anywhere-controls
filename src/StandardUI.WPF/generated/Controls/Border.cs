// This file is generated from IBorder.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using Microsoft.StandardUI.Wpf.Media;
using Microsoft.StandardUI.Controls;

namespace Microsoft.StandardUI.Wpf.Controls
{
    public class Border : StandardUIFrameworkElement, IBorder
    {
        public static readonly System.Windows.DependencyProperty BackgroundProperty = PropertyUtils.Register(nameof(Background), typeof(Brush), typeof(Border), null);
        public static readonly System.Windows.DependencyProperty BackgroundSizingProperty = PropertyUtils.Register(nameof(BackgroundSizing), typeof(BackgroundSizing), typeof(Border), "");
        public static readonly System.Windows.DependencyProperty BorderBrushProperty = PropertyUtils.Register(nameof(BorderBrush), typeof(Brush), typeof(Border), null);
        public static readonly System.Windows.DependencyProperty BorderThicknessProperty = PropertyUtils.Register(nameof(BorderThickness), typeof(Thickness), typeof(Border), Thickness.Default);
        public static readonly System.Windows.DependencyProperty ChildProperty = PropertyUtils.Register(nameof(Child), typeof(StandardUIFrameworkElement), typeof(Border), null);
        public static readonly System.Windows.DependencyProperty CornerRadiusProperty = PropertyUtils.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(Border), CornerRadius.Default);
        public static readonly System.Windows.DependencyProperty PaddingProperty = PropertyUtils.Register(nameof(Padding), typeof(Thickness), typeof(Border), Thickness.Default);
        
        public Brush Background
        {
            get => (Brush) GetValue(BackgroundProperty);
            set => SetValue(BackgroundProperty, value);
        }
        IBrush IBorder.Background
        {
            get => Background;
            set => Background = (Brush) value;
        }
        
        public BackgroundSizing BackgroundSizing
        {
            get => (BackgroundSizing) GetValue(BackgroundSizingProperty);
            set => SetValue(BackgroundSizingProperty, value);
        }
        
        public Brush BorderBrush
        {
            get => (Brush) GetValue(BorderBrushProperty);
            set => SetValue(BorderBrushProperty, value);
        }
        IBrush IBorder.BorderBrush
        {
            get => BorderBrush;
            set => BorderBrush = (Brush) value;
        }
        
        public Thickness BorderThickness
        {
            get => (Thickness) GetValue(BorderThicknessProperty);
            set => SetValue(BorderThicknessProperty, value);
        }
        
        public StandardUIFrameworkElement Child
        {
            get => (StandardUIFrameworkElement) GetValue(ChildProperty);
            set => SetValue(ChildProperty, value);
        }
        IUIElement IBorder.Child
        {
            get => Child;
            set => Child = (StandardUIFrameworkElement) value;
        }
        
        public CornerRadius CornerRadius
        {
            get => (CornerRadius) GetValue(CornerRadiusProperty);
            set => SetValue(CornerRadiusProperty, value);
        }
        
        public Thickness Padding
        {
            get => (Thickness) GetValue(PaddingProperty);
            set => SetValue(PaddingProperty, value);
        }
    }
}
