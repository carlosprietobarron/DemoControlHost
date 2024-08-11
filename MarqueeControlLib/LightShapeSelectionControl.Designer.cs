namespace MarqueeControlLib
{
    partial class LightShapeSelectionControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            circlePanel = new Panel();
            squarePanel = new Panel();
            SuspendLayout();
            // 
            // circlePanel
            // 
            circlePanel.Location = new Point(12, 12);
            circlePanel.Name = "circlePanel";
            circlePanel.Size = new Size(376, 426);
            circlePanel.TabIndex = 0;
            // 
            // squarePanel
            // 
            squarePanel.Location = new Point(394, 12);
            squarePanel.Name = "squarePanel";
            squarePanel.Size = new Size(406, 426);
            squarePanel.TabIndex = 1;
            // 
            // LightShapeSelectionControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(squarePanel);
            Controls.Add(circlePanel);
            Name = "LightShapeSelectionControl";
            Text = "LightShapeSelectionControl";
            ResumeLayout(false);
        }

        #endregion

        private Panel circlePanel;
        private Panel squarePanel;
    }
}