namespace SerializationDemoControlTest
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
            serializationDemoControl1 = new SerializationDemoControlLib.SerializationDemoControl();
            SuspendLayout();
            // 
            // serializationDemoControl1
            // 
            serializationDemoControl1.Location = new Point(-2, -1);
            serializationDemoControl1.Name = "serializationDemoControl1";
            serializationDemoControl1.Padding = new Padding(10);
            serializationDemoControl1.Size = new Size(800, 450);
            serializationDemoControl1.Strings = new string[]
                {
                "hola",
                "crayola",
                "tu cajita",
                "de sorpresas"
                };
            serializationDemoControl1.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 517);
            Controls.Add(serializationDemoControl1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private SerializationDemoControlLib.SerializationDemoControl serializationDemoControl1;
    }
}
