// This file is generated from IStack.cs. Update the source file to change its contents.

using Microsoft.StandardUI.DefaultImplementations;
using Microsoft.StandardUI.Controls;

namespace Microsoft.StandardUI.WinForms.Controls
{
    public class Stack : StackBase, IStack
    {
        public static readonly UIProperty OrientationProperty = new UIProperty(nameof(Orientation), Orientation.Vertical);
        
        public Orientation Orientation
        {
            get => (Orientation) GetNonNullValue(OrientationProperty);
            set => SetValue(OrientationProperty, value);
        }
    }
}
