// This file is generated from IPolyline.cs. Update the source file to change its contents.

using UniversalUI;
using UniversalUI.Media;
using UniversalUI.Shapes;
using AvaloniaProperty = Avalonia.AvaloniaProperty;

namespace AnywhereControlsAvalonia.Shapes
{
    public class Polyline : Shape, IPolyline, IDrawable
    {
        public static readonly Avalonia.StyledProperty<FillRule> FillRuleProperty = AvaloniaProperty.Register<Polyline, FillRule>(nameof(FillRule), FillRule.EvenOdd);
        public static readonly Avalonia.StyledProperty<Points> PointsProperty = AvaloniaProperty.Register<Polyline, Points>(nameof(Points), Points.Default);
        
        public FillRule FillRule
        {
            get => (FillRule) GetValue(FillRuleProperty);
            set => SetValue(FillRuleProperty, value);
        }
        
        public Points Points
        {
            get => (Points) GetValue(PointsProperty);
            set => SetValue(PointsProperty, value);
        }
        
        public void Draw(IDrawingContext drawingContext) => drawingContext.DrawPolyline(this);
    }
}
