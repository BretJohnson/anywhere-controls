// This file is generated from IStackBase.cs. Update the source file to change its contents.

using UniversalUI.Controls;
using DependencyProperty = System.Windows.DependencyProperty;

namespace UniversalUI.Wpf.Controls
{
    public class StackBase : Panel, IStackBase
    {
        public static readonly DependencyProperty SpacingProperty = PropertyUtils.Register(nameof(Spacing), typeof(double), typeof(StackBase), 0.0);
        
        public double Spacing
        {
            get => (double) GetValue(SpacingProperty);
            set => SetValue(SpacingProperty, value);
        }
    }
}
