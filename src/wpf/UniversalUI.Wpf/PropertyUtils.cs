﻿using System;
using System.Windows;

namespace UniversalUI.Wpf
{
    public static class PropertyUtils
    {
        public static DependencyProperty Register(string propertyName, Type propertyType, Type ownerType, object? defaultValue)
            => DependencyProperty.Register(propertyName, propertyType, ownerType, new PropertyMetadata(defaultValue, OnPropertyChanged));
 
        public static System.Windows.DependencyProperty RegisterAttached(string propertyName, Type propertyType, Type ownerType, object? defaultValue)
        {
            //var propertyMetadata = new PropertyMetadata(defaultValue, OnPropertyChanged);
            return System.Windows.DependencyProperty.RegisterAttached(propertyName, propertyType, ownerType);
        }

        private static void OnPropertyChanged(System.Windows.DependencyObject obj, DependencyPropertyChangedEventArgs e)
        {
            if (obj is IUIPropertyChanged uiPropertyChanged)
            {
                uiPropertyChanged.OnPropertyChanged(e.Property.Name);
            }

            // Not currently used
            /*
            if (!(obj is INotifyObjectOrSubobjectChanged parentObj))
                return;

            // The logic below cascades change notifications from subobjects up the object hierarchy, eventually causing the GraphicsCanvas
            // to be invalidated on any change
            if (e.OldValue is INotifyObjectOrSubobjectChanged oldChildObj)
                oldChildObj.Changed -= parentObj.NotifySinceSubobjectChanged;

            if (e.NewValue is INotifyObjectOrSubobjectChanged newChildObj)
                newChildObj.Changed += parentObj.NotifySinceSubobjectChanged;

            parentObj.NotifySinceObjectChanged();
            */
        }
    }
}
