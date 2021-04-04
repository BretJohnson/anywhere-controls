// This file is generated from ITextBlock.cs. Update the source file to change its contents.

using Microsoft.StandardUI.Media;
using Microsoft.StandardUI.Text;

namespace Microsoft.StandardUI.Controls
{
    public static class TextBlockExtensions
    {
        public static T Foreground<T>(this T textBlock, IBrush value) where T : ITextBlock
        {
            textBlock.Foreground = value;
            return textBlock;
        }
        
        public static T Text<T>(this T textBlock, string value) where T : ITextBlock
        {
            textBlock.Text = value;
            return textBlock;
        }
        
        public static T FontStyle<T>(this T textBlock, FontStyle value) where T : ITextBlock
        {
            textBlock.FontStyle = value;
            return textBlock;
        }
        
        public static T FontWeight<T>(this T textBlock, FontWeight value) where T : ITextBlock
        {
            textBlock.FontWeight = value;
            return textBlock;
        }
        
        public static T FontSize<T>(this T textBlock, double value) where T : ITextBlock
        {
            textBlock.FontSize = value;
            return textBlock;
        }
        
        public static T TextAlignment<T>(this T textBlock, TextAlignment value) where T : ITextBlock
        {
            textBlock.TextAlignment = value;
            return textBlock;
        }
    }
}
