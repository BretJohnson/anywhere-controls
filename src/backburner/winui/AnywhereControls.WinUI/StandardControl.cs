using System;
using UniversalUI.Controls;
using UniversalUI.WinUI.NativeVisualFramework;
using Microsoft.UI.Xaml;
using Visibility = Microsoft.UI.Xaml.Visibility;

namespace AnywhereControls.WinUI
{
    public class StandardControl : Microsoft.UI.Xaml.Controls.Control, IStandardControl, IStandardControlEnvironmentPeer
    {
        private StandardControlImplementation? _implementation;

#pragma warning disable CS0649 // Field is never assigned to, and will always have its default value null
        private readonly BuiltInUIElement? _buildContent;
#pragma warning restore CS0649

        private bool _invalid = true;

        public StandardControl()
        {
            if (!HostEnvironment.IsInitialized)
            {
                WinUIHostFramework.Init(new WinUINativeVisualFramework());
            }
        }

        protected void InitImplementation(StandardControlImplementation implementation)
        {
            _implementation = implementation;
        }

        void IUIElement.Measure(Size availableSize)
        {
            Measure(availableSize.ToWindowsFoundationSize());
        }

        void IUIElement.Arrange(Rect finalRect)
        {
            Arrange(finalRect.ToWindowsFoundationRect());
        }

        protected override global::Windows.Foundation.Size MeasureOverride(global::Windows.Foundation.Size constraint)
        {
            if (_invalid)
            {
                Rebuild();
                _invalid = false;
            }

            _implementation!.Measure(new Size(constraint.Width, constraint.Height));
            return _implementation.DesiredSize.ToWindowsFoundationSize();
        }

        protected override global::Windows.Foundation.Size ArrangeOverride(global::Windows.Foundation.Size arrangeSize)
        {
            _implementation!.Arrange(new Rect(0, 0, arrangeSize.Width, arrangeSize.Height));
            return arrangeSize;
        }

        Size IUIElement.DesiredSize => SizeExtensions.ToStandardUISize(DesiredSize);

        double IUIElement.ActualX => throw new NotImplementedException();

        double IUIElement.ActualY => throw new NotImplementedException();

        Thickness IUIElement.Margin
        {
            get => Margin.ToStandardUIThickness();
            set => Margin = value.ToWinUIThickness();
        }

        HorizontalAlignment IUIElement.HorizontalAlignment
        {
            get => HorizontalAlignmentExtensions.FromWinUIHorizontalAlignment(this.HorizontalAlignment);
            set => this.HorizontalAlignment = value.ToWinUIHorizontalAlignment();
        }

        VerticalAlignment IUIElement.VerticalAlignment
        {
            get => VerticalAlignmentExtensions.ToStandardUIVerticalAlignment(this.VerticalAlignment);
            set => this.VerticalAlignment = value.ToWinUIVerticalAlignment();
        }

        FlowDirection IUIElement.FlowDirection
        {
            get => FlowDirectionExtensions.ToStandardUIFlowDirection(this.FlowDirection);
            set => this.FlowDirection = value.ToWinUIFlowDirection();
        }

        // TODO: Error if appropriate when set to Visibility.Hidden
        bool IUIElement.Visible
        {
#pragma warning disable CA1033 // Interface methods should be callable by child types
            get => this.Visibility != Visibility.Collapsed;
            set => this.Visibility = value ? Visibility.Visible : Visibility.Collapsed;
#pragma warning restore CA1033 // Interface methods should be callable by child types
        }

        public object? GetValue(IUIProperty dp)
        {
            DependencyProperty dependencyProperty = ((UIProperty)dp).DependencyProperty;
            return GetValue(dependencyProperty);
        }

        public object? ReadLocalValue(IUIProperty dp)
        {
            DependencyProperty dependencyProperty = ((UIProperty)dp).DependencyProperty;
            return ReadLocalValue(dependencyProperty);
        }

        public void ClearValue(IUIProperty property)
        {
            DependencyProperty dependencyProperty = ((UIProperty)property).DependencyProperty;
            ClearValue(dependencyProperty);
        }

        public void SetValue(IUIProperty dp, object? value)
        {
            DependencyProperty wpfDependencyProperty = ((UIProperty)dp).DependencyProperty;
            SetValue(wpfDependencyProperty, value);
        }

#pragma warning disable CA1033 // Interface methods should be callable by child types
        IUIElement? IStandardControlEnvironmentPeer.BuildContent => _buildContent;
#pragma warning restore CA1033 // Interface methods should be callable by child types

#if LATER
        protected override int VisualChildrenCount => _buildContent != null ? 1 : 0;

        protected override Visual GetVisualChild(int index)
        {
            if (_buildContent == null)
                throw new ArgumentOutOfRangeException("index", index, "Control returned null from build");
            if (index != 0)
                throw new ArgumentOutOfRangeException("index", index, "Index out of range; control only has a single visual child.");

            return _buildContent;
        }
#endif

        private void Rebuild()
        {
#if LATER
            if (_buildContent != null)
            {
                RemoveVisualChild(_buildContent);
                RemoveLogicalChild(_buildContent);
                _buildContent = null;
            }

            _buildContent = (BuiltInUIElement?)_implementation.Build();

            if (_buildContent != null)
            {
                AddVisualChild(_buildContent);
                AddLogicalChild(_buildContent);
            }
#endif
        }
    }
}
