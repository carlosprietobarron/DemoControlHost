namespace MarqueeControlLibrary
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            demoMarqueeControl1 = new MarqueeControlTest.DemoMarqueeControl();
            SuspendLayout();
            // 
            // demoMarqueeControl1
            // 
            demoMarqueeControl1.Location = new Point(-1, 1);
            demoMarqueeControl1.Name = "demoMarqueeControl1";
            demoMarqueeControl1.Size = new Size(800, 450);
            demoMarqueeControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(demoMarqueeControl1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private MarqueeControlTest.DemoMarqueeControl demoMarqueeControl1;
    }
}
