namespace UniversalUI.Wpf
{
    public static class ThicknessExtensions
    {
        public static System.Windows.Thickness ToWpfThickness(this Thickness thickness) =>
            new System.Windows.Thickness(thickness.Left, thickness.Top, thickness.Right, thickness.Bottom);

        public static Thickness ToAnywhereControlsThickness(this System.Windows.Thickness thickness) =>
            new Thickness(thickness.Left, thickness.Top, thickness.Right, thickness.Bottom);
    }
}
