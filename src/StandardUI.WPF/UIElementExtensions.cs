using System;

namespace Microsoft.StandardUI.Wpf
{
    public static class UIElementExtensions
    {
        public static System.Windows.UIElement ToWpfUIElement(this IUIElement standardUIElement)
        {
            if (standardUIElement is System.Windows.UIElement wpfUIElement)
                return wpfUIElement;

            if (standardUIElement is NativeUIElement nativeUIElement)
                return nativeUIElement.FrameworkElement;

            throw new InvalidOperationException($"UIElement is of unexpected type '{standardUIElement.GetType()}' and can't be converted to a native WPF UIElement");
        }
    }
}
