// This file is generated from ITextBlock.cs. Update the source file to change its contents.

using Microsoft.StandardUI.DefaultImplementations;
using Microsoft.StandardUI.Media;
using Microsoft.StandardUI.Blazor.Media;
using Microsoft.AspNetCore.Components;
using Microsoft.StandardUI.Text;
using Microsoft.StandardUI.Controls;

namespace Microsoft.StandardUI.Blazor.Controls
{
    public class TextBlock : BuiltInUIElement, ITextBlock
    {
        public static readonly UIProperty ForegroundProperty = new UIProperty(nameof(Foreground), null);
        public static readonly UIProperty TextProperty = new UIProperty(nameof(Text), "");
        public static readonly UIProperty FontFamilyProperty = new UIProperty(nameof(FontFamily), "");
        public static readonly UIProperty FontStyleProperty = new UIProperty(nameof(FontStyle), FontStyle.Normal);
        public static readonly UIProperty FontWeightProperty = new UIProperty(nameof(FontWeight), FontWeight.Default);
        public static readonly UIProperty FontSizeProperty = new UIProperty(nameof(FontSize), 11.0);
        public static readonly UIProperty FontStretchProperty = new UIProperty(nameof(FontStretch), FontStretch.Normal);
        public static readonly UIProperty TextAlignmentProperty = new UIProperty(nameof(TextAlignment), TextAlignment.Left);
        
        [Parameter]
        public IBrush Foreground
        {
            get => (Brush) GetNonNullValue(ForegroundProperty);
            set => SetValue(ForegroundProperty, value);
        }
        
        [Parameter]
        public string Text
        {
            get => (string) GetNonNullValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        
        [Parameter]
        public FontFamily FontFamily
        {
            get => (FontFamily) GetNonNullValue(FontFamilyProperty);
            set => SetValue(FontFamilyProperty, value);
        }
        
        [Parameter]
        public FontStyle FontStyle
        {
            get => (FontStyle) GetNonNullValue(FontStyleProperty);
            set => SetValue(FontStyleProperty, value);
        }
        
        [Parameter]
        public FontWeight FontWeight
        {
            get => (FontWeight) GetNonNullValue(FontWeightProperty);
            set => SetValue(FontWeightProperty, value);
        }
        
        [Parameter]
        public double FontSize
        {
            get => (double) GetNonNullValue(FontSizeProperty);
            set => SetValue(FontSizeProperty, value);
        }
        
        [Parameter]
        public FontStretch FontStretch
        {
            get => (FontStretch) GetNonNullValue(FontStretchProperty);
            set => SetValue(FontStretchProperty, value);
        }
        
        [Parameter]
        public TextAlignment TextAlignment
        {
            get => (TextAlignment) GetNonNullValue(TextAlignmentProperty);
            set => SetValue(TextAlignmentProperty, value);
        }
        
        public override void Draw(IDrawingContext drawingContext) => drawingContext.DrawTextBlock(this);
    }
}
