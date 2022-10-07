// This file is generated from IPath.cs. Update the source file to change its contents.

using Microsoft.StandardUI.DefaultImplementations;
using Microsoft.StandardUI.Media;
using Microsoft.StandardUI.WinForms.Media;
using Microsoft.StandardUI.Shapes;

namespace Microsoft.StandardUI.WinForms.Shapes
{
    public class Path : Shape, IPath
    {
        public static readonly UIProperty DataProperty = new UIProperty(nameof(Data), null);
        
        public IGeometry Data
        {
            get => (Geometry) GetNonNullValue(DataProperty);
            set => SetValue(DataProperty, value);
        }
        
        public override void Draw(IDrawingContext drawingContext) => drawingContext.DrawPath(this);
    }
}
