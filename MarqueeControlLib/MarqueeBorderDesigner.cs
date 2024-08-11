using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace MarqueeControlLib
{
    internal class MarqueeBorderDesigner :System.Windows.Forms.Design.ParentControlDesigner
    {
        public bool Visible
        {
            get
            {
                return (bool)ShadowProperties["Visible"];
            }
            set
            {
                this.ShadowProperties["Visible"] = value;
            }
        }

        public bool Enabled
        {
            get
            {
                return (bool)ShadowProperties["Enabled"];
            }
            set
            {
                this.ShadowProperties["Enabled"] = value;
            }
        }
        protected override void PreFilterProperties(IDictionary properties)
        {
            base.PreFilterProperties(properties);

            if (properties.Contains("Padding"))
            {
                properties.Remove("Padding");
            }

            properties["Visible"] = TypeDescriptor.CreateProperty(
                typeof(MarqueeBorderDesigner),
                (PropertyDescriptor)properties["Visible"],
                new Attribute[0]);

            properties["Enabled"] = TypeDescriptor.CreateProperty(
                typeof(MarqueeBorderDesigner),
                (PropertyDescriptor)properties["Enabled"],
                new Attribute[0]);
        }
    }
}
