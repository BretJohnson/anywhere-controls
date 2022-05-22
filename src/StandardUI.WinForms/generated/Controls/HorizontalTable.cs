// This file is generated from IHorizontalTable.cs. Update the source file to change its contents.

using Microsoft.StandardUI.DefaultImplementations;
using Microsoft.StandardUI.Controls;

namespace Microsoft.StandardUI.WinForms.Controls
{
    public class HorizontalTable : GridBase, IHorizontalTable
    {
        public static readonly UIProperty RowDefinitionsProperty = new UIProperty(nameof(RowDefinitions), null, readOnly:true);
        public static readonly UIProperty ColumnsProperty = new UIProperty(nameof(Columns), null, readOnly:true);
        
        private UICollection<IRowDefinition> _rowDefinitions;
        private UICollection<IColumn> _columns;
        
        public HorizontalTable()
        {
            _rowDefinitions = new UICollection<IRowDefinition>(this);
            SetValue(RowDefinitionsProperty, _rowDefinitions);
            _columns = new UICollection<IColumn>(this);
            SetValue(ColumnsProperty, _columns);
        }
        
        public UICollection<IRowDefinition> RowDefinitions => _rowDefinitions;
        IUICollection<IRowDefinition> IHorizontalTable.RowDefinitions => RowDefinitions;
        
        public UICollection<IColumn> Columns => _columns;
        IUICollection<IColumn> IHorizontalTable.Columns => Columns;
    }
}
