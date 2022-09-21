// This file is generated from IGridBase.cs. Update the source file to change its contents.

using Microsoft.StandardUI.DefaultImplementations;
using Microsoft.StandardUI.Controls;

namespace Microsoft.StandardUI.Blazor.Controls
{
    public class GridBase : BuiltInUIElement, IGridBase
    {
        public static readonly UIProperty ColumnSpacingProperty = new UIProperty(nameof(ColumnSpacing), 0.0);
        public static readonly UIProperty RowSpacingProperty = new UIProperty(nameof(RowSpacing), 0.0);
        
        public double ColumnSpacing
        {
            get => (double) GetValue(ColumnSpacingProperty);
            set => SetValue(ColumnSpacingProperty, value);
        }
        
        public double RowSpacing
        {
            get => (double) GetValue(RowSpacingProperty);
            set => SetValue(RowSpacingProperty, value);
        }
    }
}
