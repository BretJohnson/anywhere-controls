﻿using System;
using System.Windows.Input;
using UniversalUI.Input;

namespace UniversalUI.Wpf.Input;

internal class MousePointerEventArgs : HandleableRoutedEventArgs<MouseEventArgs>, IPointerEventArgs
{
    public MousePointerEventArgs(MouseEventArgs mouseEventArgs) : base(mouseEventArgs)
    {
    }

    public override void InvokeEventHandler(Delegate genericHandler, object genericTarget)
    {
        PointerEventHandler handler = (PointerEventHandler)genericHandler;
        handler(genericTarget, this);
    }
}
