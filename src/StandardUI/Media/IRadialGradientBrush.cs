using System.ComponentModel;

namespace Microsoft.StandardUI.Media
{
    [UIModelObject]
    public interface IRadialGradientBrush : IGradientBrush
    {
        [DefaultValue("0.5,0.5")]
        Point Center { get; set; }

        [DefaultValue("0.5,0.5")]
        Point GradientOrigin { get; set; }

        [DefaultValue(0.5)]
        double RadiusX { get; set; }
    }
}
