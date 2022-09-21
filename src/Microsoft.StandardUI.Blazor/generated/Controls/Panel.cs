// This file is generated from IPanel.cs. Update the source file to change its contents.

using Microsoft.StandardUI.DefaultImplementations;
using Microsoft.StandardUI.Controls;

namespace Microsoft.StandardUI.Blazor.Controls
{
    public class Panel : BuiltInUIElement, IPanel
    {
        public static readonly UIProperty ChildrenProperty = new UIProperty(nameof(Children), null, readOnly:true);
        
        private UIElementCollection<Microsoft.StandardUI.IUIElement> _children;
        
        public Panel()
        {
            _children = new UIElementCollection<Microsoft.StandardUI.IUIElement>(this);
            SetValue(ChildrenProperty, _children);
        }
        
        public UIElementCollection<Microsoft.StandardUI.IUIElement> Children => _children;
        IUICollection<IUIElement> IPanel.Children => Children.ToStandardUIElementCollection();
    }
}
