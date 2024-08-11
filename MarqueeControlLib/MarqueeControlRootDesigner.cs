using System;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace MarqueeControlLib
{


    [ToolboxItemFilter("MarqueeControlLibrary.MarqueeBorder", ToolboxItemFilterType.Require)]
    [ToolboxItemFilter("MarqueeControlLibrary.MarqueeText", ToolboxItemFilterType.Require)]
    public class MarqueeControlRootDesigner: DocumentDesigner
    {
        public MarqueeControlRootDesigner()
        {
            Trace.WriteLine("MarqueeControlRootDesigner ctor");
            
        }

        private void OnComponentChanged(
                     object sender,
                     ComponentChangedEventArgs e)
        {
            if (e.Component is IMarqueeWidget)
            {
                this.Control.Refresh();
            }
        }

        private void OnVerbRunTest(object sender, EventArgs e)
        {
            MarqueeControl c = this.Control as MarqueeControl;

            c.Start();
        }

        private void OnVerbStopTest(object sender, EventArgs e)
        {
            MarqueeControl c = this.Control as MarqueeControl;

            c.Stop();
        }

        public override void Initialize(IComponent component)
        {
            base.Initialize(component);

            IComponentChangeService cs =
                GetService(typeof(IComponentChangeService))
                as IComponentChangeService;

            if (cs != null)
            {
                cs.ComponentChanged +=
                    new ComponentChangedEventHandler(OnComponentChanged);
            }

            this.Verbs.Add(
                            new DesignerVerb("Run Test",
                            new EventHandler(OnVerbRunTest))
                            );

            this.Verbs.Add(
                new DesignerVerb("Stop Test",
                new EventHandler(OnVerbStopTest))
                );
        }



    }
}
