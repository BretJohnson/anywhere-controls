// This file is generated from ISetter.cs. Update the source file to change its contents.

using System.StandardUI;

namespace System.StandardUI.Wpf
{
    public class Setter : UIPropertyObject, ISetter
    {
        public static readonly Windows.DependencyProperty PropertyProperty = PropertyUtils.Register(nameof(Property), typeof(UIProperty), typeof(Setter), null);
        public static readonly Windows.DependencyProperty TargetProperty = PropertyUtils.Register(nameof(Target), typeof(TargetPropertyPath), typeof(Setter), null);
        public static readonly Windows.DependencyProperty ValueProperty = PropertyUtils.Register(nameof(Value), typeof(object), typeof(Setter), null);
        
        public UIProperty? Property
        {
            get => (UIProperty?) GetValue(PropertyProperty);
            set => SetValue(PropertyProperty, value);
        }
        IUIProperty? ISetter.Property
        {
            get => Property;
            set => Property = (UIProperty?) value;
        }
        
        public TargetPropertyPath Target
        {
            get => (TargetPropertyPath) GetValue(TargetProperty);
            set => SetValue(TargetProperty, value);
        }
        ITargetPropertyPath ISetter.Target
        {
            get => Target;
            set => Target = (TargetPropertyPath) value;
        }
        
        public object Value
        {
            get => (object) GetValue(ValueProperty);
            set => SetValue(ValueProperty, value);
        }
    }
}
