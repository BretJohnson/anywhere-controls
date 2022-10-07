using System;
using Microsoft.StandardUI.Controls;
using SkiaSharp;

namespace Microsoft.StandardUI.SkiaVisualFramework
{
    public abstract class SkiaVisualFramework : IVisualFramework
    {
        public IDrawingContext CreateDrawingContext(IUIElement uiElement) => new SkiaDrawingContext();

        public void RenderToBuffer(IVisual visual, IntPtr pixels, int width, int height, int rowBytes)
        {
            SkiaVisual skiaVisual = (SkiaVisual)visual;

            var info = new SKImageInfo(width, height, SKImageInfo.PlatformColorType, SKAlphaType.Premul);

            using (SKSurface surface = SKSurface.Create(info, pixels, rowBytes))
            {
                surface.Canvas.DrawPicture(skiaVisual.SKPicture);
            }
        }

        public abstract IVisualHostControl CreateHostControl(object? arg1 = null, object? arg2 = null, object? arg3 = null);

        public Size MeasureTextBlock(ITextBlock textBlock)
        {
            throw new NotImplementedException();
        }
    }
}
