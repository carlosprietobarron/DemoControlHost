using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using static MarqueeControlLib.MarqueeBorder;

namespace MarqueeControlLib
{
    public partial class LightShapeSelectionControl : Form
    {
        private IWindowsFormsEditorService editorService;

        public MarqueeLightShape lightShapeValue { get; private set; }

        private void squarePanel_Click(object sender, EventArgs e)
        {
            this.lightShapeValue = MarqueeLightShape.Square;

            this.Invalidate(false);

            this.editorService.CloseDropDown();
        }

        private void circlePanel_Click(object sender, EventArgs e)
        {
            this.lightShapeValue = MarqueeLightShape.Circle;

            this.Invalidate(false);

            this.editorService.CloseDropDown();
        }
        // This constructor takes a MarqueeLightShape value from the
        // design-time environment, which will be used to display
        // the initial state.
        public LightShapeSelectionControl(
            MarqueeLightShape lightShape,
            IWindowsFormsEditorService editorService)
        {
            // This call is required by the designer.
            InitializeComponent();

            // Cache the light shape value provided by the
            // design-time environment.
            this.lightShapeValue = lightShape;

            // Cache the reference to the editor service.
            this.editorService = editorService;

            // Handle the Click event for the two panels.
            this.squarePanel.Click += new EventHandler(squarePanel_Click);
            this.circlePanel.Click += new EventHandler(circlePanel_Click);
        }
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                // Be sure to unhook event handlers
                // to prevent "lapsed listener" leaks.
                this.squarePanel.Click -=
                    new EventHandler(squarePanel_Click);
                this.circlePanel.Click -=
                    new EventHandler(circlePanel_Click);

                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (
                Graphics gSquare = this.squarePanel.CreateGraphics(),
                gCircle = this.circlePanel.CreateGraphics())
            {
                // Draw a filled square in the client area of
                // the squarePanel control.
                gSquare.FillRectangle(
                    Brushes.Red,
                    0,
                    0,
                    this.squarePanel.Width,
                    this.squarePanel.Height
                    );

                // If the Square option has been selected, draw a
                // border inside the squarePanel.
                if (this.lightShapeValue == MarqueeLightShape.Square)
                {
                    gSquare.DrawRectangle(
                        Pens.Black,
                        0,
                        0,
                        this.squarePanel.Width - 1,
                        this.squarePanel.Height - 1);
                }

                // Draw a filled circle in the client area of
                // the circlePanel control.
                gCircle.Clear(this.circlePanel.BackColor);
                gCircle.FillEllipse(
                    Brushes.Blue,
                    0,
                    0,
                    this.circlePanel.Width,
                    this.circlePanel.Height
                    );

                // If the Circle option has been selected, draw a
                // border inside the circlePanel.
                if (this.lightShapeValue == MarqueeLightShape.Circle)
                {
                    gCircle.DrawRectangle(
                        Pens.Black,
                        0,
                        0,
                        this.circlePanel.Width - 1,
                        this.circlePanel.Height - 1);
                }
            }
        }
    }
}
