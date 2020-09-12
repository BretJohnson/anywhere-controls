﻿using System.StandardUI.Text;

namespace System.StandardUI.Wpf.Text
{
    public struct FontWeightWpf
    {
        public static readonly FontWeightWpf Default = new FontWeightWpf(FontWeights.Normal);

        public static FontWeightWpf FromFontWeight(FontWeight fontWeight) => new FontWeightWpf(fontWeight);

        // Auto properties
        public FontWeight FontWeight { get; }

        public FontWeightWpf(FontWeight fontWeight)
        {
            FontWeight = fontWeight;
        }
    }
}
