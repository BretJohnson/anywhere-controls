// This file is generated from ILine.cs. Update the source file to change its contents.

using UniversalUI.Shapes;
using BindableProperty = Microsoft.Maui.Controls.BindableProperty;

namespace UniversalUI.Maui.Shapes
{
    public class Line : Shape, ILine, IDrawable
    {
        public static readonly BindableProperty X1Property = PropertyUtils.Register(nameof(X1), typeof(double), typeof(Line), 0.0);
        public static readonly BindableProperty Y1Property = PropertyUtils.Register(nameof(Y1), typeof(double), typeof(Line), 0.0);
        public static readonly BindableProperty X2Property = PropertyUtils.Register(nameof(X2), typeof(double), typeof(Line), 0.0);
        public static readonly BindableProperty Y2Property = PropertyUtils.Register(nameof(Y2), typeof(double), typeof(Line), 0.0);
        
        public double X1
        {
            get => (double) GetValue(X1Property);
            set => SetValue(X1Property, value);
        }
        
        public double Y1
        {
            get => (double) GetValue(Y1Property);
            set => SetValue(Y1Property, value);
        }
        
        public double X2
        {
            get => (double) GetValue(X2Property);
            set => SetValue(X2Property, value);
        }
        
        public double Y2
        {
            get => (double) GetValue(Y2Property);
            set => SetValue(Y2Property, value);
        }
        
        public void Draw(IDrawingContext drawingContext) => drawingContext.DrawLine(this);
    }
}
