using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ButtonRendererSample
{
    partial class  Form1 : Form
    {
        public Form1()
            : base()
        {
            CustomButton Button1 = new CustomButton();
            Controls.Add(Button1);

            if (Application.RenderWithVisualStyles)
                this.Text = "Visual Styles Enabled";
            else
                this.Text = "Visual Styles Disabled";

            CustomComboBox ComboBox1 = new CustomComboBox();
            Controls.Add(ComboBox1);
        }

        [STAThread]
        static void Main()
        {
            // If you do not call EnableVisualStyles below, then   
            // ButtonRenderer automatically detects this and draws
            // the button without visual styles.
            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }

 }