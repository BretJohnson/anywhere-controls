// This file is generated from IPolyQuadraticBezierSegment.cs. Update the source file to change its contents.

using UniversalUI.Media;
using DependencyProperty = System.Windows.DependencyProperty;

namespace UniversalUI.Wpf.Media
{
    public class PolyQuadraticBezierSegment : PathSegment, IPolyQuadraticBezierSegment
    {
        public static readonly DependencyProperty PointsProperty = PropertyUtils.Register(nameof(Points), typeof(Points), typeof(PolyQuadraticBezierSegment), Points.Default);
        
        public Points Points
        {
            get => (Points) GetValue(PointsProperty);
            set => SetValue(PointsProperty, value);
        }
    }
}
