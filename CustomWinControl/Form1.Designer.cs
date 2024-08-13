namespace CustomWinControl
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
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.firstControl1 = new FirstControl();
            this.SuspendLayout();

            //
            // firstControl1
            //
            this.firstControl1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.firstControl1.Location = new System.Drawing.Point(96, 104);
            this.firstControl1.Name = "firstControl1";
            this.firstControl1.Size = new System.Drawing.Size(75, 16);
            this.firstControl1.TabIndex = 0;
            this.firstControl1.Text = "Hello World";
            this.firstControl1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;

            //
            // SimpleForm
            //
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.firstControl1);
            this.Name = "SimpleForm";
            this.Text = "SimpleForm";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
