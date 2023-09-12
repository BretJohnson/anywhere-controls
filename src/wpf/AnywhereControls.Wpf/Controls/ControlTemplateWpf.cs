﻿using AnywhereControls.Controls;

namespace AnywhereControls.Wpf
{
    public class ControlTemplateWpf : IControlTemplate
    {
        private System.Windows.Controls.ControlTemplate _controlTemplate;

        public ControlTemplateWpf(System.Windows.Controls.ControlTemplate controlTemplate)
        {
            _controlTemplate = controlTemplate;
        }

        public System.Windows.Controls.ControlTemplate ControlTemplate => _controlTemplate;
    }
}
