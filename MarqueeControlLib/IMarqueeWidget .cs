using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarqueeControlLib
{
    // This interface defines the contract for any class that is to
    // be used in constructing a MarqueeControl.
    public interface IMarqueeWidget
    {
        // This method starts the animation. If the control can
        // contain other classes that implement IMarqueeWidget as
        // children, the control should call StartMarquee on all
        // its IMarqueeWidget child controls.
        void StartMarquee();

        // This method stops the animation. If the control can
        // contain other classes that implement IMarqueeWidget as
        // children, the control should call StopMarquee on all
        // its IMarqueeWidget child controls.
        void StopMarquee();

        // This method specifies the refresh rate for the animation,
        // in milliseconds.
        int UpdatePeriod
        {
            get;
            set;
        }
    }
}
