// This file is generated from IStack.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Controls;
using DependencyProperty = System.Windows.DependencyProperty;

namespace Microsoft.StandardUI.Wpf.Controls
{
    public class Stack : StackBase, IStack
    {
        public static readonly DependencyProperty OrientationProperty = PropertyUtils.Register(nameof(Orientation), typeof(Orientation), typeof(Stack), Orientation.Vertical);
        
        public Orientation Orientation
        {
            get => (Orientation) GetValue(OrientationProperty);
            set => SetValue(OrientationProperty, value);
        }
        
        protected override System.Windows.Size MeasureOverride(System.Windows.Size constraint) =>
            StackLayoutManager.Instance.MeasureOverride(this, constraint.ToStandardUISize()).ToWpfSize();
        
        protected override System.Windows.Size ArrangeOverride(System.Windows.Size arrangeSize) =>
            StackLayoutManager.Instance.ArrangeOverride(this, arrangeSize.ToStandardUISize()).ToWpfSize();
    }
}
