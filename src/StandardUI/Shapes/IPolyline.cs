﻿using System.StandardUI.Media;

namespace System.StandardUI.Shapes
{
    [UIModelObject]
    public interface IPolyline : IShape
    {
        [DefaultValue(FillRule.EvenOdd)]
        FillRule FillRule { get; set; }

        Points Points { get; set; }
    }
}
