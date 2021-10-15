﻿using System;

namespace Microsoft.StandardUI.Wpf.NativeVisualEnvironment
{
    public class WpfNativeVisualEnvironment : IVisualEnvironment
    {
        public IDrawingContext CreateDrawingContext(in Rect cullingRect) => new WpfNativeDrawingContext(cullingRect);

        public void RenderToBuffer(IVisual visual, IntPtr pixels, int width, int height, int rowBytes)
        {
            throw new NotImplementedException();
        }

        public IVisualHostControl CreateHostControl(object? arg1 = null, object? arg2 = null, object? arg3 = null)
        {
            throw new NotImplementedException();
        }
    }
}
