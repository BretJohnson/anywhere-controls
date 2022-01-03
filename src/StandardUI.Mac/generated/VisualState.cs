// This file is generated from IVisualState.cs. Update the source file to change its contents.

namespace Microsoft.StandardUI.Mac
{
    public class VisualState : StandardUIObject, IVisualState
    {
        public static readonly UIProperty NameProperty = new UIProperty(nameof(Name), "", readOnly:true);
        public static readonly UIProperty SettersProperty = new UIProperty(nameof(Setters), null, readOnly:true);
        
        private UICollection<ISetter> _setters;
        
        public VisualState()
        {
            _setters = new UICollection<ISetter>(this);
            SetValue(SettersProperty, _setters);
        }
        
        public string Name => (string) GetValue(NameProperty);
        
        public UICollection<ISetter> Setters => _setters;
        IUICollection<ISetter> IVisualState.Setters => Setters;
    }
}
