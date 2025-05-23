// This file is generated from IHorizontalStack.cs. Update the source file to change its contents.

using UniversalUI.Controls;

namespace UniversalUI.Wpf.Controls
{
    public class HorizontalStack : StackBase, IHorizontalStack
    {
        protected override System.Windows.Size MeasureOverride(System.Windows.Size constraint) =>
            HorizontalStackLayoutManager.Instance.MeasureOverride(this, constraint.Width, constraint.Height).ToWpfSize();
        
        protected override System.Windows.Size ArrangeOverride(System.Windows.Size arrangeSize) =>
            HorizontalStackLayoutManager.Instance.ArrangeOverride(this, arrangeSize.ToAnywhereControlsSize()).ToWpfSize();
    }
}
