using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace MarqueeControlLib
{
    [ToolboxItemFilter("MarqueeControlLibrary.MarqueeText", ToolboxItemFilterType.Require)]
    public partial class MarqueeText : Label, IMarqueeWidget
    {
        // When isLit is true, the text is painted in the light color;
        // When isLit is false, the text is painted in the dark color.
        // This value changes whenever the BackgroundWorker component
        // raises the ProgressChanged event.
        private bool isLit = true;

        // These fields back the public properties.
        private int updatePeriodValue = 50;
        private Color lightColorValue;
        private Color darkColorValue;
        
        [Category("Marquee")]
        [Browsable(true)]
        public Color LightColor
        {
            get
            {
                return this.lightColorValue;
            }
            set
            {
                // The LightColor property is only changed if the
                // client provides a different value. Comparing values
                // from the ToArgb method is the recommended test for
                // equality between Color structs.
                if (this.lightColorValue.ToArgb() != value.ToArgb())
                {
                    this.lightColorValue = value;
                    this.lightBrush = new SolidBrush(value);
                }
            }
        }

        [Category("Marquee")]
        [Browsable(true)]
        public Color DarkColor
        {
            get
            {
                return this.darkColorValue;
            }
            set
            {
                // The DarkColor property is only changed if the
                // client provides a different value. Comparing values
                // from the ToArgb method is the recommended test for
                // equality between Color structs.
                if (this.darkColorValue.ToArgb() != value.ToArgb())
                {
                    this.darkColorValue = value;
                    this.darkBrush = new SolidBrush(value);
                }
            }
        }

        // These brushes are used to paint the light and dark
        // colors of the text.
        private Brush lightBrush;
        private Brush darkBrush;

        // This component updates the control asynchronously.
        private BackgroundWorker _backgroundWorker1;

        public MarqueeText()
        {
            // This call is required by the Windows.Forms Form Designer.
            InitializeComponent();

            // Initialize light and dark colors
            // to the control's default values.
            this.lightColorValue = this.ForeColor;
            this.darkColorValue = this.BackColor;
            this.lightBrush = new SolidBrush(this.lightColorValue);
            this.darkBrush = new SolidBrush(this.darkColorValue);
        }

        //implement interface
        public virtual void StartMarquee()
        {
            // Start the updating thread and pass it the UpdatePeriod.
            this.backgroundWorker1.RunWorkerAsync(this.UpdatePeriod);
        }

        public virtual void StopMarquee()
        {
            // Stop the updating thread.
            this.backgroundWorker1.CancelAsync();
        }

        [Category("Marquee")]
        [Browsable(true)]
        public int UpdatePeriod
        {
            get
            {
                return this.updatePeriodValue;
            }

            set
            {
                if (value > 0)
                {
                    this.updatePeriodValue = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("UpdatePeriod", "must be > 0");
                }
            }
        }

        // This method is called in the worker thread's context,
        // so it must not make any calls into the MarqueeText control.
        // Instead, it communicates to the control using the
        // ProgressChanged event.
        //
        // The only work done in this event handler is
        // to sleep for the number of milliseconds specified
        // by UpdatePeriod, then raise the ProgressChanged event.
        private void backgroundWorker1_DoWork(
            object sender,
            System.ComponentModel.DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            // This event handler will run until the client cancels
            // the background task by calling CancelAsync.
            while (!worker.CancellationPending)
            {
                // The Argument property of the DoWorkEventArgs
                // object holds the value of UpdatePeriod, which
                // was passed as the argument to the RunWorkerAsync
                // method.
                Thread.Sleep((int)e.Argument);

                // The DoWork eventhandler does not actually report
                // progress; the ReportProgress event is used to
                // periodically alert the control to update its state.
                worker.ReportProgress(0);
            }
        }

        // The ProgressChanged event is raised by the DoWork method.
        // This event handler does work that is internal to the
        // control. In this case, the text is toggled between its
        // light and dark state, and the control is told to
        // repaint itself.
        private void backgroundWorker1_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            this.isLit = !this.isLit;
            this.Refresh();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            // The text is painted in the light or dark color,
            // depending on the current value of isLit.
            this.ForeColor =
                this.isLit ? this.lightColorValue : this.darkColorValue;

            base.OnPaint(e);
        }
    }
}
