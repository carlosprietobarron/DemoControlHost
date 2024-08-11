using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace MarqueeControlLib
{
    [Designer(typeof(MarqueeControlLib.MarqueeControlRootDesigner), typeof(IRootDesigner))]
    public partial class MarqueeControl : UserControl
    {
        public MarqueeControl()
        {
            InitializeComponent();
        }

        public void Start()
        {
            // The MarqueeControl may contain any number of
            // controls that implement IMarqueeWidget, so
            // find each IMarqueeWidget child and call its
            // StartMarquee method.
            foreach (Control cntrl in this.Controls)
            {
                if (cntrl is IMarqueeWidget)
                {
                    IMarqueeWidget widget = cntrl as IMarqueeWidget;
                    widget.StartMarquee();
                }
            }
        }

        public void Stop()
        {
            // The MarqueeControl may contain any number of
            // controls that implement IMarqueeWidget, so find
            // each IMarqueeWidget child and call its StopMarquee
            // method.
            foreach (Control cntrl in this.Controls)
            {
                if (cntrl is IMarqueeWidget)
                {
                    IMarqueeWidget widget = cntrl as IMarqueeWidget;
                    widget.StopMarquee();
                }
            }
        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);

            // Repaint all IMarqueeWidget children if the layout
            // has changed.
            foreach (Control cntrl in this.Controls)
            {
                if (cntrl is IMarqueeWidget)
                {
                    Control control = cntrl as Control;

                    control.PerformLayout();
                }
            }
        }
    }
}
