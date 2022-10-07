// This file is generated from IPathFigure.cs. Update the source file to change its contents.

using Microsoft.StandardUI.DefaultImplementations;
using Microsoft.AspNetCore.Components;
using Microsoft.StandardUI.Media;

namespace Microsoft.StandardUI.Blazor.Media
{
    public class PathFigure : StandardUIObject, IPathFigure
    {
        public static readonly UIProperty SegmentsProperty = new UIProperty(nameof(Segments), null, readOnly:true);
        public static readonly UIProperty StartPointProperty = new UIProperty(nameof(StartPoint), Point.Default);
        public static readonly UIProperty IsClosedProperty = new UIProperty(nameof(IsClosed), false);
        public static readonly UIProperty IsFilledProperty = new UIProperty(nameof(IsFilled), true);
        
        private UICollection<IPathSegment> _segments;
        
        public PathFigure()
        {
            _segments = new UICollection<IPathSegment>(this);
            SetValue(SegmentsProperty, _segments);
        }
        
        public IUICollection<IPathSegment> Segments => (UICollection<IPathSegment>) GetNonNullValue(SegmentsProperty);
        
        [Parameter]
        public Point StartPoint
        {
            get => (Point) GetNonNullValue(StartPointProperty);
            set => SetValue(StartPointProperty, value);
        }
        
        [Parameter]
        public bool IsClosed
        {
            get => (bool) GetNonNullValue(IsClosedProperty);
            set => SetValue(IsClosedProperty, value);
        }
        
        [Parameter]
        public bool IsFilled
        {
            get => (bool) GetNonNullValue(IsFilledProperty);
            set => SetValue(IsFilledProperty, value);
        }
    }
}
